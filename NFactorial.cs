class NFactorial
{
    static void Run() => Console.WriteLine(Fact(long.Parse(Console.ReadLine())));
    static long Fact(long n) => n <= 1 ? 1 : n * Fact(n - 1);
}