using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3NUnit
{
    public class Function
    {
        public bool CheckDate(int day, int month, int year)
        {
            if (month < 1 || month > 12)
            {
                return false;
            }

            if (day < 1)
            {
                return false;
            }

            int maxDaysInMonth = DateTime.DaysInMonth(year, month);

            if (day > maxDaysInMonth)
            {
                return false; 
            }

            return true;
        }

        public int DayInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                return 0;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            return 29;
                        } else
                        {
                            return 28;
                        }
                    } else
                    {
                        return 29;
                    }
                } else
                {
                    return 28;
                }
            }
            return 0;
        }
    }
}
