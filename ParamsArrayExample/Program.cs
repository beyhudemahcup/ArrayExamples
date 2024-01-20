namespace ObjectArrayExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //number comparison with how many number you enter
            Console.WriteLine("Please enter how many number you want to compare!");

            int arrayLenght = Convert.ToInt32(Console.ReadLine());

            int[] value = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                if (arrayLenght - i == 1)
                {
                    Console.WriteLine($"Please enter the numbers to determine which one is smaller. It needs {arrayLenght - i} more number");
                    value[i] = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Please enter the numbers to determine which one is smaller. It needs {arrayLenght - i} more numbers");
                    value[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Your smallest number is {min(value)}");
        }

        static int min(params int[] param)
        {
            int minValue = param[0];

            foreach (int value in param)
            {
                if (value < minValue)
                    minValue = value;
            }

            return minValue;
        }
    }
}