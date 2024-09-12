namespace AdventOfCode;
internal class Program
{
    static void Main()
    {
        Console.WriteLine(Day6.Solution("D6Test.txt", true));
        Console.WriteLine(Day6.Solution("D6Input.txt", true));
        Console.WriteLine(Day6.Solution("D6Test.txt", false));
        Console.WriteLine(Day6.Solution("D6Input.txt", false));
    }
}