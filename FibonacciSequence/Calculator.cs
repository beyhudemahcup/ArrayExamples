namespace FibonacciSequence
{
    public static class Calculator
    {
       public static void FibonacciCalculator(int inputNumber)
        {
            //fibonacci sequence
            int[] fibsq = new int[inputNumber];

            fibsq[0] = 1;
            fibsq[1] = 1;

            Console.WriteLine("Its preparing...");

            //adding some fun
            Thread.Sleep(1000);

            for (int i = 2; i < fibsq.Length; i++)
            {
                fibsq[i] = fibsq[i - 1] + fibsq[i - 2];
            }

            foreach (int i in fibsq)
            {
                Console.WriteLine(i);
            }
        }
    }
}
