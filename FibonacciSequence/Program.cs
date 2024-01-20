namespace FibonacciSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many elements do you want to learn from Fibonacci Sequence?");
            Console.WriteLine("The highest value you can enter is : 46");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            while (inputNumber > 46)
            {
                Console.WriteLine("Please enter a valid value!");
                inputNumber = Convert.ToInt32(Console.ReadLine());
            }

            Calculator.FibonacciCalculator(inputNumber);
        }
    }
}