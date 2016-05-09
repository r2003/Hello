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
       
       var txt = File.ReadAllText("Data/20160412/SBER/AllTrade.log");
       Console.WriteLine(txt[1]);
    }
}
