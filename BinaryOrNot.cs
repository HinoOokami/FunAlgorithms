class BinaryOrNot
{
    static void Run() => Console.WriteLine(Console.ReadLine().Any(c => !new[] { '0', '1' }.Contains(c)) ? "Not Binary" : "Binary");
}