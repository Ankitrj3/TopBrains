public class Program
{
    public static string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
            return "Short";
        else if (heightCm < 180)
            return "Average";
        else
            return "Tall";
    }
    public static void Main()
    {
        Console.WriteLine(GetHeightCategory(140)); 
        Console.WriteLine(GetHeightCategory(150)); 
        Console.WriteLine(GetHeightCategory(179)); 
        Console.WriteLine(GetHeightCategory(180)); 
        Console.WriteLine(GetHeightCategory(250)); 
    }
}