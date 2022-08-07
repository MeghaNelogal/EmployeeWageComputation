using EmployeeWageComputation;

namespace EmployeewageComputation
{
   class Program
   {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Employee Wage Computation");

            CalculateMonthlyWage samsung = new CalculateMonthlyWage("Samsung", 20, 5, 10);
            CalculateMonthlyWage reliance = new CalculateMonthlyWage("Reliance", 10, 4, 15);
            CalculateMonthlyWage airtel = new CalculateMonthlyWage("Airtel", 30, 5, 20);
            samsung.ComputeEmployeeWage();
            Console.WriteLine(samsung.displaySalary() + "\n");
            reliance.ComputeEmployeeWage();
            Console.WriteLine(reliance.displaySalary() + "\n");
            airtel.ComputeEmployeeWage();
            Console.WriteLine(airtel.displaySalary() + "\n");
        }
   }
}