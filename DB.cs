using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomePlus
{
    public static class DB
    {
        public static Month GetMonthByName(Months name)
        {
            Month result = new Month();
            result.name = name;

            switch (name)
            {
                case Months.JAN:
                    result.monthStartingValue = 12;
                    result.dayOneValue = 23;
                    break;
                case Months.FEB:
                    result.monthStartingValue = 1;
                    result.dayOneValue = 26;
                    break;
                case Months.MAR:
                    result.monthStartingValue = 2;
                    result.dayOneValue = 26;
                    break;
                case Months.APR:
                    result.monthStartingValue = 3;
                    result.dayOneValue = 26;
                    break;
                case Months.MAI:
                    result.monthStartingValue = 4;
                    result.dayOneValue = 26;
                    break;
                case Months.JUN:
                    result.monthStartingValue = 5;
                    result.dayOneValue = 26;
                    break;
                case Months.JUL:
                    result.monthStartingValue = 6;
                    result.dayOneValue = 23;
                    break;
                case Months.AUG:
                    result.monthStartingValue = 7;
                    result.dayOneValue = 23;
                    break;
                case Months.SEP:
                    result.monthStartingValue = 8;
                    result.dayOneValue = 26;
                    break;
                case Months.OCT:
                    result.monthStartingValue = 9;
                    result.dayOneValue = 26;
                    break;
                case Months.NOV:
                    result.monthStartingValue = 10;
                    result.dayOneValue = 23;
                    break;
                case Months.DEC:
                    result.monthStartingValue = 11;
                    result.dayOneValue = 26;
                    break;
                default:
                    result.name = Months.OTH;
                    result.monthStartingValue = -1;
                    result.dayOneValue = -1;
                    break;
            }

            return result;
        }

        public static Month GetMonthByValue(int mValue, int dValue)
        {
            Month result;

            double crit = mValue + ((double)dValue / 100);

            if ((crit >= 12.23 && crit <= 12.31) || (crit >= 1.01 && crit < 1.26))
                result = GetMonthByName(Months.JAN);
            else if (crit >= 1.26 && crit < 2.26)
                result = GetMonthByName(Months.FEB);
            else if (crit >= 2.26 && crit < 3.26)
                result = GetMonthByName(Months.MAR);
            else if (crit >= 3.26 && crit < 4.26)
                    result = GetMonthByName(Months.APR);
            else if (crit >= 4.26 && crit < 5.26)
                result = GetMonthByName(Months.MAI);
            else if (crit >= 5.26 && crit < 6.23)
                    result = GetMonthByName(Months.JUN);
            else if (crit >= 6.23 && crit < 7.23)
                    result = GetMonthByName(Months.JUL);
            else if (crit >= 7.23 && crit < 8.26)
                result = GetMonthByName(Months.AUG);
            else if (crit >= 8.26 && crit < 9.26)
                result = GetMonthByName(Months.SEP);
            else if (crit >= 9.26 && crit < 10.23)
                result = GetMonthByName(Months.OCT);
            else if (crit >= 10.23 && crit < 11.26)
                result = GetMonthByName(Months.NOV);
            else if (crit >= 11.26 && crit < 12.23)
                result = GetMonthByName(Months.DEC);
            else
                result = GetMonthByName(Months.OTH);

            return result;
        }
    }

}
