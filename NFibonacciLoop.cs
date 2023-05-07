class NFibonacciLoop
{
    static void Run()
    {
        int t = 1, f = 0, n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) f = t + (t = f);
        Console.WriteLine(f);
    }
}