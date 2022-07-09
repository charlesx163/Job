# Job
A Project that releated to ThreadPool and to illustrate that task is based on Theardpool

This project demostrate that how Task.Run works
when we use Task.Run(Task) to run a task, actually, the task will be queue to the thread pool by
using ThreadPool.QueueUserWorkItem()
