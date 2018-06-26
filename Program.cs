using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomePlus
{
    class Program
    {
        static void Main(string[] args)
        {
            BankFileReader reader = new BankFileReader();
            reader.Read();

            Console.ReadKey();
        }
    }
}
