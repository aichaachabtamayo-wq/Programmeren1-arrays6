namespace Oefening_6___avg.min.max;

class Program
{
    static void Main(string[] args)
    {
        int maxNums;
        bool isValidNum;
        int sum = 0;
        double average = 0;
        
        do
        {
            Console.Write("How many numbers do you want to input?: ");
            isValidNum = int.TryParse(Console.ReadLine(), out maxNums);
        }
        while(!isValidNum || maxNums < 0);

        int[] numbers = new int[maxNums];

        Console.WriteLine("Type the different numbers here: ");

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number " + (i+1) + ": ");
            isValidNum = int.TryParse(Console.ReadLine(), out numbers[i]);
            while(!isValidNum || numbers[i] < 0)
            {
                Console.Write("Wrong input! TRY AGAIN: ");
                isValidNum = int.TryParse(Console.ReadLine(), out numbers[i]);
            }
        }
        Array.Sort(numbers);

        Console.WriteLine("The minimum of these numbers is {0} and the maximum {1}.", numbers[0], numbers[numbers.Length - 1]);

        foreach(int currentNum in numbers)
        {
            sum = sum + currentNum;
            average = sum/numbers.Length;
        }
        Console.WriteLine("The average is: {0}", average);

        Console.WriteLine("Press on any key to close...");
        Console.ReadKey();
    }
}
