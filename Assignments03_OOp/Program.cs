using Microsoft.VisualBasic;

namespace Assignments03_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 2.Develop a Class to represent the Hiring Date Data:
            HiringDate dbaHiringDate = new HiringDate(12, 10, 2019);
            HiringDate guestHiringDate = new HiringDate(30, 12, 2021);
            HiringDate securityOfficerHiringDate = new HiringDate(1, 12, 2020);
            #endregion

            #region 1.Design and implement a Class for the employees in a company
            //employees e1 = new employees(100, "Mohamed", employees.SecurityLevel.Developer, 30000, hiringDate1, 'F');
            //Console.WriteLine(e1.ToString());
            #endregion

            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            employees[] EmpArr = new employees[3];

            EmpArr[0] = new employees(101, "Abdelrahman", employees.SecurityLevel.DBA, 80000, dbaHiringDate, 'M');
            EmpArr[1] = new employees(102, "Ali", employees.SecurityLevel.Guest, 30000, guestHiringDate, 'M');
            EmpArr[2] = new employees(103, "Sara", employees.SecurityLevel.SecurityOfficer, 100000, securityOfficerHiringDate, 'F');

            foreach (var emps in EmpArr)
            {
                Console.WriteLine(emps.ToString());
            } 
            #endregion

        }
    }
}
