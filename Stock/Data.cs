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
       
       
       var txt = File.ReadAllText("Data/20160412/SBER/AllTrade.log");
       var str = txt.Split('\n');
       foreach(var line in str)
       {
           if(string.IsNullOrEmpty(line))
           {
                continue;               
           }
           
           var values = line.Split('\t');
           Console.WriteLine("-{0}+{1}",line,values[2]);
       }

    }
}
