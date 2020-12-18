using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оратівський Сергій. ПЗС-2044. 2020р.
            Console.WriteLine("Оратiвський Сергiй. ПЗС-2044");
            Student st = new Student();
            st.InputInfo();
            st.Query();
        }

    }
    class Student
    {
        List<People> people = new List<People>();
        public void InputInfo()
        {
            Console.WriteLine("Введите имя");
            String name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            String Age = Console.ReadLine();
            Console.WriteLine("Введите пол");
            String Sex = Console.ReadLine();
            Console.WriteLine("Введите телефон");
            String Telephone = Console.ReadLine();
            people.Add(new People() { Name = name, Age = Age, Sex = Sex, Telephone = Telephone});
        }
        public void GetInfo()
        {
            foreach (People p in people)
            {
                Console.WriteLine("Имя: " + p.Name);
                Console.WriteLine("Фамилия: " + p.Age);
                Console.WriteLine("Отчество: " + p.Sex);
                Console.WriteLine("Номер телефона: " + p.Telephone);
            }
        }
        public void GetSolo()
        {
            Console.WriteLine("Введите id");
            int poz = Convert.ToInt32(Console.ReadLine());
            poz--;
            if (poz < people.Count)
            {
               
                Console.WriteLine("Имя: " + people[poz].Name);
                Console.WriteLine("Фамилия: " + people[poz].Age);
                Console.WriteLine("Отчество: " + people[poz].Sex);
                Console.WriteLine("Номер телефона: " + people[poz].Telephone);
            }
            else Console.WriteLine("Введите правильный id");
        }  

        public void ChangeStudent()
        {
            Console.WriteLine("Введите id студента, которого хотите изменить");
            int poz = Convert.ToInt32(Console.ReadLine());
                if (poz < people.Count)
                {
                   poz--;
                   Console.WriteLine("Введите имя");
                    people[poz].Name = Console.ReadLine();
                    Console.WriteLine("Введите возраст");
                    people[poz].Age = Console.ReadLine();
                    Console.WriteLine("Введите пол");
                    people[poz].Sex = Console.ReadLine();
                    Console.WriteLine("Введите телефон");
                    people[poz].Telephone = Console.ReadLine();
                }
                else Console.WriteLine("Введите правильный id");
        }
        public void Query()
        {
            Boolean exit = false;
            Char quer;
            Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов, t - посмотреть определенного студента, с - изменить студента, x - выход");
            quer = Convert.ToChar(Console.ReadLine());
            while (exit == false)
            {
                switch (quer)
                {
                    case 'n':
                        InputInfo();
                        Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов, t - посмотреть определенного студента, с - изменить студента, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                    case 's':
                        Console.WriteLine("Всё студенты:");
                        GetInfo();
                        Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов,t - посмотреть определенного студента, с - изменить студента, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'x':
                        exit = true;
                        break;

                    case 't':
                        GetSolo();
                        Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов, t - посмотреть определенного студента, с - изменить студента, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;

                    case 'c':
                        ChangeStudent();
                        Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов, t - посмотреть определенного студента, с - изменить студента, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Нажмите правильную букву");
                        Console.WriteLine("Выберите действие: n - новый студент, s - посмотреть всёх студентов, t - посмотреть определенного студента, с - изменить студента, x - выход");
                        quer = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
        }
    }
    class People
    {
        public string Name;
        public string Age;
        public string Sex;
        public string Telephone;
    }
}
