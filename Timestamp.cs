using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomePlus
{

    public struct Timestamp
    {
        public string value;

        public int GetYear()
        {
            int year = 0;
            if (this.IsValid())
            {
                year = Convert.ToInt32(value.Substring(0, 4));
            }

            return year;
        }

        public Month GetMonth()
        {
            int mValue = GetMonthValue();
            int dValue = GetDayValue();

            return DB.GetMonthByValue(mValue, dValue);
        }

        private int GetMonthValue()
        {
            int month = 0;
            if (this.IsValid())
            {
                month = Convert.ToInt32(value.Substring(4, 2));
            }

            return month;
        }

        private int GetDayValue()
        {
            int day = 0;
            if (this.IsValid())
            {
                day = Convert.ToInt32(value.Substring(6, 2));
            }

            return day;
        }

        private bool IsValid()
        {
            int number;
            return this.value.Length == 8 && Int32.TryParse(this.value, out number);
        }
    }
    
    public struct Month
    {
        public Months name;
        public int monthStartingValue;
        public int dayOneValue;

        public override bool Equals(object obj)
        {
            return this.name.Equals(((Month)obj).name);
        }
    }

    public enum Months
    {
        JAN,
        FEB,
        MAR,
        APR,
        MAI,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC,
        OTH
    }
}
