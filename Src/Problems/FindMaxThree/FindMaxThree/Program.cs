// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int first, second, three;
        first = second = three = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (first < arr[i] && first != arr[i])
            {
                three = second;
                second = first;
                first = arr[i];
                continue;
            }
            else if (second < arr[i] && first != arr[i] && second != arr[i])
            {
                three = second;
                second = arr[i];
                continue;
            }
            else if (three < arr[i])
            {
                three = arr[i];
            }
        }
        Console.WriteLine(first + " " + second + " " + three);
        Console.WriteLine("Sum of first largest unique numbers " + (first + second + three));
        Console.ReadLine();
    }
}
