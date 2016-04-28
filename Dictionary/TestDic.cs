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
       var dictionary = new Dictionary<int,int>();
       for(var i=0;i<1000000;i++)
       {
           dictionary.Add(i,i);
           
       }
       stopwatch.Stop();
       Console.WriteLine("Add 1000000(int) elements to dictionary: {0} ms.",stopwatch.Elapsed.TotalMilliseconds); 
       Console.WriteLine(dictionary[9999]);
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
        
}

