using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;


public class TestDic
{
    public static void Test1()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       var dictionary = new Dictionary<int,int>(10000000);
       for(var i=0;i<10000000;i++)
       {
           dictionary.Add(i,i);
           
       }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 0000(int) elements to dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
       stopwatch.Start();
       long sum = 0;
       for(var i=0;i<10000000;i++)
       {
           sum+= dictionary[i];
       }
       stopwatch.Stop();
       Console.WriteLine("Read 10 000 000(int) elements to dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds);            
    }
    
    public static void Test2()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();
       var dictionary = new Dictionary<string,int>();
       for(var i=0;i<1000000;i++)
       {
           dictionary.Add(i.ToString(),i);
           
       }
       stopwatch.Stop();
       Console.WriteLine("Add 1000000(string) elements to dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
    }
    
    public static void Test3()
    {
        Console.WriteLine(string.Intern("abc"));
        Console.WriteLine(string.Intern("a"+"b"+"c"));
        Console.WriteLine(string.Intern("abc").GetHashCode());
        Console.WriteLine(string.Intern("a"+"b"+"c").GetHashCode());  
        
        
    }
    
    public static void Test4()
    {
        Console.WriteLine(1);
        Console.WriteLine(~1);        
        Console.WriteLine(0);
        Console.WriteLine(~0);           
    }
    
    public static void Test5()
    {
       var stopwatch = new Stopwatch();
       stopwatch.Start();        
        
        var d = new Dictionary<int,Dictionary<int,int>>();
        for(var i=0;i<10000;i++)
        {
            var b = new Dictionary<int,int>();
            for(var j=0;j<1000;j++)
            {
                b.Add(j,j*i);
            }
            d.Add(i,b);
        }
       stopwatch.Stop();
       Console.WriteLine("Add 10 000 000(int) elements to double dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds);         
       long sum = 0;
       stopwatch.Start();        
        for(var i=0;i<10000;i++)
        {
            for(var j=0;j<1000;j++)
            {
                sum+= d[i][j];
            }
        }
       stopwatch.Stop();
       Console.WriteLine("Read 10 000 000(int) elements to double dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds);    
    }
       
        
}

