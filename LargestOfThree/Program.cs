public class Program
{
    public static int LargestOfThree(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;
        else if (b >= a && b >= c)
            return b;
        else
            return c;
    }
    public static void Main()
    {
        Console.WriteLine(LargestOfThree(10, 5, 7));    
        Console.WriteLine(LargestOfThree(-1, -5, -3)); 
        Console.WriteLine(LargestOfThree(4, 4, 2));

    }

}