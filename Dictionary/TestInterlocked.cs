using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;



public class TestInterlocked
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       int val = 0;
       for(var i=0;i<10000000;i++)
       {
           Interlocked.Add(ref val, 1);
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to Interlocked: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
    }
    
    public static void Test2()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       long val = 0;
       for(var i=0;i<10000000;i++)
       {
           Interlocked.Add(ref val, 1);
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to Interlocked: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
    }
    
    public static void Test3()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       var sync = new object();
       long val = 0;
       for(var i=0;i<10000000;i++)
       {
           lock(sync)
           {
               val+=1;
           }   
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to lock: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
    }
}