using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace RechnerWaehrung
{
    public partial class Form1 : Form
    {

        string from = "CHF";
        string to = "JPY";
        int amountCurrency = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            // Check if Currency Combobox is null

            if (rateFrom.SelectedItem==null)
            {
                MessageBox.Show("Währung bitte angeben");
            }
            else 
            {      
                from = rateFrom.SelectedItem.ToString();
            }

            // Check if Currency Combobox is null

            if (rateFrom.SelectedItem == null)
            {
                MessageBox.Show("Zielwährung bitte angeben");
            }
            else
            {     
                to = rateTo.SelectedItem.ToString();

            }

            amountCurrency = Convert.ToInt32(Math.Round(amount.Value, 0));

           
            // Calculate and display the currency exchange rate
            float exchangeRate = CurrencyConverter.GetExchangeRate(from, to, amountCurrency);

            calculated.Text =  exchangeRate.ToString("0.00") + " " +  to.ToString();

 
        }
    }
}
