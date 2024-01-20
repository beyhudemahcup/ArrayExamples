namespace RectangularArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 84 },
                           { 4, 12, 55, 19 }, 
                           { 6, 34, 87, 98 }, 
                           { 76, 23, 145, 45 } };//all subarrays should be have 4 elements in it.

            Console.WriteLine(SumMultiDimentionalArrayWithOrder(arr));//expect to see 145
            Console.WriteLine(SumAllMultiDimentionalArray(arr));//expect to see 694

            Console.WriteLine(SumMultiDimentionalArrayWithBackOrder(arr));//expect to see 249

        }

        static int SumMultiDimentionalArrayWithOrder(int[,] arr)
        {
            int sum = 0;

            //I want to print [0,0][1,1][2,2][3,3]
            //both numbers will be equal, so I do not need to create nested loop for that


            //for (int line = 0; line < arr.GetLength(0); line++)//line
            //{
            //    for (int column = 0; column < arr.GetLength(1); column++)//column
            //    {
            //        if (line == column)
            //        {
            //            sum = sum + arr[line, column];
            //        }
            //    }
            //}

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }

            return sum;
        }
        static int SumAllMultiDimentionalArray(int[,] arr)
        {
           
            int sum = 0;

            //for (int i = arr.GetLength(0); i > 0; i--)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        sum += arr[j, i - 1];
            //    }
            //}

            //we can create one foreach loop to calculate sum of all
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static int SumMultiDimentionalArrayWithBackOrder(int[,] arr)
        {
            int sum = 0;

            //lets sum those array values
            //[0,3]
            //[1,2]
            //[2,1]
            //[3,0]

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, (arr.GetLength(0) - 1 - i)];//the left side of the array increases when the right side of the array decreases
            }
            return sum;
        }
    }
}