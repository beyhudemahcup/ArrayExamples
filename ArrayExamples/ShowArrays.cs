namespace ArrayExamples
{
    public class ShowArrays
    {
        public static void ShowEmptyArray()
        {
            int[] arr = new int[5];

            Console.WriteLine($"{"Index"}{"Value",8}");//Value will be right -aligned 8 characters

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i,5}{arr[i],8}");//arr is empty
            }
        }
        public static void ShowFilledArray()
        {
            int[] arr = [3, 53, 12, 87, 69];

            Console.WriteLine($"{"Index"}{"Value",8}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i,5}{arr[i],8}");//arr is filled
            }
        }
    }
}
