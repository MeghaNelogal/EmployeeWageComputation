using EmployeeWageComputation;

namespace EmployeewageComputation
{
   class Program
   {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Employee Wage Computation");
         
            CalculateMonthlyWage employee = new CalculateMonthlyWage();          
            employee.Company("Samsung", 20, 4, 20);
            employee.Company("Reliance", 10, 4, 15);
            employee.Company("Airtel", 30, 5, 20);
        }
   }
}