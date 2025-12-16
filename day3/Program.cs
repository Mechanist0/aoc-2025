class Day2
{
    static void Main(string[] args)
    {
        string fileName = "input.txt";
        if (args.Length > 0 && args[0].Contains("-d")) fileName = "test.txt";
        string[] banks = ParseInput(fileName);
        long cumultiveJoltage = 0;

        foreach (string bank in banks)
        {
            Console.WriteLine("Checking Bank: " + bank);
            cumultiveJoltage += PartTwo(bank);
        }

        Console.WriteLine("Total Joltage:" + cumultiveJoltage);
    }

    static string[] ParseInput(string fileName)
    {
        return File.ReadLines(fileName).ToArray();
    }

    static int PartOne(string bank)
    {
        int greatJoltage = 0,
            greatIndex = 0,
            secGreatJoltage = 0,
            secGreatIndex = 0;

        // Check all Joltages minus one incase the largest value is the last index
        for (int i = 0; i < bank.Length - 1; i++)
        {
            int joltage = bank[i] - '0'; // Fuckery

            if (joltage > greatJoltage)
            {
                greatIndex = i;
                greatJoltage = joltage;
            }
        }

        // Check all Joltages minus one incase the largest value is the last index
        for (int i = greatIndex + 1; i < bank.Length; i++)
        {
            int joltage = bank[i] - '0'; // Fuckery

            if (joltage > secGreatJoltage)
            {
                secGreatJoltage = joltage;
            }
        }

        Console.WriteLine("Greatest Joltage of: " + greatJoltage + " at index: " + greatIndex);
        Console.WriteLine("Sec Greatest Joltage of: " + secGreatJoltage + " at index: " + secGreatIndex);

        return Convert.ToInt32(greatJoltage.ToString() + secGreatJoltage.ToString());

    }

    static long PartTwo(string bank)
    {
        Dictionary<int, int> joltageDict = new();
        int lastIndex = -1;
        int[] result = new int[100];

        for (int i = 0; i < 12; i++)
        {
            result = GreatestInRange(bank, lastIndex, bank.Length - (12 - i));
            joltageDict.Add(result[0], result[1]);
            lastIndex = result[0];
        }

        string joltageStr = "";
        foreach (int num in joltageDict.Values)
        {
            joltageStr += num.ToString();
        }
        Console.WriteLine(joltageStr);

        return Convert.ToInt64(joltageStr);
    }

    // Find the greatest value between low and high
    static int[] GreatestInRange(string bank, int low, int high)
    {
        int maxIndex = low;
        int maxJoltage = 0;
        for (int i = low + 1; i <= high; i++)
        {
            Console.Write(bank[i] + ",");
            int joltage = bank[i] - '0'; // Fuckery

            if (joltage > maxJoltage)
            {
                maxJoltage = joltage;
                maxIndex = i;
            }
        }
        return [maxIndex, maxJoltage];
    }
}
