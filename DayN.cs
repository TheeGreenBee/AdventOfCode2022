namespace AdventOfCode2022
{
    public abstract class DayN
    {
        public abstract int dayNumber { get; }

        public string[] loadInput(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Inputs", $"{fileName}.txt");
            return File.ReadAllLines(path);
        }

        public abstract int solvePart1();

        public abstract int solvePart2();

        public void printSolutions()
        {
            Console.WriteLine($"Solutions for day {this.dayNumber}:");
            Console.WriteLine(this.solvePart1());
            Console.WriteLine(this.solvePart2());
            Console.WriteLine("__________________________________");
        }
    }
}
