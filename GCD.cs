class GCD
{
    static void Run()
    {
        long a = long.Parse(Console.ReadLine()), b = long.Parse(Console.ReadLine());
        Console.WriteLine(FindGCD(a, b));
    }
    static long FindGCD(long a, long b)
    {
        if (a == 0) return b;
        if (b == 0) return a;
        return (a > b) ? FindGCD(a % b, b) : FindGCD(a, b % a);
    }
}