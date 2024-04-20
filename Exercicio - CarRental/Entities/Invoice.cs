using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___CarRental.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment { get { return BasicPayment + Tax; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invoice:");
            sb.AppendLine("Basic payment: " + BasicPayment);
            sb.AppendLine("tax: " + Tax);
            sb.AppendLine("Total payment: " + TotalPayment);

            return sb.ToString();
        }
    }
}
