using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;


public class TestQueue
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       var queue = new Queue<int>();
       for(var i=0;i<10000000;i++)
       {
           queue.Enqueue(i);
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to queue: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
    }
}