using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest7
{
    class Program
    {
        public static void printInReverseOrder(int[] arrayOfIntegers)
        {
            for (int i = arrayOfIntegers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfIntegers[i]);
                Console.Write(" ");

            }
        }

        static void Main(string[] args)
        {
 
            Console.WriteLine("Please, enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter the values separarted by space into the array ");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            printInReverseOrder(arr);
           
            Console.ReadKey();
        }
    }
}
