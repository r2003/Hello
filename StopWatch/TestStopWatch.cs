using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;


public class TestStopWatch
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       for(var i=0;i<1000000;i++)
       {
           var sw = Stopwatch.StartNew();
           sw.Stop();
       }
       stopwatch.Stop();
       Console.WriteLine("Start and stop 10 000 00 stopWatch: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
        
    }
}