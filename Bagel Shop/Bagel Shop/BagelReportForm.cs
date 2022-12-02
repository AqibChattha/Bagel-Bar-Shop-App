using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagel_Shop
{
    public partial class BagelReportForm : Form
    {
        public BagelReportForm()
        {
            InitializeComponent();
        }

        // On Exit close the form.
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This method is called when the form is loaded. It load the data into the datagridview and formats the columns. It will also calculate the total sales and other fields.
        public void loadSalesReport(String[] stockNames, String[] stoclSizes, int[,] openingStock, int[,] closingStock, decimal[,] stockPrices, int numberOfTransactions)
        {
            CultureInfo cultureInfo = new CultureInfo("fr-FR");
            int totalUnitsSold = 0;
            decimal totalSalesValue = 0.0M;
            dgvReport.Rows.Clear();
            for (int row = 0; row < stockNames.Length; row++)
            {
                for (int col = 0; col < stoclSizes.Length; col++)
                {
                    int QuantitySold = openingStock[row, col] - closingStock[row, col];
                    totalUnitsSold += QuantitySold;
                    decimal totalPrice = stockPrices[row, col] * QuantitySold;
                    totalSalesValue += totalPrice;
                    dgvReport.Rows.Add(stockNames[row], stoclSizes[col], QuantitySold, totalPrice.ToString("C", cultureInfo));
                }
            }
            decimal averagePerTranasaction = 0.0M;
            if (numberOfTransactions != 0)
            {
                averagePerTranasaction = totalSalesValue / numberOfTransactions;
            }
            lbBagelsSold.Text = totalUnitsSold.ToString();
            lbSalseValue.Text = totalSalesValue.ToString("C2", cultureInfo);
            lbNumberOfTransactions.Text = numberOfTransactions.ToString();
            lbAverageTransactionPrice.Text = averagePerTranasaction.ToString("C2", cultureInfo);
        }
    }
}
