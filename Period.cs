using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomePlus
{
    public class Period
    {
        public int Year { get; set; }
        public Month Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }

        public Period()
        {        }

        public Period(int year, Month month)
        {
            this.Year = year;
            this.Month = month;
        }

        public void AddTransaction(Transaction tr)
        {
            switch (tr.GetTrType())
            {
                case TransactionTypes.CR:
                    this.Income += tr.GetAmount();
                    break;
                case TransactionTypes.DB:
                    this.Expenses += tr.GetAmount();
                    break;
            }
        }
    }
}
