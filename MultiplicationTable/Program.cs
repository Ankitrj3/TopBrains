class MultiplicationTable
{
    public List<int> Ntable(int n, int upto)
    {
        int res = 0;
        List<int> table = new List<int>();
        for(int i = 1; i <= upto; i++)
        {
            res = n*i;
            table.Add(res);
        }
        return table;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Number you want to Print the Table");
        string? N = Console.ReadLine();
        int n = int.Parse(N);
        Console.WriteLine("Enter the range upto you want to print");
        string? Upto = Console.ReadLine();
        int upto = int.Parse(Upto);

        MultiplicationTable mt = new MultiplicationTable();
        List<int> table = mt.Ntable(n,upto);
        foreach(var i in table)
        {
            Console.Write(i+" ");
        }Console.WriteLine();
    }
}