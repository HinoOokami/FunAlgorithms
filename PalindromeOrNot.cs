class PalindromeOrNot
{
    static void Run()
    {
        var str = Console.ReadLine().ToLowerInvariant();
        var isPal = true;
        for (int fw = 0, bw = str.Length - 1; fw < str.Length / 2; fw++, bw--)
            if (str[fw] != str[bw])
            {
                isPal = false;
                break;
            }
        Console.WriteLine(isPal ? "palindrome" : "not a palindrome");
    }
}