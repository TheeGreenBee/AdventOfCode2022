namespace AdventOfCode2022.Solutions
{
    public class Day1 : DayN
    {
        private string[] day1Inputs;

        public override int dayNumber { get { return 1; } }

        public Day1()
        {
            day1Inputs = loadInput("Day1Input");
        }

        public override int solvePart1()
        {
            int maxTotalCalories = 0;

            int currentTotalCalories = 0;

            foreach (string snack in day1Inputs)
            {
                if (string.IsNullOrWhiteSpace(snack))
                {
                    maxTotalCalories = Math.Max(maxTotalCalories, currentTotalCalories);
                    currentTotalCalories = 0;
                }
                else
                {
                    currentTotalCalories += int.Parse(snack);
                }
            }

            return maxTotalCalories;
        }

        public override int solvePart2()
        {
            List<int> allTotalCalories = new List<int>();

            int currentTotalCalories = 0;

            foreach (string snack in day1Inputs)
            {
                if (string.IsNullOrWhiteSpace(snack))
                {
                    allTotalCalories.Add(currentTotalCalories);
                    currentTotalCalories = 0;
                }
                else
                {
                    currentTotalCalories += int.Parse(snack);
                }
            }

            return allTotalCalories.OrderByDescending(p => p).Take(3).Sum();
        }
    }
}
