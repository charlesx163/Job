using Jobs;
JobScheduler.Current = new DedicatedThreadJobScheduler(2);
_ = Job.Run(() => Console.WriteLine($"Job1 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));
_ = Job.Run(() => Console.WriteLine($"Job2 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));
_ = Job.Run(() => Console.WriteLine($"Job3 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));
_ = Job.Run(() => Console.WriteLine($"Job4 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));
_ = Job.Run(() => Console.WriteLine($"Job5 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));
_ = Job.Run(() => Console.WriteLine($"Job6 is excuted in thread {Thread.CurrentThread.ManagedThreadId}"));

Console.ReadLine();
//Foo();
//Bar();
//Baz();

//var job = Foo()
//.ContinueWith(_ =>
//{
//    Thread.Sleep(100);
//    Console.WriteLine("Bar");
//})
//.ContinueWith(_ =>
//{
//    Thread.Sleep(100);
//    Console.WriteLine("Baz");
//});

//await job;

//await Foo();
//await Bar();
//await Baz();


//Console.ReadLine();


//static Job Foo() =>  new Job(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Foo");
//});

//static Job Bar() => new Job(() =>
//{
//    Thread.Sleep(100);
//    Console.WriteLine("Bar");
//});

//static Job Baz() => new Job(() =>
//{
//    Thread.Sleep(10);
//    Console.WriteLine("Baz");
//});