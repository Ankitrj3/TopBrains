// Ref / Out – Swap Without Temp
public class RefAndOutSwap
{
    public void RefSwap(ref int a, ref int b)
    {
        int x = a;
        int y = b;
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"Before {x} and {y} After {a} and {b}");
    }
    public void OutSwap(out int a, out int b)
    {
        a = 45;
        b = 89;
        int x = a;
        int y = b;
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"Before {x} and {y} After {a} and {b}");
    }
}
public class Program
{
    public static void Main()
    {
        RefAndOutSwap refAndOutSwap = new RefAndOutSwap();
        int a = 22;
        int b = 13;
        refAndOutSwap.RefSwap(ref a, ref b);
        int c,y;
        refAndOutSwap.OutSwap(out c, out y);
    }
}