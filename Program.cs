using EmployeeWageComputation;

namespace EmployeewageComputation
{
   class Program
   {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Employee Wage Computation");

            CalculateMonthlyWage company = new CalculateMonthlyWage();
            company.AddCompanyEmpWage("SAMSUNG", 400, 200, 20);
            company.AddCompanyEmpWage("RELIANCE", 500, 100, 15);
            company.AddCompanyEmpWage("AIRTEL", 600, 150, 18);
            company.ComputeEmpWage();
            Console.WriteLine(company.ToString());
        }
   }
}