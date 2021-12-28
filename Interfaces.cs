using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransactions
    {
        private string tcode;
        private string date;
        private double amount;
        public Transaction()
        {
            tcode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tcode = c;
            date = d;
            amount = a; 
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tcode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "2/10/2012", 454.55);
            Transaction t2 = new Transaction("002", "9/12/2011", 454.22);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}
