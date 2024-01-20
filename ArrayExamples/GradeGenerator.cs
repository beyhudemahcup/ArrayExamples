namespace ArrayExamples
{
    public static class GradeGenerator
    {
        private static int[] _grades { get; set; }
        private static int lowestGrade;
        private static int greaterGrade;

        public static int[] GradeCalculator(int studentNumber)
        {
            Random random = new Random();
            int sum = 0;

            _grades = new int[studentNumber];

            Console.WriteLine("The grades are :");

            for (int i = 0; i < _grades.Length; i++)
            {
                _grades[i] = random.Next(1, 101);
                sum += _grades[i];

                Console.WriteLine($"Student {i + 1}: {_grades[i]}");
            }

            Console.WriteLine($"Class average is : {GetAverage(sum, studentNumber)}");
            Console.WriteLine($"Class best grade is : {GetGreaterGrade(_grades)}");
            Console.WriteLine($"Class worst grade is : {GetLowestGrade(_grades)}");

            return _grades;
        }

        public static void GetGrades()
        {
            int[] arr = GradeGenerator.GradeCalculator(10);//10 students grade will be shown
            //can get asterisks for every int value
            GradeGenerator.GradeDefiner(arr);
        }

        private static int GetLowestGrade(int[] grades)
        {
            lowestGrade = grades[0];

            //using for each
            foreach (int grade in grades)
            {
                if (lowestGrade > grade)
                {
                    lowestGrade = grade;
                }
            }
            return lowestGrade;
        }

        private static int GetGreaterGrade(int[] grades)
        {
            //using for loop
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > greaterGrade)
                {
                    greaterGrade = grades[i];
                }
            }
            return greaterGrade;
        }

        private static string GetAverage(int sum, int studentNumber)
        {
            double average = sum / studentNumber;

            return average.ToString("0.00");
        }

        public static void GradeDefiner(int[] arr)
        {
            var frequency = new int[arr.Length + 1];

            foreach (var i in arr)
            {
                ++frequency[i/10];//showing one asteriks to one grade
            }

            for (int i = 0; i < frequency.Length; i++)
            {
                if (i == 10)
                {
                    Console.Write($"{i * i}: ");
                }
                else
                {
                    Console.Write($"{i * 10:D2}-{i * 10 + 9:D2}: ");
                }

                //give an asterisk for every grade
                for (int j = 0; j < frequency[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
