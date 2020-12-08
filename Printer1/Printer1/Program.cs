using System;
using System.Collections.Generic;
using System.Threading;

namespace Printer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue printer = new Queue();
            printer.Menu();
        }
    }
    class Queue
    {
        String time;
        Queue<Person> persons = new Queue<Person>();
        Person person;
        Queue<PersonPrioritet> personsPrioritet = new Queue<PersonPrioritet>();
        PersonPrioritet personPrioritet;
        Queue<Statistik> statistik = new Queue<Statistik>();
        Statistik statist;
        String userName = "";
        int prioritety = 0;

        public void Input()
        {
            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("Введите приоритетность (1 или 2)");
            prioritety = Convert.ToInt32(Console.ReadLine());
            if (prioritety != 1 && prioritety != 2)
            {
                Console.WriteLine("Приоритетность указана не верно. Попробуйте ещё раз!\n");
                Input();
            }

        }

        public void InputQueue()
        {
            Input();
            if (prioritety == 2)
            {
                time = (DateTime.Now).ToString("HH:mm:ss");
                persons.Enqueue(new Person() { Name = userName, Time = time });
            }
            else if (prioritety == 1)
            {
                time = (DateTime.Now).ToString("HH:mm:ss");
                personsPrioritet.Enqueue(new PersonPrioritet() { Name = userName, Time = time });
            }
        }
        public void Start()
        {

            Boolean start = true;
            while (start)
            {
                if (personsPrioritet.Count != 0)
                {
                    personPrioritet = personsPrioritet.Dequeue();
                    statistik.Enqueue(new Statistik() { Name = personPrioritet.Name, Time = personPrioritet.Time, Prioritet = "1" });

                }
                else if (personsPrioritet.Count == 0 && persons.Count != 0)
                {
                    person = persons.Dequeue();
                    statistik.Enqueue(new Statistik() { Name = person.Name, Time = person.Time, Prioritet = "2" });
                }
                else
                {
                    Console.WriteLine("Все пользователи принтера обслужены! \n");
                    start = false;
                }
            }
        }

        public void ViewStatistik()
        {
            while (statistik.Count != 0)
            {
                statist = statistik.Dequeue();
                Console.WriteLine("Имя пользователя: " + statist.Name);
                Console.WriteLine("Время подачи заявки: " + statist.Time);
                Console.WriteLine("Приоритетность: " + statist.Prioritet);
                Console.WriteLine(" ");
            }
        }

        public void Menu()
        {
            Boolean start = true;
            while (start)
            {
                Console.WriteLine("Введите команду! new - новый запрос, start - для начала печати, view - просмотр статистики, exit - выход.\n");
                String command = Console.ReadLine();
                if (command == "new")
                {
                    Console.WriteLine("Добавляем новый запрос\n");
                    InputQueue();
                    Console.WriteLine("Новый запрос добавлен\n");
                }
                else if (command == "start")
                {
                    Console.WriteLine("Начинаем обработку запросов\n");
                    Start();
                    Console.WriteLine("Обработка окончена!\n");
                }
                else if (command == "view")
                {
                    Console.WriteLine("Просмотр статистики последних пользователей!\n");
                    ViewStatistik();
                    Console.WriteLine("Все запросы просмотрены\n");
                }
                else if (command == "exit")
                {
                    start = false;
                }
                else
                {
                    Console.WriteLine("Введите правильную команду");
                }
            }
        }
    }


    class Person
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class PersonPrioritet
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Statistik
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Prioritet { get; set; }
    }
}
