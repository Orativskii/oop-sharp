using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оратівський Сергій. ПЗС-2044. 2020р.
            Console.WriteLine("Оратiвський Сергiй. ПЗС-2044");
            Counter ct = new Counter();
            var zminna = ct.Input();
            Counter c1 = new Counter { A = zminna[0], Bi = zminna[1]};
            Counter c2 = new Counter { A = zminna[2], Bi = zminna[3]};
            Char query;
            Console.WriteLine("Введите знак");
            query = Convert.ToChar(Console.ReadLine());
            switch(query)
            {
                case '+':
                    Counter c3 = c1 + c2;
                    Console.WriteLine("(" + c1.A + " + " + c1.Bi + "i) + " + "(" + c2.A + " + " + c2.Bi + "i) = " + c3.A + "+" + c3.Bi + "i");
                    break;
                case '-':
                    Counter c4 = c1 - c2;
                    Console.WriteLine("(" + c1.A + " + " + c1.Bi + "i) - " + "(" + c2.A + " + " + c2.Bi + "i) = " + c4.A + "+" + c4.Bi + "i");
                    break;
                case '*':
                    Counter c5 = c1 * c2;
                    Console.WriteLine("(" + c1.A + " + " + c1.Bi + "i) * " + "(" + c2.A + " + " + c2.Bi + "i) = " + c5.A + "+" + c5.Bi + "i");
                    break;
                case '/':
                    Counter c6 = c1 / c2;
                    Console.WriteLine("(" + c1.A + " + " + c1.Bi + "i) / " + "(" + c2.A + " + " + c2.Bi + "i) = " + c6.A + "+" + c6.Bi + "i");
                    break;
            }
        }
    }
    class Counter
    {
        public Double[] Input()
        {
            Console.WriteLine("Введите первую часть первого числа");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую часть первого числа ");
            Double b = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Введите первую часть второго числа");
            Double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую часть второго числа");
            Double b1 = Convert.ToDouble(Console.ReadLine());
            Double[] arr = new Double[4] { a, b, a1, b1 };
            return arr;
        }
        public Double A { get; set; }
        public Double Bi { get; set; }

        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter
            {
                A = c1.A + c2.A,
                Bi = c1.Bi + c2.Bi
            };
        }
        public static Counter operator -(Counter c1, Counter c2)
        {
            return new Counter
            {
                A = c1.A - c2.A,
                Bi = c1.Bi - c2.Bi
            };
        }
        public static Counter operator *(Counter c1, Counter c2)
        {
            return new Counter
            {
                A = (c1.A * c2.A) - (c1.Bi * c2.Bi),
                Bi = (c1.A * c2.Bi) + (c1.Bi * c2.A)
            };
        }
        public static Counter operator /(Counter c1, Counter c2)
        {
            return new Counter
            {
                A = (c1.A * c2.A + c1.Bi * c2.Bi) / (c2.A * c2.A + c2.Bi * c2.Bi) ,
              
                Bi = (c1.Bi * c2.A - c1.A * c2.Bi) / (c2.A * c2.A + c2.Bi * c2.Bi)
            };
        }
    }
}



