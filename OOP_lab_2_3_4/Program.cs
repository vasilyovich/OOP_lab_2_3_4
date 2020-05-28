using System;
using System.Diagnostics.SymbolStore;

namespace OOP_lab_2_3_4
{
    public class Program
    {
        public static int CountLess7(int[] array)
        {
            int count = 0; ;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 7)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int Sum(int[] array)
        {
            int firstPositiveIndex = 0;
            int lastPositiveIndex = 0;

            int sum = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    firstPositiveIndex = i;
                    break;
                }
            }

            for (int i = array.Length - 1; i >= firstPositiveIndex; --i)
            {
                if (array[i] > 0)
                {
                    lastPositiveIndex = i;
                    break;
                }
            }

            for (int i = firstPositiveIndex + 1; i < lastPositiveIndex; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Kiлькiсть елементiв масиву, менших за число сiм: {0}", CountLess7(a));
            Console.WriteLine("Cумa елементiв масиву, розташованих мiж першим й останнiм додатними елементами: {0}", Sum(a));
        }
    }
}
