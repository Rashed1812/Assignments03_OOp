namespace Assignments03_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 2.Develop a Class to represent the Hiring Date Data:
            HiringDate hiringDate1 = new HiringDate(1, 12, 2020); 
            #endregion

            #region 1.Design and implement a Class for the employees in a company
            employees e1 = new employees(100, "Mohamed", employees.SecurityLevel.Developer, 30000, hiringDate1, 'F');
            Console.WriteLine(e1.ToString());
            #endregion

        }
    }
}
