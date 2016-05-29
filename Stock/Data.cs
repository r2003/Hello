using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.IO;


public class Data
{
    public static void Test1()
    {
       //Одна стратегия покупки
       //Другая стратегия продажи.
       //Если большой объем на прдажу. Надо продавать.
       //Если большой объем на покупку надо покупать.
       //Смотреть есть ли движение в стакане по цене.
       //Имеется ввиду перемещение объема покупки или продажи.
       //Если есть значит решили повышать предложение или понимжать продажу
       
       //Строить стратегию текущего дня по предыдущему типу дня.
       //Не торговать рядом с праздниками.
       
       
       //Максимальный последовательный рост.
       //Максимальное последовательное падение.
       //Количество событий изменений направлений тренда цены.
       //
       //Одна сделка в дне покупка-продажа или продажа-покупка
       //Две таких сделки.
       
       //Считать количество вершин.
       double before1 = 0;//front
       double before2 = 0;//front
       var after = 0;//rear
       
       double vertex = 0;
       double cavity = 0;
       
       var lowCount = 0;
       var hightCount = 0;
       
       
       var txt = File.ReadAllText("Data/20160412/SBER/AllTrade.log");
       var str = txt.Split('\n');
       foreach(var line in str)
       {
           if(string.IsNullOrEmpty(line))
           {
                continue;               
           }
           
           var values = line.Split(' ');
           if(values.Length<3)
           {
               continue;
           }
           double price; 
           if(!double.TryParse(values[9].TrimEnd(new char[]{','}).Replace(',','.'), out price))
           {
               continue;
           }
           //Console.WriteLine("{0}\t{1}\t{2}",before2,before1,price);
           if(before2>before1 && before1<price)
           {
               lowCount++;
               
               Console.WriteLine("{0}\t{1}\t{2}\t-\t{3}\t{4}",cavity,vertex,before1,vertex-cavity,vertex-before1);
               
               cavity=before1;
           }
           if(before2<before1 && before1>price)
           {
               hightCount++;
               vertex=before1;
           }
                     
           before2 = before1;
           before1 = price;
           
           
       }
       Console.WriteLine("lowCount: {0}, hightCount: {1}",lowCount,hightCount);

    }
}
