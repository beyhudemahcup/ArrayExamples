namespace ObjectArrayExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] companyDream = new Employee[5];

            companyDream[0] = new Employee("Terry", 5000);
            companyDream[1] = new Employee("Adam", 7200);
            companyDream[2] = new Employee("Eve", 7000);
            companyDream[3] = new Employee("Metin", 11000);
            companyDream[4] = new Employee("Meredith", 13000);

            Employee.GetAllEmployeesDetails(companyDream);
            Employee.RaiseSalary(companyDream, 0.2);//%20 salary increasing
          
            Console.WriteLine("After the salary increase:");
            
            Employee.GetAllEmployeesDetails(companyDream);
        }
    }
}