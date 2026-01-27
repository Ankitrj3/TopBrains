public class Program
{
    public static void SumOfPositiveInteger(int [] arr){
        int sum = 0;
        foreach(int i in arr)
        {
            if(i == 0)
            {
                Console.WriteLine("Zero Found in array So Lets Break the array");
                break;
            }
            if(i < 0)
            {
                Console.WriteLine("Negative Number Found So Lets Skip");
                continue;
            }
            else
            {
                sum += i;
            }
        }
        Console.WriteLine($"Sum of Positive Integers {sum}");
    }
    public static void Main()
    {
        int [] arr = {12,34,5,56,-2,1,-4,0,23,1,-1};
        SumOfPositiveInteger(arr);
    }
}