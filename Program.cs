using EmployeeWageComputation;

namespace EmployeewageComputation
{
   class Program
   {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Employee Wage Computation");

            EmployeeCheck employee = new EmployeeCheck();
            employee.CheckEmployeeAttendance();
        }
   }
}