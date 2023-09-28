using System;

namespace CyclicRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 3, 8, 9, 7, 6 };
            var k = 3;
            foreach (var item in Solution(array, k))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static int[] Solution(int[] array, int number)
        {
            int[] result = array;
            for (int i = 0; i < number; i++)
            {
                result = Swap(result);
            }
            return result;
        }
        public static int[] Swap(int[] array)
        {
            int[] newArray = new int[array.Length];
            if (array.Length == 0)
            {
                return newArray;
            }
            else
            {
                newArray[0] = array[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    newArray[i + 1] = array[i];
                }
                return newArray;
            }
        }
    }
}
