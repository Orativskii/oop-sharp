
using System;
using System.Collections.Generic;
using System.Threading;

namespace BusStation
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            station.Menu();
        }
    }
     class Station
    {
        int PeopleStation = 0;
        int DayTime = 1;
        int NumberPeople = 0;
        int freePlace = 0;
    
        int timeWait = 0;
        double LastTime = 0;
        double resultTimeWait = 0;
        int TimeBus = 1;
        int NumberBus = 0;
        public void People()
        {
            NumberPeople = 0;
            Random rnd = new Random();
            if (DayTime == 1)
            {
                NumberPeople = rnd.Next(1, 10);
            }
            else if (DayTime == 2)
            {
                NumberPeople = rnd.Next(1, 20);
            }
            else if (DayTime == 3)
            {
                NumberPeople = rnd.Next(1, 7);
            }
            
            resultTimeWait = 0;
            timeWait = 0;
            Console.WriteLine("На остановке: " + NumberPeople + " новых людей и " + PeopleStation + " людей, которые не поместились в прошлую маршрутку");       
                for (int i = 0; i < NumberPeople; i++)
                {
                    timeWait = rnd.Next(0, TimeBus);
                    resultTimeWait += timeWait;
                }
                resultTimeWait = resultTimeWait / NumberPeople;
                resultTimeWait += LastTime;
                NumberPeople += PeopleStation;
                PeopleStation = 0;   
            Console.WriteLine("В среднем люди ждали маршрутку: " + Math.Round(resultTimeWait, 3) + " минут");
            Bus(NumberPeople);
            if (PeopleStation != 0)
            {
                LastTime = resultTimeWait;
            }
            else LastTime = 0;
            }
        public int Bus(int NumberPeople)
        {
            freePlace = 0;
            Random rnd = new Random();
            if (DayTime == 1)
            {
                 freePlace = rnd.Next(0, 24);
            }
            else if (DayTime == 2)
            {
                freePlace = rnd.Next(0, 15);
            }
            else if (DayTime == 3)
            {
                NumberPeople = rnd.Next(5, 24);
            }
            
            Console.WriteLine("Свободных мест в автобусе: " + freePlace);
                 if (NumberPeople <= freePlace)
                 {
                     freePlace = freePlace - NumberPeople;
                     NumberPeople = 0;
                 }
                 else if (NumberPeople > freePlace)
                 {
                     NumberPeople = NumberPeople - freePlace;
                     freePlace = 0;
                     PeopleStation = NumberPeople;
                 }
            Console.WriteLine("Осталось людей на остановке: " + NumberPeople);      
            return PeopleStation;
        }

        public void Menu()
        {
            
            Boolean start = true;
            while (start)
            {
                Console.WriteLine("Введите 1 - утро, 2 - обед, 3 - вечер, для просмотра статистики. 0 - выход");
                int DayTime = Convert.ToInt32(Console.ReadLine());
                    if (DayTime == 1)
                    {
                          Console.WriteLine("Введите в минутах промежуток времени между приходом автобусов с 5 утра до 10 утра");
                          TimeBus = Convert.ToInt32(Console.ReadLine());
                          NumberBus = 300 / TimeBus;
                             for (int i = 0; i < NumberBus; i++)
                             {
                                 Console.WriteLine("Утренний автобус № " + i);
                                 People();
                                 Console.WriteLine(" ");
                             }
                    }
                     else if (DayTime == 2)
                     {
                          Console.WriteLine("Введите в минутах промежуток времени между приходом автобусов с 10 утра до 7 дня");
                          TimeBus = Convert.ToInt32(Console.ReadLine());
                          NumberBus = 540 / TimeBus;
                               for (int i = 0; i < NumberBus; i++)
                                 {
                                      Console.WriteLine("Дневной автобус № " + i);
                                      People();
                                      Console.WriteLine(" ");
                                 }
                      }
                     else if (DayTime == 3)
                     {
                          Console.WriteLine("Введите в минутах промежуток времени между приходом автобусов с 7 дня до 10 вечера");
                          TimeBus = Convert.ToInt32(Console.ReadLine());
                          NumberBus = 180 / TimeBus;
                               for (int i = 0; i < NumberBus; i++)
                                 {
                                      Console.WriteLine("Вечерний автобус № " + i);
                                      People();
                                      Console.WriteLine(" ");
                                 }
                      }
                      else if (DayTime == 0)
                      {
                         start = false;
                      }
                      else
                      {
                         Console.WriteLine("Введите правильную цифру ");
                      }
            }
        }
    }
}