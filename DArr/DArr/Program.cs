using System;


class Program
{
    public static void Main()
    {

        string[] myArr = { };
        DArr dArr = new DArr();
        dArr.Menu(myArr);
    }
}
class DArr
{
    public string[] str { get; set; }
    static String[] ResizeArr(String[] arr)
    {
        Array.Resize(ref arr, arr.Length + 1);
        Console.WriteLine("Введите значение");
        arr[arr.Length - 1] = Console.ReadLine();
        return arr;
    }
    static String[] DeleteElement(String[] arr)
    {
        arr[arr.Length - 1] = " ";
        return arr;
    }
    public void ShowArr(String[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("arr[" + i + "]=" + arr[i]);
        }
    }
        
    public String this[int i]
    {
        get
        {
            String[] arr = { };
            return arr[i];
        }
    }

    public static String operator +(DArr dArr, int a)
    {
        return dArr.str[0] + a;
     }

    public static DArr operator ++(DArr dArr)
    {
        dArr.str = ResizeArr(dArr.str);
        return dArr;
    }
    public static DArr operator --(DArr dArr)
    {
        dArr.str = DeleteElement(dArr.str);
        return dArr;
    }



    public void Menu(String[]arr)
    {
        string query;
        Console.WriteLine("Введите команду: add, show, +, -, ++, -- "); 
        query = Convert.ToString(Console.ReadLine());
        DArr dArr123 = new DArr();
        Boolean exit = false;
        while (exit == false)
            switch (query)
            {
                case "add":
                    arr = ResizeArr(arr);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "++":
                    arr = ResizeArr(arr);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "delete":
                    arr = DeleteElement(arr);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "--":
                    arr = DeleteElement(arr);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "show":
                    ShowArr(arr);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "+":
                    int n;
                    Console.WriteLine("Введите что добавить к вашему первому элементу");
                    n = Convert.ToInt32(Console.ReadLine());
                    arr[0] = arr[0] + n;
                    Console.WriteLine("Первый элемент массива + 10 будет: " + arr[0]);
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Введите команду:");
                    query = Convert.ToString(Console.ReadLine());
                    break;
            }
    }
}
