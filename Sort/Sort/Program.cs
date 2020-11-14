using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
         static void Main(string[] args)
        {



            int[] masBubble = new int[5] { 5, 1, 6, 12, 4 };
            SortedBubble sortB = new SortedBubble();
            sortB.SortedBuble(masBubble);
            Console.WriteLine("Сортировка пузырьком");
            for (int i = 0; i < 5; i++) Console.Write(masBubble[i] + " ");
            Console.WriteLine(" ");



            int[] masInsert = new int[5] { 653, 27, 323, 12, 534 };
            SortedInser sortI = new SortedInser();
            sortI.SortedInsert(masInsert);
            Console.WriteLine("Сортировка вставками");
            for (int i = 0; i < 5; i++) Console.Write(masInsert[i] + " ");
            Console.WriteLine(" ");



            int[] masVibor = new int[5] { 34, 1, 8543, 23, 5 };
            SortedSelect sort1 = new SortedSelect();
            sort1.SortedSelection(masVibor);
            Console.WriteLine("Сортировка выбором");
            for (int i = 0; i < 5; i++) Console.Write(masVibor[i] + " ");
            Console.WriteLine(" ");

            int[] arr = { 845, 235, 6452, 534, 534 };
            int n = arr.Length;
            HeapSort piramid = new HeapSort();
            piramid.sort(arr);
            Console.WriteLine("Пирамидальная сортировка:");
            for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");
            Console.WriteLine(" ");

            int[] masSortedTest = { 4457, 4523, 732, 734, 664 };
            SortedTest sortTest1 = new SortedTest();
            sortTest1.SortedTest1(masSortedTest);
            Console.WriteLine("Сортировка ...");
            for (int i = 0; i < n; i++) Console.Write(masSortedTest[i] + " ");
            Console.WriteLine(" ");

        }

        public class SortedTest
        {
            public void SortedTest1(int[] masSortedTest)
            {

            }
        }

        public class SortedBubble
        {
            public void SortedBuble(int[] masBubble)
            {
                int z;
                for (int i = 0; i < 4; i++)
                {

                    for (int j = i + 1; j < 5; j++)
                    {
                        if (masBubble[i] > masBubble[j])
                        {
                            z = masBubble[i];
                            masBubble[i] = masBubble[j];
                            masBubble[j] = z;
                        }
                    }
                }

                
            }
        }
        public class SortedInser
        {
            public void SortedInsert(int[] masInsert) 
            {

                for (int i = 1; i < 5; i++)
                {
                    int current = masInsert[i];
                    int j = i - 1;
                    while (j >= 0 && current < masInsert[j])
                    {
                        masInsert[j + 1] = masInsert[j];
                        j--;
                    }
                    masInsert[j + 1] = current;
                }

                
            }
        }
        public class SortedSelect
        {
            public void SortedSelection( int[] arr)
            {
                
                for (int i = 0; i < 5; i++)
                {
                    int min = arr[i];
                    int minI = i;
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (arr[j] < min)
                        {
                            min = arr[j];
                            minI = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = min;
                    arr[minI] = temp;
                }
               
            }
        }
        public class HeapSort
        {
            public void sort(int[] arr)
            {
                int n = arr.Length;

                for (int i = n / 2 - 1; i >= 0; i--)
                    heapify(arr, n, i);

                for (int i = n - 1; i >= 0; i--)
                {
                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;

                    heapify(arr, i, 0);
                }
            }

            

            void heapify(int[] arr, int n, int i)
            {
                int largest = i; 
                int l = 2 * i + 1; 
                int r = 2 * i + 2; 

                if (l < n && arr[l] > arr[largest])
                    largest = l;
           
                if (r < n && arr[r] > arr[largest])
                    largest = r;

                if (largest != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;
  
                    heapify(arr, n, largest);
                }
            }

            
            
        }
    }
}


