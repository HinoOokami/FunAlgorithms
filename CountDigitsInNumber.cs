namespace FunAlgorithms;

public class CountDigitsInNumber
{
    static void Run()
    {
        var nums = new int[10];
        var input = Console.ReadLine();
        foreach (var c in input) if (c != '-') nums[c - '0']++;
        for (var i = 0; i < 10; i++) Console.WriteLine(i + " - " + nums[i]);
    }
}