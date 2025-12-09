using System.Text.RegularExpressions;

class Day2
{
    static void Main(string[] args)
    {
        var lines = File.ReadLines((args[0].Contains("-d")) ? "itest.txt" : "input.txt");
        string[] rangeStrings = Regex.Split(lines.First(), ",");
        long answer = 0;

        foreach (string rangeString in rangeStrings)
        {
            string[] values = Regex.Split(rangeString, "-");
            for (long i = Convert.ToInt64(values[0]); i <= Convert.ToInt64(values[1]); i++)
            {
                answer += validateIdN(i);
            }
        }
        Console.WriteLine(answer);
    }

    static long validateID(long ID)
    {

        string IDString = Convert.ToString(ID);
        long idAdd = 0;
        for (int i = 0; i < IDString.Length; i++)
        {
            for (int d = i; d <= IDString.Length; d++)
            {
                int length = d - i;
                string pat = IDString.Substring(i, length);
                int occurances = Regex.Matches(IDString, pat).Count;
                bool repeats = (occurances * length == IDString.Length) && occurances != 1 && occurances == 2;
                if (repeats)
                {
                    Console.WriteLine("ID:" + ID + " Pat:" + pat + " Occurances:" + occurances);
                    return ID;
                }
            }
        }
        return idAdd;
    }

    static long validateIdN(long Id)
    {

        string IDString = Convert.ToString(Id);
        long idAdd = 0;
        for (int i = 0; i < IDString.Length; i++)
        {
            for (int d = i; d <= IDString.Length; d++)
            {
                int length = d - i;
                string pat = IDString.Substring(i, length);
                int occurances = Regex.Matches(IDString, pat).Count;
                bool repeats = (occurances * length == IDString.Length) && occurances != 1;

                if (repeats)
                {
                    Console.WriteLine("ID:" + Id + " Pat:" + pat + " Occurances:" + occurances);
                    return Id;
                }
            }
        }
        return idAdd;
    }
}
