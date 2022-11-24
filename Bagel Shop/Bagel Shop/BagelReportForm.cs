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

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void loadSalesReport(String[] stockNames, String[] stoclSizes, int[,] openingStock, int[,] closingStock, decimal[,] stockPrices, int numberOfTransactions)
        {
            CultureInfo cultureInfo = new CultureInfo("fr-FR");
            int totalUnitsSold = 0;
            decimal totalSalesValue = 0.0M;
            listBoxReport.Items.Clear();
            String ReportItem;
            for (int row = 0; row < stockNames.Length; row++)
            {
                for (int col = 0; col < stoclSizes.Length; col++)
                {
                    int QuantitySold = openingStock[row, col] - closingStock[row, col];
                    totalUnitsSold += QuantitySold;
                    decimal totalPrice = stockPrices[row, col] * QuantitySold;
                    totalSalesValue += totalPrice;
                    ReportItem = stockNames[row] + " - " + stoclSizes[col] + " \t\t\t" + QuantitySold + " \t\t" + (totalPrice).ToString("C2", cultureInfo);
                    listBoxReport.Items.Add(ReportItem);
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
