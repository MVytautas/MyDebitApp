using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lizingas_v2
{
    public class Details
    {
        public Details()

        {
            //this.Price = 0;
            //this.FirstIncome = 0;
            //this.Interest = 0;
            //this.Term = 0;
            //this.Income = 0;
            //this.Liabilities = 0;
            this.admMokestis = 400;
            this.currency = 3.45;
        }


        public double Income { get; set; } //Income

        public double Liabilities { get; set; } //Liabilities

        public double Price { get; set; } //priceCar

        public double FirstIncome { get; set; } 

        public double Interest { get; set; } // interestRate

        public int Term { get; set; } //leasTerm

        public double admMokestis { get; set; }

        public double currency { get; set; }

        public double leasSum { get; set; }

        public double sumForLeas { get; set; }

        public double residualRate { get; set; }

    }
}