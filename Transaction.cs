using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IncomePlus
{

    public struct Transaction
    {
        public string timestamp;
        public string type;
        public string amount;


        public int GetTrYear()
        {
            return GetTimestamp().GetYear();
        }

        public Month GetTrMonth()
        {
            return GetTimestamp().GetMonth();
        }

        public TransactionTypes GetTrType()
        {
            this.type = this.type.Trim();
            TransactionTypes type = TransactionTypes.OT;
            switch (this.type)
            {
                case "CREDIT":
                    type = TransactionTypes.CR;
                    break;
                case "DEBIT":
                    type = TransactionTypes.DB;
                    break;
                default:
                    type = TransactionTypes.OT;
                    break;
            }

            return type;
        }

        public decimal GetAmount()
        {
            this.amount = this.amount.Trim();
            decimal decimalAmount = Convert.ToDecimal(this.amount, CultureInfo.InvariantCulture);
            decimalAmount = Math.Abs(decimalAmount);
            return decimalAmount;
        }

        private Timestamp GetTimestamp()
        {
            this.timestamp = this.timestamp.Trim();
            Timestamp result = new Timestamp();
            result.value = this.timestamp;
            return result;
        }

    }

    public enum TransactionTypes
    {
        CR,
        DB,
        OT
    }
}
