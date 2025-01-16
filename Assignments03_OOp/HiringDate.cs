using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments03_OOp
{
    #region 2.Develop a Class to represent the Hiring Date Data:
    public class HiringDate
    {
        private static readonly int[] DaysInMnoth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysInMnoth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int _day, int _month, int _year)
        {
            var IsLeap = year % 4 == 0 && (year % 100 !=0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >=1 && month<=12)
            {
                int[] days = IsLeap ? DaysInMnoth366 : DaysInMnoth366;
                if (day >= 1 && day <= days[month])
                {
                    day=_day;
                    month=_month;
                    year=_year;
                }
                else
                {
                    day= 01;
                    month= 01;
                    year= 01;
                }
            }
            else
            {
                day= 01;
                month= 01;
                year= 01;
            }
        }
        public string DisplayHiringDate()
        {
            return $"{day:D2}/{month:D2}/{year:D4}";
        }
    } 
    #endregion
}
