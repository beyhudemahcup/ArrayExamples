namespace ArrayExamples
{
    public class RollDice
    {
        public static void RollDicer(int diceTurn)
        {
            Random random = new Random();
            int[] diceHolder = new int[7];

            for (int i = 1; i <= diceTurn; ++i)
            {
                ++diceHolder[random.Next(1, 7)];
            }

            for (int j = 1; j < diceHolder.Length; ++j)
            {
                Console.WriteLine($"Dice number {j} : {diceHolder[j]}");
            }
        }
    }
}
