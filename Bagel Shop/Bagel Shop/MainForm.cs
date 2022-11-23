using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private static decimal[,] BagelPrices = new decimal[BagelNames.Length, BagelSizes.Length];

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
        private int NumberOfTransactions = 0;
        private decimal RunningTotal;
        private const String TRANSACTION_FILE = "BagelTransactions.txt";
        private const String PRICES_FILE = "BagelPrices.txt";
        private const String STOCK_FILE = "BagelStock.txt";
        private const String STOCK_REPORT_FILE = "BagelStockReport.txt";
        private const char SEPARATOR = ',';

        private string Receipt;

        private List<int[]> OrderItemList;

        const int ROW_POS = 0, COL_POS = 1, QUANTITY_POS = 2;

        private void orderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderedItems > 0)
                {
                    String TransactionNumber = getUniqueRandomTransactionNumber();

                    String[] OrderDetails = new String[FIRST_LINE_ITEM_POS + ItemGroupBox.Items.Count];

                    Receipt += "\n\nRECEIPT.\n\n";
                    Receipt += "Company \tMyBagelShop Inc.\n";

                    OrderDetails[TX_NO_POS] = TransactionNumber;
                    Receipt += "TX No. \t\t" + OrderDetails[TX_NO_POS] + '\n';

                    OrderDetails[DATE_POS] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    Receipt += "Date \t\t" + OrderDetails[DATE_POS] + '\n';

                    Receipt += "--------------------------------------------------------------------\n";
                    for (int i = 0; i < ItemGroupBox.Items.Count; i++)
                    {
                        OrderDetails[FIRST_LINE_ITEM_POS + i] = ItemGroupBox.Items[i].ToString();
                        Receipt += (i + 1) + " - " + OrderDetails[FIRST_LINE_ITEM_POS + i] + '\n';
                    }

                    Receipt += "--------------------------------------------------------------------\n";
                    OrderDetails[ORDER_TOTAL_POS] = RunningTotal.ToString("C");
                    Receipt += "Total Price. \t" + OrderDetails[ORDER_TOTAL_POS] + '\n';

                    String line = String.Join(SEPARATOR.ToString(), OrderDetails);
                    using (StreamWriter sw = File.AppendText(TRANSACTION_FILE))
                    {
                        sw.WriteLine(line);
                    }

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

        private void saleReportBtn_Click(object sender, EventArgs e)
        {
            BagelReportForm BagelReport = new BagelReportForm();
            BagelReport.loadSalesReport(BagelNames, BagelSizesAbbreviated, BagelOpeningStock, BagelStockLevelsTemp, BagelPrices, NumberOfTransactions);
            BagelReport.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void AddFileRecordToListBox(string fileLine, ref ListBox listBox)
        {
            string[] Order = fileLine.Split(SEPARATOR);

            String TXNo = Order[TX_NO_POS];
            String Date = Order[DATE_POS];
            String TotalSale = Order[ORDER_TOTAL_POS];

            listBox.Items.Add("Transaction No. \t" + TXNo);
            listBox.Items.Add("Date \t" + Date);

            for (int i = 3; i < Order.Length; i++)
            {
                listBox.Items.Add(Order[i]);
            }
            listBox.Items.Add("--------------------------------------------------------------------");
            listBox.Items.Add("Total Sale \t" + TotalSale);
            listBox.Items.Add("");
        }

        private int SearchUniqueIndex(string search, string[] allFileLines)
        {
            int index = -1;
            for (int i = 0; i < allFileLines.Length; i++)
            {
                string[] splitting = allFileLines[i].Split(',');
                if (splitting[0].Equals(search))
                {
                    index = i;
                }
            }
            return index;
        }

        private List<int> SearchDatedTransactions(string search, string[] allFileLines)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < allFileLines.Length; i++)
            {
                string[] splitting = allFileLines[i].Split(',');
                if (splitting[1].Contains(search))
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        private List<String> SearchAll(string searchValue, string[] allFileLines)
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

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchResultListBox.Items.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in ItemGroupBox.Items)
            {
                RecoverRemoveItemFromListBox(item.ToString());
            }
            resetOrderFields();

        }

        private void resetOrderFields()
        {
            ItemGroupBox.Items.Clear();
            OrderedItems = 0;
            RunningTotal = 0;
            totalDisplayLabel.Text = "";
            priceDisplayLabel.Text = "";
            resetSizeButtonColors();
            resetTypeButtonColors();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (ItemGroupBox.SelectedIndex != -1)
            {
                RecoverRemoveItemFromListBox(ItemGroupBox.SelectedItem.ToString());
                ItemGroupBox.Items.RemoveAt(ItemGroupBox.SelectedIndex);
            }
        }

        private void RecoverRemoveItemFromListBox(String item)
        {
            String[] firstSplit = item.Split(new String[] { " - " }, StringSplitOptions.None);
            String[] Item = firstSplit[1].Split('\t');
            int Row = -1, Col = -1;
            for (int i = 0; i < BagelNames.Length; i++)
            {
                for (int j = 0; j < BagelSizes.Length; j++)
                {
                    if (firstSplit[0].Equals(BagelNames[i]) && Item[0].Equals(BagelSizes[j]))
                    {
                        Row = i;
                        Col = j;
                    }
                }
            }
            int Quantity = int.Parse(Item[1]);

            BagelStockLevelsTemp[Row, Col] += Quantity;


            OrderedItems = OrderedItems - Quantity;

            RunningTotal = RunningTotal - (Quantity * BagelPrices[Row, Col]);

            totalDisplayLabel.Text = RunningTotal.ToString("C2");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetTypeButtonColors()
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

        private void resetSizeButtonColors()
        {
            smallSizeBtn.BackColor = SystemColors.Control;
            mediumSizeBtn.BackColor = SystemColors.Control;
            regularSizeBtn.BackColor = SystemColors.Control;
            largeSizeBtn.BackColor = SystemColors.Control;
            extraLargeSizeBtn.BackColor = SystemColors.Control;
        }


        private void BagelTypeBtns_Click(object sender, EventArgs e)
        {
            try
            {
                resetTypeButtonColors();
                Button BagelTypeBtn = (Button)sender;
                BagelTypeBtn.BackColor = Color.LightGreen;
                BagelNameIndex = int.Parse(BagelTypeBtn.Tag.ToString());
                if (BagelNameIndex != -1 && BagelSizeIndex != -1)
                {
                    priceDisplayLabel.Text = BagelPrices[BagelNameIndex, BagelSizeIndex].ToString("C2");
                }
            }
            catch (Exception)
            {

            }
        }

        private void BagelSizeBtns_Click(object sender, EventArgs e)
        {
            try
            {
                resetSizeButtonColors();
                Button BagelSizeBtn = (Button)sender;
                BagelSizeBtn.BackColor = Color.LightGreen;
                BagelSizeIndex = int.Parse(BagelSizeBtn.Tag.ToString());
                if (BagelNameIndex != -1 && BagelSizeIndex != -1)
                {
                    priceDisplayLabel.Text = BagelPrices[BagelNameIndex, BagelSizeIndex].ToString("C2");
                }
            }
            catch (Exception)
            {

            }
        }

        private void MyBagelShopApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in ItemGroupBox.Items)
            {
                RecoverRemoveItemFromListBox(item.ToString());
            }
            write2DIntArrayToFile(STOCK_FILE, BagelStockLevelsTemp);
        }

        private void stockToFileBtn_Click(object sender, EventArgs e)
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
                stream.Close();
                MessageBox.Show("Stock Report File of the name \"" + STOCK_REPORT_FILE + "\" has been generated. Please check the debug folder.", "Stock Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }

        private string getUniqueRandomTransactionNumber()
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

        private void MyBagelShopApp_Load(object sender, EventArgs e)
        {
            OrderItemList = new List<int[]>();
            load2DIntArrayFromFile(STOCK_FILE, ref BagelOpeningStock);
            BagelStockLevelsTemp = (int[,])BagelOpeningStock.Clone();
            load2DDecimalArrayFromFile(PRICES_FILE, ref BagelPrices);
        }

        private bool load2DDecimalArrayFromFile(String fileName, ref decimal[,] records)
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
                MessageBox.Show("Error loading data from file: " + fileName + "\r");
            }
            return false;
        }

        private bool load2DIntArrayFromFile(String fileName, ref int[,] records)
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
                MessageBox.Show("Error loading data from file: " + fileName + "\r");
            }
            return false;
        }

        private bool write2DIntArrayToFile(String fileName, int[,] records)
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
                stream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing data to file: " + fileName + "\r");
            }
            return false;
        }

        const string PriceFilePath = "PricesBagelShop.txt";

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            int Quantity, QuantityInStock;
            decimal OrderPrice = 0;
            String OrderLineItem = "";
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
                        OrderLineItem = BagelNames[BagelNameIndex] + " - " + BagelSizes[BagelSizeIndex] + "\t" + Quantity + "\t" + OrderPrice.ToString("C");
                        ItemGroupBox.Items.Add(OrderLineItem);
                        OrderItemList.Add(new int[] { BagelNameIndex, BagelSizeIndex, Quantity });
                        RunningTotal += OrderPrice;
                        totalDisplayLabel.Text = RunningTotal.ToString("C");
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
                        MessageBox.Show("Sorry, we only have " + QuantityInStock + " in stock");
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
