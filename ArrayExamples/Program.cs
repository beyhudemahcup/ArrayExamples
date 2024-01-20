
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
            //GradeGenerator.GetGrades();

            //gets the variable param double[] arr. which means it will work no matter how many number it gets
            ParamsAverage.Average(true, 1,23,4,5,123,4123,3);
            ParamsAverage.Average(true, 1,30,43);
            ParamsAverage.Average(false, 1,2,4,5);//we cant see the output since we send false as a boolean value
            ParamsAverage.Average(true);
        }
    }
}