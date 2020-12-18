using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оратівський Сергій. ПЗС-2044. 2020р.
            Console.WriteLine("Оратiвський Сергiй. ПЗС-2044");
            PhoneBook pb = new PhoneBook();
            pb.InputInfo();
            pb.Query();
        }
        
    }
    class PhoneBook
    {     
        List<Consumer> consumers = new List<Consumer>();
        public void InputInfo()
        {
            Console.WriteLine("Введите имя");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            String Sname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            String Fname = Console.ReadLine();
            Console.WriteLine("Введите телефон");
            String Telephone = Console.ReadLine();
            Console.WriteLine("Введите информацию");
            String Information = Console.ReadLine();
            consumers.Add(new Consumer() { Name = name, SName = Sname, FName = Fname, Telephone = Telephone, Information = Information });
        }
        public void GetInfo()
        {
            foreach (Consumer p in consumers)
            {
                Console.WriteLine("Имя: " + p.Name);
                Console.WriteLine("Фамилия: " + p.SName);
                Console.WriteLine("Отчество: " + p.FName);
                Console.WriteLine("Номер телефона: " + p.Telephone);
                Console.WriteLine("Дополнительно: " + p.Information);
            }
        }
        public void Query()
        {
            Boolean exit = false;
            Char quer;
            Console.WriteLine("Выберите действие: n - новый абонент, s - посмотреть всёх абонентов, x - выход");
            quer = Convert.ToChar(Console.ReadLine());
            while (exit == false)
            {
                
                switch (quer)
                {
                    case 'n':
                        InputInfo();
                        Console.WriteLine("Выберите действие: n - новый абонент, s - посмотреть всёх абонентов, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                    case 's':
                        Console.WriteLine("Всё абоненты в телефонной книге:");
                        GetInfo();
                        Console.WriteLine("Выберите действие: n - новый абонент, s - посмотреть всёх абонентов, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'x':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Нажмите правильную букву");
                        Console.WriteLine("Выберите действие: n - новый абонент, s - посмотреть всёх абонентов, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
        }
    }
    class Consumer
    {
        public string Name;
        public string SName;
        public string FName;
        public string Telephone;
        public string Information;
    }
}
