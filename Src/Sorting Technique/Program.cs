// See https://aka.ms/new-console-template for more information
using Sorting_Technique;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        arr = Bubble.Sort(arr, 0);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.ReadLine();
    }
}
