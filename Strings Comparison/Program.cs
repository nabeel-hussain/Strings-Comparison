class Program
{
    public static int CountDifferentCharacters(string str1, string str2)
    {
        // Remove duplicate characters from both strings
        string uniqueStr1 = new string(str1.Distinct().ToArray());
        string uniqueStr2 = new string(str2.Distinct().ToArray());

        // Calculate the number of different characters
        int diffCount = 0;

        foreach (char c in uniqueStr1)
        {
            if (!uniqueStr2.Contains(c))
            {
                diffCount++;
            }
        }

        foreach (char c in uniqueStr2)
        {
            if (!uniqueStr1.Contains(c))
            {
                diffCount++;
            }
        }

        return diffCount;
    }

    static void Main(string[] args)
    {
        string str1 = "abc$%^12";
        string str2 = "!@#$abc";

        int result = CountDifferentCharacters(str1, str2);
        Console.WriteLine("Number of different characters: " + result); // Output: 4
    }
}
