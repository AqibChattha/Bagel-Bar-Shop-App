using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Bagel_Shop
{
    public partial class MyBagelShopApp : Form
    {
        public MyBagelShopApp()
        {
            InitializeComponent();
        }

        private static String[] BagelNames = { "Whole Wheat", "Everything", "Blueberry", "Chocolate Chip", "Onion", "Asiago", "Salt", "Poppy Seed", "French Toast", "Egg", "Garlic", "Sesame", "Cheddar" };
        private static String[] BagelSizes = { "Small", "Medium", "Regular", "Large", "Extra Large" };
        private static String[] BagelSizesAbbreviated = { "S", "M", "R", "L", "XL" };

        private static decimal[,] BagelPrices =
        {
            { 2.45m, 2.95m, 3.45m, 3.95m, 4.45m },
            { 2.5m, 3.0m, 3.5m, 4.0m, 4.5m },
            { 2.55m, 3.05m, 3.55m, 4.05m, 4.55m },
            { 2.6m, 3.1m, 3.6m, 4.1m, 4.6m },
            { 2.65m, 3.15m, 3.65m, 4.15m, 4.65m },
            { 2.7m, 3.2m, 3.7m, 4.2m, 4.7m },
            { 2.75m, 3.25m, 3.75m, 4.25m, 4.75m },
            { 2.8m, 3.3m, 3.8m, 4.3m, 4.8m },
            { 2.85m, 3.35m, 3.85m, 4.35m, 4.85m },
            { 2.9m, 3.4m, 3.9m, 4.4m, 4.9m },
            { 2.95m, 3.45m, 3.95m, 4.45m, 4.95m },
            { 3.0m, 3.5m, 4.0m, 4.5m, 5.0m },
            { 3.05m, 3.55m, 4.05m, 4.55m, 5.05m }
        };

        private int[,] BagelStockLevels =
        {
            { 2, 3, 4, 5, 6},
            { 4, 4, 7, 13, 2},
            { 6, 5, 19, 11, 3},
            { 3, 2, 1, 1, 1},
            { 2, 3, 4, 5, 6},
            { 4, 4, 7, 13, 2},
            { 6, 5, 19, 11, 3},
            { 3, 2, 1, 1, 1},
            { 2, 3, 4, 5, 6},
            { 4, 4, 7, 13, 2},
            { 6, 5, 19, 11, 3},
            { 3, 2, 1, 1, 1},
            { 2, 3, 4, 5, 6}
        };

        private int[,] BagelStockLevelsTemp = new int[BagelNames.Length, BagelSizes.Length];
        private int[,] BagelOpeningStock = new int[BagelNames.Length, BagelSizes.Length];

        const int TX_NO_POS = 0, DATE_POS = 1, ORDER_TOTAL_POS = 2, FIRST_LINE_ITEM_POS = 3;
        private int BagelNameIndex = -1, BagelSizeIndex = -1, OrderedItems = 0;
        private CultureInfo cultureInfo = new CultureInfo("fr-FR");
        private int NumberOfTransactions = 0;
        private decimal RunningTotal;
        private const String TRANSACTION_FILE = "BagelTransactions.txt";
        private const String PRICES_FILE = "BagelPrices.txt";
        private const String STOCK_FILE = "BagelStock.txt";
        private const String STOCK_REPORT_FILE = "BagelStockReport.txt";
        private const char SEPARATOR = '^';

        private string Receipt;


        const int ROW_POS = 0, COL_POS = 1, QUANTITY_POS = 2;

        private void orderBtn_Click(object sender, EventArgs e) // When the order button is pressed. It will save the transaction and also view the receipt.
        {
            try
            {
                if (OrderedItems > 0)
                {
                    String TransactionNumber = getUniqueRandomTransactionNumber();

                    String[] OrderDetails = new String[FIRST_LINE_ITEM_POS + dgvOrders.Rows.Count];

                    Receipt += "\n\nRECEIPT.\n\n";
                    Receipt += "Company \tMyBagelShop Inc.\n";

                    OrderDetails[TX_NO_POS] = TransactionNumber;
                    Receipt += "TX No. \t\t" + OrderDetails[TX_NO_POS] + '\n';

                    OrderDetails[DATE_POS] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    Receipt += "Date \t\t" + OrderDetails[DATE_POS] + '\n';

                    Receipt += "--------------------------------------------------------------------\n";
                    for (int i = 0; i < dgvOrders.Rows.Count; i++)
                    {
                        string additionalTab = "";
                        string additionalTab2 = "";
                        if (dgvOrders.Rows[i].Cells[0].Value.ToString().Length < 8)
                        {
                            additionalTab = "\t";
                        }
                        if (!dgvOrders.Rows[i].Cells[1].Value.ToString().Equals("Extra Large") || !BagelNames.Any(x => x == dgvOrders.Rows[i].Cells[0].Value.ToString()))
                        {
                            additionalTab2 = "\t";
                        }
                        OrderDetails[FIRST_LINE_ITEM_POS + i] = dgvOrders.Rows[i].Cells[0].Value.ToString() + '\t' + additionalTab + dgvOrders.Rows[i].Cells[1].Value.ToString() + '\t' + additionalTab2 + dgvOrders.Rows[i].Cells[2].Value.ToString() + '\t' + dgvOrders.Rows[i].Cells[3].Value.ToString();
                        Receipt += dgvOrders.Rows[i].Cells[0].Value.ToString() + '\t' + additionalTab + dgvOrders.Rows[i].Cells[1].Value.ToString() + '\t' + additionalTab2 + dgvOrders.Rows[i].Cells[2].Value.ToString() + '\t' + dgvOrders.Rows[i].Cells[3].Value.ToString() + "\n";
                    }

                    Receipt += "--------------------------------------------------------------------\n";
                    OrderDetails[ORDER_TOTAL_POS] = RunningTotal.ToString("C2", cultureInfo);
                    Receipt += "Total Price. \t" + OrderDetails[ORDER_TOTAL_POS] + '\n';

                    String line = String.Join(SEPARATOR.ToString(), OrderDetails);
                    StreamWriter sw = File.AppendText(TRANSACTION_FILE);
                    sw.WriteLine(line);
                    sw.Dispose();
                    sw.Close();

                    MessageBox.Show("Order placed successfully. Your transaction number is " + TransactionNumber + "." + Receipt, "Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Receipt = "";

                    resetOrderFields();

                    NumberOfTransactions++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error processing the order. Please, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saleReportBtn_Click(object sender, EventArgs e) // When the sales report button is pressed it will open a new form that will display the reports of the shop.
        {
            BagelReportForm BagelReport = new BagelReportForm();
            BagelReport.loadSalesReport(BagelNames, BagelSizesAbbreviated, BagelOpeningStock, BagelStockLevelsTemp, BagelPrices, NumberOfTransactions);
            BagelReport.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e) // If the search button is pressed it will load the corresponding transactions from the transaction file into the listbox.
        {
            String[] AllFileLines;
            String Search;
            if (String.IsNullOrWhiteSpace(searchInputTextBox.Text))
            {
                MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Search = searchInputTextBox.Text;
                try
                {
                    searchResultListBox.Items.Clear();
                    AllFileLines = File.ReadAllLines(TRANSACTION_FILE);
                    if (transactionNoRadioButton.Checked)
                    {
                        int index = SearchUniqueIndex(Search, AllFileLines);
                        if (index != -1)
                        {
                            AddFileRecordToListBox(AllFileLines[index], ref searchResultListBox);
                        }
                    }
                    else if (dateRadioButton.Checked)
                    {
                        foreach (int index in SearchDatedTransactions(Search, AllFileLines))
                        {
                            AddFileRecordToListBox(AllFileLines[index], ref searchResultListBox);
                        }
                    }
                    else
                    {
                        foreach (string searchedItem in SearchAll(Search, AllFileLines))
                        {
                            AddFileRecordToListBox(searchedItem, ref searchResultListBox);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void AddFileRecordToListBox(string fileLine, ref ListBox listBox) // This method is used to display the tramsactions in the listbox.
        {
            string[] Order = fileLine.Split(SEPARATOR);

            String TXNo = Order[TX_NO_POS];
            String Date = Order[DATE_POS];
            String TotalSale = Order[ORDER_TOTAL_POS];

            listBox.Items.Add("Company \tMyBagelShop Inc.\n");
            listBox.Items.Add("TX No. \t\t" + TXNo);
            listBox.Items.Add("Date \t\t" + Date);

            listBox.Items.Add("--------------------------------------------------------------------");
            for (int i = 3; i < Order.Length; i++)
            {
                listBox.Items.Add(Order[i]);
            }
            listBox.Items.Add("--------------------------------------------------------------------");
            listBox.Items.Add("Total Sale \t" + TotalSale);
            listBox.Items.Add("");
            listBox.Items.Add("");
        }

        private int SearchUniqueIndex(string search, string[] allFileLines) // This will search and return the index of the transaction if the transaction ID is matched.
        {
            int index = -1;
            for (int i = 0; i < allFileLines.Length; i++)
            {
                string[] splitting = allFileLines[i].Split(SEPARATOR);
                if (splitting[0].Equals(search))
                {
                    index = i;
                }
            }
            return index;
        }

        private List<int> SearchDatedTransactions(string search, string[] allFileLines) // returns transactions ids on the basis of date.
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < allFileLines.Length; i++)
            {
                string[] splitting = allFileLines[i].Split(SEPARATOR);
                if (splitting[1].Contains(search))
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        private List<String> SearchAll(string searchValue, string[] allFileLines) // this method will search the given string inside the whole transaction.
        {
            List<String> searchResults = new List<string>();
            for (int i = 0; i < allFileLines.Length; i++)
            {
                if (allFileLines[i].Contains(searchValue))
                {
                    searchResults.Add(allFileLines[i]);
                }
            }
            return searchResults;
        }

        private void clearSearchBtn_Click(object sender, EventArgs e) // This method will clear the search and the listbox.
        {
            searchInputTextBox.Clear();
            searchResultListBox.Items.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e) // This method will clear all the order in the cart and return them back into the list.
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                RecoverRemoveItemFromDataGridView(row);
            }
            resetOrderFields();

        }

        private void resetOrderFields() // This method will reset all the order area fields.
        {
            dgvOrders.Rows.Clear();
            OrderedItems = 0;
            RunningTotal = 0;
            totalDisplayLabel.Text = "";
            priceDisplayLabel.Text = "";
            resetSizeButtonColors();
            resetTypeButtonColors();
        }

        private void removeBtn_Click(object sender, EventArgs e) // This method is used to remove the selected row from the cart.
        {
            foreach (DataGridViewRow row in this.dgvOrders.SelectedRows)
            {
                RecoverRemoveItemFromDataGridView(row);
                dgvOrders.Rows.RemoveAt(row.Index);
            }
        }

        private void RecoverRemoveItemFromDataGridView(DataGridViewRow row) // This method is used to recover the removed item from the cart.
        {
            int Row = -1, Col = -1;
            for (int i = 0; i < BagelNames.Length; i++)
            {
                for (int j = 0; j < BagelSizes.Length; j++)
                {
                    if (row.Cells[0].Value.ToString().Equals(BagelNames[i]) && row.Cells[1].Value.ToString().Equals(BagelSizes[j]))
                    {
                        Row = i;
                        Col = j;
                    }
                }
            }
            int Quantity = Convert.ToInt32(row.Cells[2].Value);

            BagelStockLevelsTemp[Row, Col] += Quantity;


            OrderedItems = OrderedItems - Quantity;

            RunningTotal = RunningTotal - (Quantity * BagelPrices[Row, Col]);

            totalDisplayLabel.Text = RunningTotal.ToString("C2", cultureInfo);
        }

        private void exitBtn_Click(object sender, EventArgs e) // This method is used to exit the application.
        {
            Application.Exit();
        }

        private void resetTypeButtonColors() // This method will reset all the buttons color in the bagel type section.
        {
            // set color to system control
            wholeWheatBtn.BackColor = SystemColors.Control;
            button1everythingBtn.BackColor = SystemColors.Control;
            blueberryBtn.BackColor = SystemColors.Control;
            chocolateChipBtn.BackColor = SystemColors.Control;
            onionBtn.BackColor = SystemColors.Control;
            asiagoBtn.BackColor = SystemColors.Control;
            saltBtn.BackColor = SystemColors.Control;
            poppySeedBtn.BackColor = SystemColors.Control;
            frenchToastBtn.BackColor = SystemColors.Control;
            eggBtn.BackColor = SystemColors.Control;
            garlicBtn.BackColor = SystemColors.Control;
            sesameBtn.BackColor = SystemColors.Control;
            cheddarBtn.BackColor = SystemColors.Control;
        }

        private void resetSizeButtonColors() // This method will reset all the buttons in the bagel size section.
        {
            smallSizeBtn.BackColor = SystemColors.Control;
            mediumSizeBtn.BackColor = SystemColors.Control;
            regularSizeBtn.BackColor = SystemColors.Control;
            largeSizeBtn.BackColor = SystemColors.Control;
            extraLargeSizeBtn.BackColor = SystemColors.Control;
        }


        private void BagelTypeBtns_Click(object sender, EventArgs e) // When a bagel type button is clicked, this method reset all fields and set the clicked button to green.
        {
            try
            {
                resetTypeButtonColors();
                Button BagelTypeBtn = (Button)sender;
                BagelTypeBtn.BackColor = Color.LightGreen;
                BagelNameIndex = int.Parse(BagelTypeBtn.Tag.ToString());
                if (BagelNameIndex != -1 && BagelSizeIndex != -1)
                {
                    priceDisplayLabel.Text = BagelPrices[BagelNameIndex, BagelSizeIndex].ToString("C2", cultureInfo);
                }
            }
            catch (Exception)
            {

            }
        }

        private void BagelSizeBtns_Click(object sender, EventArgs e) // When a bagel size button is clicked, this method reset all fields and set the clicked button to green.
        {
            try
            {
                resetSizeButtonColors();
                Button BagelSizeBtn = (Button)sender;
                BagelSizeBtn.BackColor = Color.LightGreen;
                BagelSizeIndex = int.Parse(BagelSizeBtn.Tag.ToString());
                if (BagelNameIndex != -1 && BagelSizeIndex != -1)
                {
                    priceDisplayLabel.Text = BagelPrices[BagelNameIndex, BagelSizeIndex].ToString("C2", cultureInfo);
                }
            }
            catch (Exception)
            {

            }
        }

        private void MyBagelShopApp_FormClosing(object sender, FormClosingEventArgs e) // This method will save the stock levels into the file.
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                RecoverRemoveItemFromDataGridView(row);
            }
            write2DIntArrayToFile(STOCK_FILE, BagelStockLevelsTemp);
        }

        private void searchInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void stockToFileBtn_Click(object sender, EventArgs e) // Maually save the stock file when the application is running.
        {
            if (OrderedItems > 0)
            {
                if (DialogResult.Cancel == MessageBox.Show("There are Items in the cart that have to be processed. Do you want to ignore them and continue?"
                    , "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                {
                    return;
                }
            }
            try
            {
                StreamWriter stream = File.CreateText(STOCK_REPORT_FILE);
                for (int row = 0; row < BagelStockLevelsTemp.GetLength(0); row++)
                {
                    for (int col = 0; col < BagelStockLevelsTemp.GetLength(1); col++)
                    {
                        stream.WriteLine(BagelNames[row] + " - " + BagelSizes[col] + ", \t\t\t" + BagelStockLevelsTemp[row, col]);
                    }
                }
                stream.Dispose();
                stream.Close();
                MessageBox.Show("Stock Report File of the name \"" + STOCK_REPORT_FILE + "\" has been generated. Please check the debug folder.", "Stock Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }

        private string getUniqueRandomTransactionNumber() // Returns a unique transaction id for new transactions.
        {
            string TransactionNumber;

            Random random = new Random();
            String[] AllFileLines = File.ReadAllLines(TRANSACTION_FILE);
            do
            {
                TransactionNumber = "";
                for (int i = 0; i < 5; i++)
                {
                    int randomInt = random.Next(0, 36);
                    if (randomInt < 10)
                    {
                        TransactionNumber += randomInt;
                    }
                    else
                    {
                        TransactionNumber += (char)('A' + randomInt - 10);
                    }
                }
            } while (SearchUniqueIndex(TransactionNumber, AllFileLines) != -1);

            return TransactionNumber;
        }

        private void MyBagelShopApp_Load(object sender, EventArgs e) // Function called when the app loads. It will initializa all the lists in the application.
        {
            try
            {
                if (File.Exists(PRICES_FILE))
                {
                    load2DDecimalArrayFromFile(PRICES_FILE, ref BagelPrices);
                }
            }
            catch (Exception) { }

            try
            {
                if (File.Exists(STOCK_FILE))
                {
                    load2DIntArrayFromFile(STOCK_FILE, ref BagelOpeningStock);
                }
                else
                {
                    BagelOpeningStock = (int[,])BagelStockLevels.Clone();
                }
            }
            catch (Exception) { BagelOpeningStock = (int[,])BagelStockLevels.Clone(); }

            try
            {
                if (!File.Exists(TRANSACTION_FILE))
                {
                    using (File.Create(TRANSACTION_FILE)) { }
                }
            }
            catch (Exception) { }
            BagelStockLevelsTemp = (int[,])BagelOpeningStock.Clone();
        }

        private bool load2DDecimalArrayFromFile(String fileName, ref decimal[,] records) // This method will load a 2D decimal array from a file.
        {
            int row = 0;
            String[] RecordRow, AllRecordRows;

            try
            {
                AllRecordRows = File.ReadAllLines(fileName);
                for (row = 0; row < AllRecordRows.Length; row++)
                {
                    RecordRow = AllRecordRows[row].Split(SEPARATOR);

                    for (int col = 0; col < RecordRow.Length; col++)
                    {
                        records[row, col] = decimal.Parse(RecordRow[col]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, There was an error loading data from file: " + fileName + ". Please check the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool load2DIntArrayFromFile(String fileName, ref int[,] records) // This method will load a 2D int array from a file.
        {
            int row = 0;
            String[] RecordRow, AllRecordRows;

            try
            {
                AllRecordRows = File.ReadAllLines(fileName);
                for (row = 0; row < AllRecordRows.Length; row++)
                {
                    RecordRow = AllRecordRows[row].Split(SEPARATOR);

                    for (int col = 0; col < RecordRow.Length; col++)
                    {
                        records[row, col] = int.Parse(RecordRow[col]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, There was an error loading the data from file: " + fileName + ". Please check the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool write2DIntArrayToFile(String fileName, int[,] records) // This method will write a 2D int array to a file.
        {
            int row = 0;
            int[] RecordRow = new int[records.GetLength(1)];

            try
            {
                StreamWriter stream = File.CreateText(fileName);
                for (row = 0; row < records.GetLength(0); row++)
                {
                    for (int col = 0; col < records.GetLength(1); col++)
                    {
                        RecordRow[col] = records[row, col];
                    }
                    stream.WriteLine(String.Join(SEPARATOR.ToString(), RecordRow));
                }
                stream.Dispose();
                stream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, There was an error in writing data to file: " + fileName + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void addToCartBtn_Click(object sender, EventArgs e) // This method will add the selected item to the cart.
        {
            int Quantity, QuantityInStock;
            decimal OrderPrice = 0;
            if (BagelNameIndex == -1 || BagelSizeIndex == -1)
            {
                MessageBox.Show("Please select a bagel type and size", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Quantity = (int)quantityNumericUpDown.Value;
                    QuantityInStock = BagelStockLevelsTemp[BagelNameIndex, BagelSizeIndex];
                    if (Quantity <= QuantityInStock)
                    {
                        OrderPrice = BagelPrices[BagelNameIndex, BagelSizeIndex] * Quantity;
                        dgvOrders.Rows.Add(new String[] { BagelNames[BagelNameIndex], BagelSizes[BagelSizeIndex], Quantity.ToString(), OrderPrice.ToString("C2", cultureInfo) });
                        RunningTotal += OrderPrice;
                        totalDisplayLabel.Text = RunningTotal.ToString("C2", cultureInfo);
                        OrderedItems += Quantity;
                        BagelStockLevelsTemp[BagelNameIndex, BagelSizeIndex] -= Quantity;
                        BagelNameIndex = -1;
                        BagelSizeIndex = -1;
                        quantityNumericUpDown.Value = 1;
                        resetTypeButtonColors();
                        resetSizeButtonColors();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, we have " + QuantityInStock + " bagels of this combination in stock");
                        quantityNumericUpDown.Value = QuantityInStock;
                        quantityNumericUpDown.Focus();
                    }
                }
                catch (Exception)
                {
                }
            }
            return;
        }
    }
}
