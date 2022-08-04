using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        /// <summary>
        /// Checks the employee attendance.
        /// </summary>
        public void CheckEmployeeAttendance()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("IS_FULL_TIME is :");
                    empHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("IS_PART_TIME is :");
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage -> " + empWage);
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage -> " + empWage);
        }
    }
}

