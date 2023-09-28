// See https://aka.ms/new-console-template for more information
using SearchTechnique;
using SearchTechnique.Techniques;

public class Program
{

    public static void Main(string[] args)
    {
        int[] array = { 1, 4, 6, 78, 89, 104 };

        int findNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Binary search");
        Console.WriteLine(BinarySearch.FindNumber(array, findNumber));
        Console.WriteLine("Interpolation Search");
        Console.WriteLine(InterpolationSearch.FindNumber(array, 0, array.Length - 1, findNumber));

        Console.ReadLine();
    }

}


