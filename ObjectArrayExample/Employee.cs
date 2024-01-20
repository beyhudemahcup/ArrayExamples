namespace ObjectArrayExample
{
    public class Employee
    {
        public string _name { get; set; }
        public double _salary { get; set; }

        public void RaiseSalary(double rate)
        {
            _salary *= 1 + rate;
        }
        
        public Employee(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }


        public string GetDetails()
        {
            string details = $"Employee name: {_name}, Employee salary: {_salary}";
            return details;
        }

        public static void GetAllEmployeesDetails(Employee[] employees )
        {
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.GetDetails());
            }
        }

        public static void RaiseSalary(Employee[] emp, double rate)
        {
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].RaiseSalary(rate);
            }
        }
    }
}
