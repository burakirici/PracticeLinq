public class Program
{
    public static void Main(string[] args)
    {
        List<int> randomNumbers = new List<int>() { -10,20,44,-35,77,65,83,92,76,26};

        var evenNumbers = randomNumbers.Where(num => num % 2 == 0);
        Console.WriteLine("Even numbers: ");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------------------------------");
        var oddNumbers = randomNumbers.Where(num => num % 2 != 0);
        Console.WriteLine("Odd numbers: ");
        foreach (int num in oddNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------------------------------");
        var negativeNumbers = randomNumbers.Where(num => num < 0);
        Console.WriteLine("Negative numbers : ");
        foreach (int num in negativeNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------------------------------");
        var positiveNumbers = randomNumbers.Where(num => num > 0);
        Console.WriteLine("Positive numbers : ");
        foreach (int num in positiveNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------------------------------");
        var Numbers = randomNumbers.Where(num => num > 15 && num < 22);
        Console.WriteLine("Numbers greater than 15 and less than 22 : ");
        foreach (int num in Numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------------------------------------");

        List<int> numbers = new List<int>() { -10, 20, 44, -35, 77, 65, 83, 92, 76, 26 };

        var squaredNumbers = numbers.Select(num => num * num);
        Console.WriteLine("Squared numbers: ");
        foreach(var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
    }
}