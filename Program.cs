using System;
using System.Diagnostics;
using System.Threading;


public class program
{
    public static void Main()
    {
        Console.WriteLine("Test");
        /*
        for(var i=0;i<1000;i++)
        {
            Console.WriteLine(i);
        }
        var a=new Stopwatch();
       a.Start();
       Thread.Sleep(765);
       a.Stop();
       Console.WriteLine(a.Elapsed.TotalMilliseconds);
        */
        /*TestDic.Test1();
        TestArray.Test1();
        TestQueue.Test1();
        TestDic.Test2();
        TestDic.Test3();
        TestDic.Test4();       
         TestDic.Test5();  
         
        TestInterlocked.Test1();  
        TestInterlocked.Test2();        
        TestInterlocked.Test3();   */
        //TestStopWatch.Test1(); 
        TestStopWatch.TestPrecision();
        
                                
        Console.ReadLine();
    }  
}
