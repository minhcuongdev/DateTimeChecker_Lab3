using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DateTimeChecker
{
    public class DTChecker
    {
        public DTChecker() { }

        public int CheckRangeInput(int day,int month,int year)
        {
            if ( day < 1 || day > 31)
            {
                return 1;
            }

            if ( month < 1 || month > 12)
            {
                return 2;
            }

            if ( year < 1000 || year > 3000)
            {
                return 3;
            }

            return 0;
        }

        public int CheckFormatInput(string day,string month,string year)
        {
            if(!IsNumber(day))
            {
                return 1;
            }

            if(!IsNumber(month))
            {
                return 2;
            }

            if(!IsNumber(year))
            {
                return 3;
            }

            return 0;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }

        public bool IsValidDay(int day, int month, int year)
        {

            if (month >= 1 && month <= 12)
            {
                if (day >= 1)
                {
                    if (day <= DaysInMonth(month, year))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int DaysInMonth(int month, int year)
        {
            int result = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    result = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    result = 30;
                    break;
                case 2:
                    if (year % 400 == 0)
                    {
                        result = 29;
                    }
                    else if (year % 100 == 0)
                    {
                        return 28;
                    }
                    else if (year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                    break;
                default:
                    break;

            }
            return result;
        }
    }
}
