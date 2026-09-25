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
            Console.Write("Hoeveel getallen wil je ingeven?: ");
            isValidNum = int.TryParse(Console.ReadLine(), out maxNums);
        }
        while(!isValidNum || maxNums < 0);

        int[] numbers = new int[maxNums];

        Console.WriteLine("Geef hier de verschillende getallen in");

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Getal " + (i+1) + ": ");
            isValidNum = int.TryParse(Console.ReadLine(), out numbers[i]);
            while(!isValidNum || numbers[i] < 0)
            {
                Console.Write("Foute invoer! Probeer opnieuw!: ");
                isValidNum = int.TryParse(Console.ReadLine(), out numbers[i]);
            }
        }
        Array.Sort(numbers);

        Console.WriteLine("Het minimum van deze getallen is {0} en het maximum {1}.", numbers[0], numbers[numbers.Length - 1]);

        foreach(int currentNum in numbers)
        {
            sum = sum + currentNum;
            average = sum/numbers.Length;
        }
        Console.WriteLine("Het gemiddelde is: {0}", average);

        Console.WriteLine("Druk op een toets om af te sluiten...");
        Console.ReadKey();
    }
}
