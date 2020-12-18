using System;

namespace Overcoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оратівський Сергій. ПЗС-2044. 2020р.
            Console.WriteLine("Оратiвський Сергiй. ПЗС-2044");
            Overcoat overcoat = new Overcoat();
            var titlein = overcoat.TitleInput();
            var pricein = overcoat.PriceInput();
            Overcoat o1 = new Overcoat { Title = titlein[0], Price = pricein[0] };
            Overcoat o2 = new Overcoat { Title = titlein[1], Price = pricein[1] };
            String query;
            Console.WriteLine("Введите знак: == ; = ; >");
            query = Convert.ToString(Console.ReadLine());
            switch (query)
            {
                case "==":
                    if(o1 == o2) Console.WriteLine("Вещи  одинаковые");
                    else Console.WriteLine("Вещи разные");
                    break;
                case "=":
                    Overcoat o3 = o1;
                    Console.WriteLine("Мы присвоили значение первого обьекта в новый третий обьект");
                    Console.WriteLine(o3.Title + " " + o3.Price);
                        break;
                case ">":
                    if (o1 > o2) Console.WriteLine("Первая вещь дороже");
                    else Console.WriteLine("Вторая вещь дороже");
                    break;
            }
        }
    }
    class Overcoat
    {
        public String[] TitleInput()
        {
            Console.WriteLine("Введите название первой вещи");
            String Title1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите название второй вещи");
            String Title2 = Convert.ToString(Console.ReadLine());
            String[] arr = new String[2] { Title1, Title2 };
            return arr;
        }
        public Double[] PriceInput()
        {
            Console.WriteLine("Введите цену первой вещи");
            Double price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену второй вещи");
            Double price2 = Convert.ToDouble(Console.ReadLine());
            Double[] arr = new Double[2] { price1, price2 };
            return arr;
        }
        public String Title { get; set; }
        public Double Price { get; set; }

        public static bool operator ==(Overcoat o1, Overcoat o2)
        {
            return o1.Price == o2.Price;
        }
        public static bool operator !=(Overcoat o1, Overcoat o2)
        {
            return o1.Price != o2.Price;
        }
        public static Overcoat operator +(Overcoat o1)
        {
            return new Overcoat
            {
                Title = o1.Title,
                Price = o1.Price
            };
        }
        public static bool operator >(Overcoat o1, Overcoat o2)
        {
            return o1.Price > o2.Price;
        }
        public static bool operator <(Overcoat o1, Overcoat o2)
        {
            return o1.Price < o2.Price;
        }
    }
}
