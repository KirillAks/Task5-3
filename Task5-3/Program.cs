using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        // Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i]>array[j])
                    {
                        int buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }                    
                }
            }
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {                
                Console.Write("{0} ", array[i]);
            }            
            Console.ReadKey();
        }
    }
}
