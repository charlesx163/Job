namespace Jobs
{
    public class Job
    {
        private readonly Action _work;
        private Job? _continue;
        public Exception? Exception { get; private set; }
        public Job(Action work)=> _work = work;
        public JobStatus Status { get; internal set; }
        public void Start(JobScheduler? scheduler = null) => (scheduler ?? JobScheduler.Current).QueueJob(this);
        internal protected virtual void Invoke()
        {
            Status = JobStatus.Running;
            _work();
            Status = JobStatus.Completed;
            _continue?.Start();
        }
        public Job ContinueWith(Action<Job> continuation)
        {
            if (_continue == null)
            {
                var job = new Job(() => continuation(this));
                _continue = job;
            }
            else
            {
                _continue.ContinueWith(continuation);
            }
            return this;
        }
        public JobAwaiter GetAwaiter() => new(this);
        public static Job Run(Action work)
        {
            var job = new Job(work);
            job.Start();
            return job;
        }
    }
}