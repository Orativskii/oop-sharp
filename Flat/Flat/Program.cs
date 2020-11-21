using System;

namespace Flat
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            var inp = flat.Input();
            Flat o1 = new Flat { Cost = inp[0], Area = inp[1] };
            Flat o2 = new Flat { Cost = inp[2], Area = inp[3] };
            String query;
            Console.WriteLine("Введите знак: == ; = ; >");
            query = Convert.ToString(Console.ReadLine());
            switch (query)
            {
                case "==":
                    if (o1 == o2) Console.WriteLine("Площадь квартир одинаковая");
                    else Console.WriteLine("Площади квартир разные");
                    break;
                case "=":
                    Flat o3 = o1;
                    Console.WriteLine("Мы присвоили значения первого обьекта в новый третий обьект");
                    Console.WriteLine(o3.Cost + " " + o3.Area);
                    break;
                case ">":
                    if (o1 > o2) Console.WriteLine("Первая квартира дороже");
                    else Console.WriteLine("Вторая квартира дороже");
                    break;
            }
        }
    }
    class Flat
    {
        public Double[] Input()
        {
            Console.WriteLine("Введите цену первой квартиры");
            Double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь первой квартиры");
            Double area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену второй квартиры");
            Double cost1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь второй квартиры");
            Double area1 = Convert.ToDouble(Console.ReadLine());
            Double[] arr = new Double[4] { cost, area, cost1, area1};
            return arr;
        }
      
        public Double Cost { get; set; }
        public Double Area { get; set; }

        public static bool operator ==(Flat o1, Flat o2)
        {
            return o1.Area == o2.Area;
        }
        public static bool operator !=(Flat o1, Flat o2)
        {
            return o1.Area != o2.Area;
        }
        public static Flat operator +(Flat o1)
        {
            return new Flat
            {
                Cost = o1.Cost,
                Area = o1.Area
            };
        }
        public static bool operator >(Flat o1, Flat o2)
        {
            return o1.Cost > o2.Cost;
        }
        public static bool operator <(Flat o1, Flat o2)
        {
            return o1.Cost < o2.Cost;
        }
    }
}
