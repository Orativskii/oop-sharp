using System;

namespace Overcoat
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Введите первую строку");
            str = Convert.ToString(Console.ReadLine());
            String str1;
            Console.WriteLine("Введите вторую строку");
            str1 = Convert.ToString(Console.ReadLine());

            Stringcl string1 = new Stringcl("1");


            Stringcl s1 = new Stringcl(str);
            Stringcl s2 = new Stringcl(str1);

            String query;
            Console.WriteLine("Введите: >, search, length, +");
            query = Convert.ToString(Console.ReadLine());
            switch (query)
            {
                case ">":
                    if (s1 > s2) Console.WriteLine("Первая вещь дороже");
                    else Console.WriteLine("Вторая вещь дороже");
                    break;
                case "search":
                    string1.Search(s1);
                    break;
                case "length":
                    string1.Length(s1);
                    break;
                case "+":
                    Console.WriteLine(s1.str + s2.str);
                    break;
            }
        }
    }
    class Stringcl
    {
        public string str;

        public Stringcl(string text) 
        {
            str = text;
        }

        public static bool operator >(Stringcl s1, Stringcl s2)
        {
            return s1.str.Length > s2.str.Length;
        }
        public static bool operator <(Stringcl s1, Stringcl s2)
        {
            return s1.str.Length < s2.str.Length;
        }
        public void Search(Stringcl s1)
        {
            Console.WriteLine("Введите нужный символ");
            char symb = Convert.ToChar(Console.ReadLine());
            String poz = " ";
            for(int i = 0; i<s1.str.Length;i++)
            {
                if (symb == s1.str[i]) poz += i+1 + " ";
            }
            Console.WriteLine("Символ: " + symb + " стоит на: " + poz + " позицие/ях в строке " + s1.str);
        }
        public void Length(Stringcl s1)
        {  
            Console.WriteLine("Длина строки:" + s1.str.Length + " символов");
        }

        public static Stringcl operator +(Stringcl s1, Stringcl s2)
        {
            return new Stringcl("1")
            {
                str = s1.str + s2.str
            };
        }

    }
}
