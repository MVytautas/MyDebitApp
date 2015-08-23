using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lizingas_v2
{
    public partial class Form1 : Form
    {
        private Details Details;

        public Form1()
        {
            InitializeComponent();
            Details = new Details();
        }

        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

        // First Input
        private void Income_TextChanged(object sender, EventArgs e)
        {
            string tString = Income_TextBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    Income_TextBox.Text = "";
                    return;
                }
            }
            Details.Income = Convert.ToDouble(Income_TextBox.Text);
            Update();
        }

        // Second input
        private void Liabilities_TextChanged(object sender, EventArgs e)
        {
            string tString = Liabilities_TextBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    Liabilities_TextBox.Text = "";
                    return;
                }
            }
            Details.Liabilities = Convert.ToDouble(Liabilities_TextBox.Text);
            Update();
        }


        public void Update()
        {
            

            if (Details != null)
            {
                
                ToCredit_Label.Text = Convert.ToString( RoundUp(Details.Income - Details.Liabilities,2)  * 0.4) + " LT";
                ToAlive_Label.Text = Convert.ToString( RoundUp(Details.Income - Details.Liabilities,2) * 0.6) + " LT";

                //admistrate payment
                admMokestis.Text = Convert.ToString(Details.admMokestis) + " LT";

                //Sum
                double rate = Details.Interest / 100;
                double sum = Details.Price * rate;
                label13.Text = Convert.ToString(RoundUp(Details.Price + sum + Details.admMokestis,2)) + " LT";

                //leas payment amount
                
                double sumToLeas = (Details.Price - Details.FirstIncome)*rate;
                leasPayment.Text = Convert.ToString(RoundUp(((Details.Price - Details.FirstIncome) + sumToLeas)/Details.Term,2));
                //EUR

                string[] words1 = ToAlive_Label.Text.Split(' ');
                Details.sumForLeas = Convert.ToDouble(words1[0]);

                string[] words = leasPayment.Text.Split(' ');
                Details.leasSum = Convert.ToDouble(words[0]);
                

                if (Details.sumForLeas > Details.leasSum)
                {
                    leasPayment.ForeColor = Color.Green;
                }
                else if (Details.sumForLeas < Details.leasSum)
                {
                    leasPayment.ForeColor = Color.Red;
                }

                // Residual Value start ///
                double residualRate = Details.residualRate / 100;
                double residualValSum = Details.Price * residualRate;


                if (Finansinislizingassulikutineverte.Checked)
                {
                    leasPayment.Text = Convert.ToString(RoundUp((((Details.Price - Details.FirstIncome) - residualValSum) + sumToLeas) / Details.Term,2));
                }
                // Residual Value end ///
            }
        }

        private void firstIncome_ValueChanged(object sender, EventArgs e)
        {
            Details.FirstIncome = Convert.ToDouble(firstIncome.Value);
            Update();
        }

        private void leasTerm_ValueChanged(object sender, EventArgs e)
        {
            Details.Term = Convert.ToInt16(leasTerm.Value);
            //Details.Term = Convert.ToDouble(leasTerm.Value);
            Update();
        }

        private void priceCar_ValueChanged(object sender, EventArgs e)
        {
            Details.Price = Convert.ToDouble(priceCar.Value);
            Update();
        }

        private void interestRate_ValueChanged(object sender, EventArgs e)
        {
            Details.Interest = Convert.ToDouble(interestRate.Value);
            Update();
        }

        private void EUR_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EUR_radioButton.Checked)
            {
                Price_Lt.Text = " EUR";
                PayText_Label.Text = " EUR";
            }

            ToCredit_Label.Text = Convert.ToString(RoundUp(( (Details.Income - Details.Liabilities) * 0.4) / Details.currency,2)) + " EUR";
            ToAlive_Label.Text = Convert.ToString(RoundUp(( (Details.Income - Details.Liabilities) * 0.6) / Details.currency,2)) + " EUR";


            double rate = Details.Interest / 100;
            double sum = Details.Price * rate;
            label13.Text = Convert.ToString(RoundUp((Details.Price + sum + Details.admMokestis) / Details.currency,2)) + " EUR";

            admMokestis.Text = Convert.ToString(Details.admMokestis / Details.currency) + " EUR";

            double sumToLeas = (Details.Price - Details.FirstIncome) * rate;
            leasPayment.Text = Convert.ToString(RoundUp((((Details.Price - Details.FirstIncome) + sumToLeas) / Details.Term) / Details.currency, 2));
         
        }

        private void LT_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            ToCredit_Label.Text = Convert.ToString(RoundUp(Details.Income - Details.Liabilities, 2) * 0.4) + " LT";
            ToAlive_Label.Text = Convert.ToString(RoundUp(Details.Income - Details.Liabilities, 2) * 0.6) + " LT";

            if (LT_radioButton.Checked)
            {
                Price_Lt.Text = " LT";
                PayText_Label.Text = " LT";
            }

            double rate = Details.Interest / 100;
            double sum = Details.Price * rate;
            label13.Text = Convert.ToString(RoundUp(Details.Price + sum + Details.admMokestis, 2)) + " LT";

            admMokestis.Text = Convert.ToString(Details.admMokestis) + " LT";

            double sumToLeas = (Details.Price - Details.FirstIncome) * rate;
            leasPayment.Text = Convert.ToString(RoundUp(((Details.Price - Details.FirstIncome) + sumToLeas) / Details.Term, 2));

        }

        private void label13_Click(object sender, EventArgs e)
        {}

        private void leasPayment_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Finansinislizingassulikutineverte_CheckedChanged(object sender, EventArgs e)
        {
            ResidualValue_numericUpDown.Enabled = true;
        }

        private void Finansinislizingas_CheckedChanged(object sender, EventArgs e)
        {
            ResidualValue_numericUpDown.Enabled = false;
            Update();
        }

        private void ResidualValue_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Details.residualRate = Convert.ToDouble(ResidualValue_numericUpDown.Value);
            Update();
        }
    }
}