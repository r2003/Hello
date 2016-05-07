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
        
        
        for(var i=0;i<10;i++)
        {
           stopwatch.Restart();
           Test2(); 
           Console.WriteLine("Test1: {0}.",stopwatch.Elapsed.TotalMilliseconds);
           Console.WriteLine("Test4: {0}.",stopwatch.Elapsed.TotalMilliseconds-test2-test3);
           test2=0;
           test3=0;     
        }
        
        for(var i=0;i<10;i++)
        {
           stopwatch.Restart();
           Test5(); 
           Console.WriteLine("-Test5: {0}.",stopwatch.Elapsed.TotalMilliseconds);
           Console.WriteLine("+Test6: {0}.",stopwatch.Elapsed.TotalMilliseconds-test2-test3);
           test5=0;
           test6=0;     
        }
        
    }
    
    private static double test2;
    private static double test3;
    
    public static void Test2()
    {
        var sw= Stopwatch.StartNew();
        for(var i=0;i<1000;i++)
        {
            Test3(sw);
            Thread.Sleep(1);
        }
        sw.Stop();
        
        Console.WriteLine("Test2: {0}.",test2);
        Console.WriteLine("Test3: {0}.",test3);
   
    }
    
    public static void Test3(Stopwatch sw)
    {
        test2+=sw.Elapsed.TotalMilliseconds;
        sw.Restart();
        
        Thread.Sleep(1);
        
        test3+=sw.Elapsed.TotalMilliseconds;
        sw.Restart();
    }   
    
    
    private static double test5;
    private static double test6;
    
    public static void Test5()
    {
        var sw= Stopwatch.StartNew();
        for(var i=0;i<1000;i++)
        {
            Test6(sw);
            Thread.Sleep(1);
        }
        sw.Stop();
        
        Console.WriteLine("Test5: {0}.",test5);
        Console.WriteLine("Test6: {0}.",test6);
   
    }
    
    public static void Test6(Stopwatch sw)
    {
        test5+=sw.ElapsedMilliseconds;
        sw.Restart();
        
        Thread.Sleep(1);
        
        test6+=sw.ElapsedMilliseconds;
        sw.Restart();
    }  
    
    public static void TestPrecision()
    {
   int xcnt = 0;
    long xdelta, xstart;
    xstart = DateTime.UtcNow.Ticks;
    do {
        xdelta = DateTime.UtcNow.Ticks - xstart;
        xcnt++;
    } while (xdelta == 0);

    Console.WriteLine("DateTime:\t{0} ms, in {1} cycles", xdelta / (10000.0), xcnt);

    int ycnt = 0, ystart;
    long ydelta;
    ystart = Environment.TickCount;
    do {
        ydelta = Environment.TickCount - ystart;
        ycnt++;
    } while (ydelta == 0);

    Console.WriteLine("Environment:\t{0} ms, in {1} cycles ", ydelta, ycnt);


    Stopwatch sw = new Stopwatch();
    int zcnt = 0;
    long zstart, zdelta;

    sw.Start();
    zstart = sw.ElapsedTicks; // This minimizes the difference (opposed to just using 0)
    do {
        zdelta = sw.ElapsedTicks - zstart;
        zcnt++;
    } while (zdelta == 0);
    sw.Stop();

    Console.WriteLine("StopWatch:\t{0} ms, in {1} cycles", (zdelta * 1000.0) / Stopwatch.Frequency, zcnt);
      
        
    }
}