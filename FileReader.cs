using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IncomePlus
{
    public abstract class Reader
    {
        public string path 
        {
            get 
            {
                return @"\\Sfpfi4335.prod.mrq\usagers-dgtt\RBOI026\Documents\IncomePlus\Statement.csv";
            }
            set { }
        }
        public abstract void Read();
    }

    public class SimpleReader : Reader
    {

        public override void Read()
        {
            throw new NotImplementedException();
        }
    }

    public class BankFileReader : Reader
    {
        public List<Period> periods = new List<Period>();

        public override void Read()
        {
            string[] lines = ReadFile(base.path);

            Month currentMonth = new Month();
            currentMonth.name = Months.OTH;

            Period period = null;

            foreach (string line in lines)
            {
                Transaction tr = ReadTransaction(line);
                if (!tr.GetTrMonth().Equals(currentMonth) || period == null) 
                {
                    period = new Period(tr.GetTrYear(), tr.GetTrMonth());
                    periods.Add(period);
                    period.AddTransaction(tr);
                } else {
                    period.AddTransaction(tr);
                }

                currentMonth = tr.GetTrMonth();
            }
        }

        private string[] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            return lines;
        }

        private Transaction ReadTransaction(string line)
        {
            string[] parts = line.Split(',');
            Transaction tr = new Transaction();

            tr.timestamp = parts[1];
            tr.type = parts[2];
            tr.amount = parts[3];

            return tr;
        }
    }

}
