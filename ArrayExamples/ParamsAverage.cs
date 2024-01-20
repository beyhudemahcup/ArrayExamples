namespace ArrayExamples
{
    public static class ParamsAverage
    {
        public static double Average(bool willBePrint, params double[] arr)
        {
            var sum = 0.0;

            foreach ( var i in arr )
            {
                sum += i;
            }

            if ( sum == 0.0)
            {
                PrintAverage(0.0);
                return 0.0;
            }

            double average = sum / arr.Length;
            
            if (willBePrint)
            {
                PrintAverage(average);
            }
            
            return average;
        }

        private static void PrintAverage(double average)
        {
            Console.WriteLine("Average of array from ParamsAverage class is: " + average.ToString("0.00"));
        }
    }
}
