public class Parsing
{
    public void ParseValue(string[] Tokens)
    {
        int sum = 0;
        foreach(var token in Tokens)
        {
            if(int.TryParse(token, out int val))
            {
                sum += val;
            }
        }
        Console.WriteLine(sum);
    }
}
public class Program
{
    public static void Main()
    {
        string[] arr = {"12","nakir","jr","45","-5","456342327899999"};
        Parsing p = new Parsing();
        p.ParseValue(arr);
    }
}