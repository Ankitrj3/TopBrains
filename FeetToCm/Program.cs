public class Program
{
    public static double FeetToCm(int Feet)
    {
        double foot = 30.48;
        double res = Feet * foot;
        return res;
    }
    public static void Main()
    {
        int Feet = 4;
        double result = FeetToCm(Feet);
        Console.WriteLine($"Conversion of {Feet} into {result:F2} cm");
    }
}