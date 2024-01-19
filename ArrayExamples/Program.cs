
namespace ArrayExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ShowArrays.ShowEmptyArray();
            //ShowArrays.ShowFilledArray();

            //RollDice.RollDicer(1000);//how much dice do you want to dice :)

            //now grading 
            GetGrades();
        }

        static void GetGrades()
        {
            int[] arr = GradeGenerator.GradeCalculator(10);//10 students grade will be shown
            //can get asterisks for every int value
            GradeGenerator.GradeDefiner(arr);
        }
    }
}