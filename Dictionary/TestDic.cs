using System;
using System.Diagnostics;
using System.Threading;


public class TestDic
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       Thread.Sleep(765);
       
       
       
       stopwatch.Stop();
       Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds); 
    }
    
    
}

