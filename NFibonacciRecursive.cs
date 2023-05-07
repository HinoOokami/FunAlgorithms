class NFibonacciRecursive
{
    static void Run() => Console.WriteLine(Fibb(long.Parse(Console.ReadLine())));

    static long Fibb(long n) => n <= 2 ? 1 : Fibb(n - 1) + Fibb(n - 2);
}