using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DribNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Drib drib = new Drib();
            drib.InputOutput();
            Console.WriteLine("Введите знак");
            string reziltaticse = Console.ReadLine();
            string REZ = drib.Calc(reziltaticse);
            Console.WriteLine(REZ);

        }
    }
    class Drib
    {

        int[] arr;
        public void InputOutput()
        {
            Console.WriteLine("Введите чисельник первого числа ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменник первого числа ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чисельник второго числа ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменник второго числа ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            arr = new int[4] { a, b, a1, b1 };
        }

        public String Calc(string znak)
        {
            if (znak == "+")
            {
                if (arr[1] == arr[3])
                {
                    double result = arr[0] + arr[2];
                    String rez = result + "/" + arr[1];

                    return rez;
                }
                if (arr[1] != arr[3])
                {
                    double result = (arr[0] * arr[3] + arr[1] * arr[2]);
                    double result1 = arr[1] * arr[3];
                    String rez = result + "/" + result1;
                    return rez;
                }
            }
            else if (znak == "-")
            {
                if (arr[1] == arr[3])
                {
                    double result = arr[0] - arr[2];
                    String rez = result + "/" + arr[1];

                    return rez;
                }
                if (arr[1] != arr[3])
                {
                    double result = (arr[0] * arr[3] - arr[1] * arr[2]);
                    double result1 = arr[1] * arr[3];
                    String rez = result + "/" + result1;
                    return rez;
                }
            }
            else if (znak == "*")
            {
                double result = arr[0] * arr[2];
                double result1 = arr[1] * arr[3];
                String rez = result + "/" + result1;
                return rez;
            }
            else if (znak == "/")
            {
                double result = arr[0] * arr[3];
                double result1 = arr[1] * arr[2];
                String rez = result + "/" + result1;
                return rez;
            }
            return " ";
        }
    }
}



