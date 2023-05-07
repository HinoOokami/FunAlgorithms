// Translates numerical input to text.
class NumToText
{
    enum nums
    {
        zero, one, two, three, four, five, six, seven, eight, nine,
        ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen,
        twenty, thirty = 30, forty = 40, fifty = 50, sixty = 60, seventy = 70, eighty = 80, ninety = 90, hundred = 100
    }
    static void Run()
    {
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine(Enum.IsDefined(typeof(nums), num) ? ((nums)num).ToString() : (nums)(num - num % 10) + " " + (nums)(num % 10));
    }
}