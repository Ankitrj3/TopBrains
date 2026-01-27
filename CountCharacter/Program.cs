public class Program
{
    public static int countChar(string str)
    {
        int count = 0;
        str = str.ToLower();
        foreach(char ch in str)
        {
            if(ch == ' ')
            {
                count--;
            }
            count++;
        }
        return count;
    }
    public static void Main()
    {
        string? val = "ankit ranjan";
        Console.WriteLine("Count char of string "+countChar(val));
    }
}