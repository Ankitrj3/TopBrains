public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (IsPrime(x))
            {
                int s1 = DigitSum(x);
                int s2 = DigitSum(x * x);

                if (s2 == s1 * s1)
                    count++;
            }
        }

        Console.WriteLine(count);
    }
    public static bool IsPrime(int num)
    {
        if(num < 2)
        {
            return false;
        }
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static int DigitSum(int num)
    {
        int sum = 0;
        while(num < 0)
        {
            int digit = num % 10;
            sum += digit;
            num = num/10;
        }
        return sum;
    }
}