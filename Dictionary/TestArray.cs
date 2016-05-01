using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;


public class TestArray
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       var array = new int[10000000];
       for(var i=0;i<10000000;i++)
       {
           array[i]=i;
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to array: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
       stopwatch.Start();
       long sum = 0;
       for(var i=0;i<10000000;i++)
       {
           sum+= array[i];
       }
       stopwatch.Stop();
       Console.WriteLine("Read 10 000 000(int) elements to dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds);    
    
    }
 
 
 }