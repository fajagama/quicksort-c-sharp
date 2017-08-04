using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortYT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 8, 4, 7, 3, 6, 2, 9 };

            PrintArray(array);
            MyQuickSort(array,0, array.Length);
            PrintArray(array);



            Console.WriteLine();
        }

        static void PrintArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static void MyQuickSort(int [] array, int indexStart, int indexEnd)
        {
            if (indexEnd > indexStart)
            {

                int border = indexStart;
                int tmp;

                for (int i = indexStart + 1; i < indexEnd; i++)
                {
                    if (array[indexStart] > array[i])
                    {

                        border++;

                        tmp = array[i];
                        array[i] = array[border];
                        array[border] = tmp;
                    }
                }

                tmp = array[indexStart];
                array[indexStart] = array[border];
                array[border] = tmp;

                MyQuickSort(array, indexStart, border);
                MyQuickSort(array, border + 1, indexEnd);
            }
        }
    }
}
