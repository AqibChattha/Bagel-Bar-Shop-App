namespace Bagel_Shop
{
    partial class MyBagelShopApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShopApp));
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.wholeWheatBtn = new System.Windows.Forms.Button();
            this.selectBagelgroupBox = new System.Windows.Forms.GroupBox();
            this.saltBtn = new System.Windows.Forms.Button();
            this.cheddarBtn = new System.Windows.Forms.Button();
            this.sesameBtn = new System.Windows.Forms.Button();
            this.garlicBtn = new System.Windows.Forms.Button();
            this.eggBtn = new System.Windows.Forms.Button();
            this.frenchToastBtn = new System.Windows.Forms.Button();
            this.poppySeedBtn = new System.Windows.Forms.Button();
            this.asiagoBtn = new System.Windows.Forms.Button();
            this.onionBtn = new System.Windows.Forms.Button();
            this.chocolateChipBtn = new System.Windows.Forms.Button();
            this.blueberryBtn = new System.Windows.Forms.Button();
            this.button1everythingBtn = new System.Windows.Forms.Button();
            this.sizeSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.extraLargeSizeBtn = new System.Windows.Forms.Button();
            this.largeSizeBtn = new System.Windows.Forms.Button();
            this.regularSizeBtn = new System.Windows.Forms.Button();
            this.mediumSizeBtn = new System.Windows.Forms.Button();
            this.smallSizeBtn = new System.Windows.Forms.Button();
            this.orderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.ItemGroupBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.priceDisplayLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.saleReportBtn = new System.Windows.Forms.Button();
            this.stockToFileBtn = new System.Windows.Forms.Button();
            this.searchTrxGroupBox = new System.Windows.Forms.GroupBox();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extraImagePictureBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.selectBagelgroupBox.SuspendLayout();
            this.sizeSelectGroupBox.SuspendLayout();
            this.orderDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.searchTrxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Location = new System.Drawing.Point(0, -2);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(841, 75);
            this.topPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 2);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(218, 74);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // wholeWheatBtn
            // 
            this.wholeWheatBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeWheatBtn.Location = new System.Drawing.Point(8, 20);
            this.wholeWheatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.wholeWheatBtn.Name = "wholeWheatBtn";
            this.wholeWheatBtn.Size = new System.Drawing.Size(74, 60);
            this.wholeWheatBtn.TabIndex = 1;
            this.wholeWheatBtn.Tag = "0";
            this.wholeWheatBtn.Text = "Whole Wheat";
            this.btnToolTip.SetToolTip(this.wholeWheatBtn, "Bagels of the category \'Whole Wheat\'.");
            this.wholeWheatBtn.UseVisualStyleBackColor = true;
            this.wholeWheatBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // selectBagelgroupBox
            // 
            this.selectBagelgroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectBagelgroupBox.Controls.Add(this.saltBtn);
            this.selectBagelgroupBox.Controls.Add(this.cheddarBtn);
            this.selectBagelgroupBox.Controls.Add(this.sesameBtn);
            this.selectBagelgroupBox.Controls.Add(this.garlicBtn);
            this.selectBagelgroupBox.Controls.Add(this.eggBtn);
            this.selectBagelgroupBox.Controls.Add(this.frenchToastBtn);
            this.selectBagelgroupBox.Controls.Add(this.poppySeedBtn);
            this.selectBagelgroupBox.Controls.Add(this.asiagoBtn);
            this.selectBagelgroupBox.Controls.Add(this.onionBtn);
            this.selectBagelgroupBox.Controls.Add(this.chocolateChipBtn);
            this.selectBagelgroupBox.Controls.Add(this.blueberryBtn);
            this.selectBagelgroupBox.Controls.Add(this.button1everythingBtn);
            this.selectBagelgroupBox.Controls.Add(this.wholeWheatBtn);
            this.selectBagelgroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBagelgroupBox.Location = new System.Drawing.Point(6, 77);
            this.selectBagelgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectBagelgroupBox.Name = "selectBagelgroupBox";
            this.selectBagelgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectBagelgroupBox.Size = new System.Drawing.Size(554, 162);
            this.selectBagelgroupBox.TabIndex = 14;
            this.selectBagelgroupBox.TabStop = false;
            this.selectBagelgroupBox.Text = "Select Bagel";
            // 
            // saltBtn
            // 
            this.saltBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saltBtn.Location = new System.Drawing.Point(472, 51);
            this.saltBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saltBtn.Name = "saltBtn";
            this.saltBtn.Size = new System.Drawing.Size(74, 60);
            this.saltBtn.TabIndex = 13;
            this.saltBtn.Tag = "6";
            this.saltBtn.Text = "Salt";
            this.btnToolTip.SetToolTip(this.saltBtn, "Bagels of the category \'Salt\'.");
            this.saltBtn.UseVisualStyleBackColor = true;
            this.saltBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // cheddarBtn
            // 
            this.cheddarBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheddarBtn.Location = new System.Drawing.Point(395, 83);
            this.cheddarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cheddarBtn.Name = "cheddarBtn";
            this.cheddarBtn.Size = new System.Drawing.Size(74, 60);
            this.cheddarBtn.TabIndex = 12;
            this.cheddarBtn.Tag = "12";
            this.cheddarBtn.Text = "Cheddar";
            this.btnToolTip.SetToolTip(this.cheddarBtn, "Bagels of the category \'Cheddar\'.");
            this.cheddarBtn.UseVisualStyleBackColor = true;
            this.cheddarBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // sesameBtn
            // 
            this.sesameBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesameBtn.Location = new System.Drawing.Point(318, 83);
            this.sesameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sesameBtn.Name = "sesameBtn";
            this.sesameBtn.Size = new System.Drawing.Size(74, 60);
            this.sesameBtn.TabIndex = 11;
            this.sesameBtn.Tag = "11";
            this.sesameBtn.Text = "Sesame";
            this.btnToolTip.SetToolTip(this.sesameBtn, "Bagels of the category \'Sesame\'.");
            this.sesameBtn.UseVisualStyleBackColor = true;
            this.sesameBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // garlicBtn
            // 
            this.garlicBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garlicBtn.Location = new System.Drawing.Point(240, 83);
            this.garlicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garlicBtn.Name = "garlicBtn";
            this.garlicBtn.Size = new System.Drawing.Size(74, 60);
            this.garlicBtn.TabIndex = 10;
            this.garlicBtn.Tag = "10";
            this.garlicBtn.Text = "Garlic";
            this.btnToolTip.SetToolTip(this.garlicBtn, "Bagels of the category \'Garlic\'.");
            this.garlicBtn.UseVisualStyleBackColor = true;
            this.garlicBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // eggBtn
            // 
            this.eggBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggBtn.Location = new System.Drawing.Point(162, 83);
            this.eggBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eggBtn.Name = "eggBtn";
            this.eggBtn.Size = new System.Drawing.Size(74, 60);
            this.eggBtn.TabIndex = 9;
            this.eggBtn.Tag = "9";
            this.eggBtn.Text = "Egg";
            this.btnToolTip.SetToolTip(this.eggBtn, "Bagels of the category \'Egg\'.");
            this.eggBtn.UseVisualStyleBackColor = true;
            this.eggBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // frenchToastBtn
            // 
            this.frenchToastBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchToastBtn.Location = new System.Drawing.Point(85, 83);
            this.frenchToastBtn.Margin = new System.Windows.Forms.Padding(2);
            this.frenchToastBtn.Name = "frenchToastBtn";
            this.frenchToastBtn.Size = new System.Drawing.Size(74, 60);
            this.frenchToastBtn.TabIndex = 8;
            this.frenchToastBtn.Tag = "8";
            this.frenchToastBtn.Text = "French Toast";
            this.btnToolTip.SetToolTip(this.frenchToastBtn, "Bagels of the category \'French Toast\'.");
            this.frenchToastBtn.UseVisualStyleBackColor = true;
            this.frenchToastBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // poppySeedBtn
            // 
            this.poppySeedBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poppySeedBtn.Location = new System.Drawing.Point(8, 83);
            this.poppySeedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.poppySeedBtn.Name = "poppySeedBtn";
            this.poppySeedBtn.Size = new System.Drawing.Size(74, 60);
            this.poppySeedBtn.TabIndex = 7;
            this.poppySeedBtn.Tag = "7";
            this.poppySeedBtn.Text = "Poppy Seed";
            this.btnToolTip.SetToolTip(this.poppySeedBtn, "Bagels of the category \'Poppy Seed\'.");
            this.poppySeedBtn.UseVisualStyleBackColor = true;
            this.poppySeedBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // asiagoBtn
            // 
            this.asiagoBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiagoBtn.Location = new System.Drawing.Point(395, 20);
            this.asiagoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.asiagoBtn.Name = "asiagoBtn";
            this.asiagoBtn.Size = new System.Drawing.Size(74, 60);
            this.asiagoBtn.TabIndex = 6;
            this.asiagoBtn.Tag = "5";
            this.asiagoBtn.Text = "Asiago";
            this.btnToolTip.SetToolTip(this.asiagoBtn, "Bagels of the category \'Asiago\'.");
            this.asiagoBtn.UseVisualStyleBackColor = true;
            this.asiagoBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // onionBtn
            // 
            this.onionBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onionBtn.Location = new System.Drawing.Point(318, 20);
            this.onionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.onionBtn.Name = "onionBtn";
            this.onionBtn.Size = new System.Drawing.Size(74, 60);
            this.onionBtn.TabIndex = 5;
            this.onionBtn.Tag = "4";
            this.onionBtn.Text = "Onion";
            this.btnToolTip.SetToolTip(this.onionBtn, "Bagels of the category \'Onion\'.");
            this.onionBtn.UseVisualStyleBackColor = true;
            this.onionBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // chocolateChipBtn
            // 
            this.chocolateChipBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateChipBtn.Location = new System.Drawing.Point(240, 20);
            this.chocolateChipBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chocolateChipBtn.Name = "chocolateChipBtn";
            this.chocolateChipBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chocolateChipBtn.Size = new System.Drawing.Size(74, 60);
            this.chocolateChipBtn.TabIndex = 4;
            this.chocolateChipBtn.Tag = "3";
            this.chocolateChipBtn.Text = "Chocolate Chip";
            this.btnToolTip.SetToolTip(this.chocolateChipBtn, "Bagels of the category \'Chocolate Chip\'.");
            this.chocolateChipBtn.UseVisualStyleBackColor = true;
            this.chocolateChipBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // blueberryBtn
            // 
            this.blueberryBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueberryBtn.Location = new System.Drawing.Point(162, 20);
            this.blueberryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.blueberryBtn.Name = "blueberryBtn";
            this.blueberryBtn.Size = new System.Drawing.Size(74, 60);
            this.blueberryBtn.TabIndex = 3;
            this.blueberryBtn.Tag = "2";
            this.blueberryBtn.Text = "Blueberry";
            this.btnToolTip.SetToolTip(this.blueberryBtn, "Bagels of the category \'Blueberry\'.");
            this.blueberryBtn.UseVisualStyleBackColor = true;
            this.blueberryBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // button1everythingBtn
            // 
            this.button1everythingBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1everythingBtn.Location = new System.Drawing.Point(85, 20);
            this.button1everythingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.button1everythingBtn.Name = "button1everythingBtn";
            this.button1everythingBtn.Size = new System.Drawing.Size(74, 60);
            this.button1everythingBtn.TabIndex = 2;
            this.button1everythingBtn.Tag = "1";
            this.button1everythingBtn.Text = "Everything";
            this.btnToolTip.SetToolTip(this.button1everythingBtn, "Bagels of the category \'Everything\'.");
            this.button1everythingBtn.UseVisualStyleBackColor = true;
            this.button1everythingBtn.Click += new System.EventHandler(this.BagelTypeBtns_Click);
            // 
            // sizeSelectGroupBox
            // 
            this.sizeSelectGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sizeSelectGroupBox.Controls.Add(this.extraLargeSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.largeSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.regularSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.mediumSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.smallSizeBtn);
            this.sizeSelectGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeSelectGroupBox.Location = new System.Drawing.Point(570, 86);
            this.sizeSelectGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.sizeSelectGroupBox.Name = "sizeSelectGroupBox";
            this.sizeSelectGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.sizeSelectGroupBox.Size = new System.Drawing.Size(244, 153);
            this.sizeSelectGroupBox.TabIndex = 15;
            this.sizeSelectGroupBox.TabStop = false;
            this.sizeSelectGroupBox.Text = "Select Size";
            // 
            // extraLargeSizeBtn
            // 
            this.extraLargeSizeBtn.Location = new System.Drawing.Point(77, 115);
            this.extraLargeSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.extraLargeSizeBtn.Name = "extraLargeSizeBtn";
            this.extraLargeSizeBtn.Size = new System.Drawing.Size(91, 35);
            this.extraLargeSizeBtn.TabIndex = 4;
            this.extraLargeSizeBtn.Tag = "4";
            this.extraLargeSizeBtn.Text = "Extra-Large";
            this.btnToolTip.SetToolTip(this.extraLargeSizeBtn, "Extra-Large size bagels.");
            this.extraLargeSizeBtn.UseVisualStyleBackColor = true;
            this.extraLargeSizeBtn.Click += new System.EventHandler(this.BagelSizeBtns_Click);
            // 
            // largeSizeBtn
            // 
            this.largeSizeBtn.Location = new System.Drawing.Point(133, 72);
            this.largeSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.largeSizeBtn.Name = "largeSizeBtn";
            this.largeSizeBtn.Size = new System.Drawing.Size(91, 35);
            this.largeSizeBtn.TabIndex = 3;
            this.largeSizeBtn.Tag = "3";
            this.largeSizeBtn.Text = "Large";
            this.btnToolTip.SetToolTip(this.largeSizeBtn, "Large size bagels.");
            this.largeSizeBtn.UseVisualStyleBackColor = true;
            this.largeSizeBtn.Click += new System.EventHandler(this.BagelSizeBtns_Click);
            // 
            // regularSizeBtn
            // 
            this.regularSizeBtn.Location = new System.Drawing.Point(20, 72);
            this.regularSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.regularSizeBtn.Name = "regularSizeBtn";
            this.regularSizeBtn.Size = new System.Drawing.Size(91, 35);
            this.regularSizeBtn.TabIndex = 2;
            this.regularSizeBtn.Tag = "2";
            this.regularSizeBtn.Text = "Regular";
            this.btnToolTip.SetToolTip(this.regularSizeBtn, "Regular size bagels.");
            this.regularSizeBtn.UseVisualStyleBackColor = true;
            this.regularSizeBtn.Click += new System.EventHandler(this.BagelSizeBtns_Click);
            // 
            // mediumSizeBtn
            // 
            this.mediumSizeBtn.Location = new System.Drawing.Point(133, 25);
            this.mediumSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mediumSizeBtn.Name = "mediumSizeBtn";
            this.mediumSizeBtn.Size = new System.Drawing.Size(91, 35);
            this.mediumSizeBtn.TabIndex = 1;
            this.mediumSizeBtn.Tag = "1";
            this.mediumSizeBtn.Text = "Medium";
            this.btnToolTip.SetToolTip(this.mediumSizeBtn, "Medium size bagels.");
            this.mediumSizeBtn.UseVisualStyleBackColor = true;
            this.mediumSizeBtn.Click += new System.EventHandler(this.BagelSizeBtns_Click);
            // 
            // smallSizeBtn
            // 
            this.smallSizeBtn.Location = new System.Drawing.Point(20, 25);
            this.smallSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.smallSizeBtn.Name = "smallSizeBtn";
            this.smallSizeBtn.Size = new System.Drawing.Size(91, 35);
            this.smallSizeBtn.TabIndex = 0;
            this.smallSizeBtn.Tag = "0";
            this.smallSizeBtn.Text = "Small";
            this.btnToolTip.SetToolTip(this.smallSizeBtn, "Small size bagels.");
            this.smallSizeBtn.UseVisualStyleBackColor = true;
            this.smallSizeBtn.Click += new System.EventHandler(this.BagelSizeBtns_Click);
            // 
            // orderDetailsGroupBox
            // 
            this.orderDetailsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderDetailsGroupBox.Controls.Add(this.removeBtn);
            this.orderDetailsGroupBox.Controls.Add(this.orderBtn);
            this.orderDetailsGroupBox.Controls.Add(this.ItemGroupBox);
            this.orderDetailsGroupBox.Controls.Add(this.clearBtn);
            this.orderDetailsGroupBox.Controls.Add(this.addToCartBtn);
            this.orderDetailsGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.orderDetailsGroupBox.Controls.Add(this.totalDisplayLabel);
            this.orderDetailsGroupBox.Controls.Add(this.priceDisplayLabel);
            this.orderDetailsGroupBox.Controls.Add(this.totalLabel);
            this.orderDetailsGroupBox.Controls.Add(this.quantityLabel);
            this.orderDetailsGroupBox.Controls.Add(this.priceLabel);
            this.orderDetailsGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsGroupBox.Location = new System.Drawing.Point(14, 260);
            this.orderDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderDetailsGroupBox.Name = "orderDetailsGroupBox";
            this.orderDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.orderDetailsGroupBox.Size = new System.Drawing.Size(625, 189);
            this.orderDetailsGroupBox.TabIndex = 16;
            this.orderDetailsGroupBox.TabStop = false;
            this.orderDetailsGroupBox.Text = "Order Details";
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(265, 141);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 21);
            this.removeBtn.TabIndex = 27;
            this.removeBtn.Text = "R&emove Item";
            this.btnToolTip.SetToolTip(this.removeBtn, "Press the \"Remove Item\" button to delete selected item from cart.");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            this.orderBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderBtn.Location = new System.Drawing.Point(486, 141);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(135, 44);
            this.orderBtn.TabIndex = 26;
            this.orderBtn.Text = "&Order Complete";
            this.btnToolTip.SetToolTip(this.orderBtn, "Press the \"Order Complete\" button to process the order completion and checkout th" +
        "e user receipt.");
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.FormattingEnabled = true;
            this.ItemGroupBox.ItemHeight = 15;
            this.ItemGroupBox.Location = new System.Drawing.Point(265, 13);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(356, 124);
            this.ItemGroupBox.TabIndex = 17;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(363, 141);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(68, 21);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "&Clear";
            this.btnToolTip.SetToolTip(this.clearBtn, "Press Clear button to take new order");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addToCartBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Location = new System.Drawing.Point(85, 125);
            this.addToCartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(166, 37);
            this.addToCartBtn.TabIndex = 24;
            this.addToCartBtn.Text = "&Add to Cart";
            this.btnToolTip.SetToolTip(this.addToCartBtn, "Press the \"Add to Cart button\" to add the chosen bagel quantity to your cart.");
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(85, 57);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(166, 21);
            this.quantityNumericUpDown.TabIndex = 23;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalDisplayLabel.Location = new System.Drawing.Point(85, 90);
            this.totalDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(166, 19);
            this.totalDisplayLabel.TabIndex = 22;
            // 
            // priceDisplayLabel
            // 
            this.priceDisplayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceDisplayLabel.Location = new System.Drawing.Point(85, 28);
            this.priceDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceDisplayLabel.Name = "priceDisplayLabel";
            this.priceDisplayLabel.Size = new System.Drawing.Size(166, 19);
            this.priceDisplayLabel.TabIndex = 21;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(34, 90);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 15);
            this.totalLabel.TabIndex = 20;
            this.totalLabel.Text = "Total";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(21, 59);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(54, 15);
            this.quantityLabel.TabIndex = 19;
            this.quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(32, 28);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Price";
            // 
            // saleReportBtn
            // 
            this.saleReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saleReportBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReportBtn.Location = new System.Drawing.Point(668, 267);
            this.saleReportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saleReportBtn.Name = "saleReportBtn";
            this.saleReportBtn.Size = new System.Drawing.Size(108, 34);
            this.saleReportBtn.TabIndex = 28;
            this.saleReportBtn.Text = "Sale &Report";
            this.btnToolTip.SetToolTip(this.saleReportBtn, "Press the sale report button to show the compnay\'s sales report.");
            this.saleReportBtn.UseVisualStyleBackColor = true;
            this.saleReportBtn.Click += new System.EventHandler(this.saleReportBtn_Click);
            // 
            // stockToFileBtn
            // 
            this.stockToFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stockToFileBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToFileBtn.Location = new System.Drawing.Point(668, 322);
            this.stockToFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stockToFileBtn.Name = "stockToFileBtn";
            this.stockToFileBtn.Size = new System.Drawing.Size(108, 34);
            this.stockToFileBtn.TabIndex = 29;
            this.stockToFileBtn.Text = "&Stock To File";
            this.btnToolTip.SetToolTip(this.stockToFileBtn, "Press the \"Save To File\" button to save the current stock state to the file. ");
            this.stockToFileBtn.UseVisualStyleBackColor = true;
            this.stockToFileBtn.Click += new System.EventHandler(this.stockToFileBtn_Click);
            // 
            // searchTrxGroupBox
            // 
            this.searchTrxGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchTrxGroupBox.Controls.Add(this.clearSearchBtn);
            this.searchTrxGroupBox.Controls.Add(this.searchBtn);
            this.searchTrxGroupBox.Controls.Add(this.searchInputTextBox);
            this.searchTrxGroupBox.Controls.Add(this.transactionNoRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.dateRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.searchResultLabel);
            this.searchTrxGroupBox.Controls.Add(this.searchResultListBox);
            this.searchTrxGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTrxGroupBox.Location = new System.Drawing.Point(14, 453);
            this.searchTrxGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTrxGroupBox.Name = "searchTrxGroupBox";
            this.searchTrxGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchTrxGroupBox.Size = new System.Drawing.Size(625, 220);
            this.searchTrxGroupBox.TabIndex = 30;
            this.searchTrxGroupBox.TabStop = false;
            this.searchTrxGroupBox.Text = "Search transactions";
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearSearchBtn.Location = new System.Drawing.Point(367, 191);
            this.clearSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(72, 25);
            this.clearSearchBtn.TabIndex = 33;
            this.clearSearchBtn.Text = "&C&lear";
            this.btnToolTip.SetToolTip(this.clearSearchBtn, "Press Clear Button to clear the transaction box of all the data currently shown.");
            this.clearSearchBtn.UseVisualStyleBackColor = true;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBtn.Location = new System.Drawing.Point(367, 168);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(72, 23);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Searc&h";
            this.btnToolTip.SetToolTip(this.searchBtn, "Press the Search Button to search Transactions.");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInputTextBox
            // 
            this.searchInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchInputTextBox.Location = new System.Drawing.Point(186, 143);
            this.searchInputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchInputTextBox.Name = "searchInputTextBox";
            this.searchInputTextBox.Size = new System.Drawing.Size(253, 21);
            this.searchInputTextBox.TabIndex = 32;
            this.searchInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInputTextBox_KeyDown);
            // 
            // transactionNoRadioButton
            // 
            this.transactionNoRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.transactionNoRadioButton.AutoSize = true;
            this.transactionNoRadioButton.Location = new System.Drawing.Point(186, 168);
            this.transactionNoRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.transactionNoRadioButton.Name = "transactionNoRadioButton";
            this.transactionNoRadioButton.Size = new System.Drawing.Size(110, 19);
            this.transactionNoRadioButton.TabIndex = 31;
            this.transactionNoRadioButton.TabStop = true;
            this.transactionNoRadioButton.Text = "&Transaction No";
            this.btnToolTip.SetToolTip(this.transactionNoRadioButton, "Search on the base of transaction id.");
            this.transactionNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Location = new System.Drawing.Point(186, 191);
            this.dateRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(134, 19);
            this.dateRadioButton.TabIndex = 30;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "&Date (MM-DD-YYYY)";
            this.btnToolTip.SetToolTip(this.dateRadioButton, "search on the base of date.");
            this.dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(388, 10);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(50, 15);
            this.searchResultLabel.TabIndex = 29;
            this.searchResultLabel.Text = "Results";
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 15;
            this.searchResultListBox.Location = new System.Drawing.Point(82, 27);
            this.searchResultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(461, 109);
            this.searchResultListBox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(31)))), ((int)(((byte)(101)))));
            this.panel1.Location = new System.Drawing.Point(646, 267);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 406);
            this.panel1.TabIndex = 31;
            // 
            // extraImagePictureBox
            // 
            this.extraImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.extraImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("extraImagePictureBox.Image")));
            this.extraImagePictureBox.Location = new System.Drawing.Point(665, 459);
            this.extraImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.extraImagePictureBox.Name = "extraImagePictureBox";
            this.extraImagePictureBox.Size = new System.Drawing.Size(118, 126);
            this.extraImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraImagePictureBox.TabIndex = 32;
            this.extraImagePictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(706, 639);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 34);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "E&xit";
            this.btnToolTip.SetToolTip(this.exitBtn, "Press to exit the application.");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // btnToolTip
            // 
            this.btnToolTip.IsBalloon = true;
            this.btnToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.btnToolTip.ToolTipTitle = "Info";
            // 
            // MyBagelShopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(840, 686);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.extraImagePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTrxGroupBox);
            this.Controls.Add(this.stockToFileBtn);
            this.Controls.Add(this.saleReportBtn);
            this.Controls.Add(this.orderDetailsGroupBox);
            this.Controls.Add(this.sizeSelectGroupBox);
            this.Controls.Add(this.selectBagelgroupBox);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(856, 712);
            this.Name = "MyBagelShopApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBagelShop Inc.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyBagelShopApp_FormClosing);
            this.Load += new System.EventHandler(this.MyBagelShopApp_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.selectBagelgroupBox.ResumeLayout(false);
            this.sizeSelectGroupBox.ResumeLayout(false);
            this.orderDetailsGroupBox.ResumeLayout(false);
            this.orderDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.searchTrxGroupBox.ResumeLayout(false);
            this.searchTrxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button wholeWheatBtn;
        private System.Windows.Forms.GroupBox selectBagelgroupBox;
        private System.Windows.Forms.Button saltBtn;
        private System.Windows.Forms.Button cheddarBtn;
        private System.Windows.Forms.Button sesameBtn;
        private System.Windows.Forms.Button garlicBtn;
        private System.Windows.Forms.Button eggBtn;
        private System.Windows.Forms.Button frenchToastBtn;
        private System.Windows.Forms.Button poppySeedBtn;
        private System.Windows.Forms.Button asiagoBtn;
        private System.Windows.Forms.Button onionBtn;
        private System.Windows.Forms.Button chocolateChipBtn;
        private System.Windows.Forms.Button blueberryBtn;
        private System.Windows.Forms.Button button1everythingBtn;
        private System.Windows.Forms.GroupBox sizeSelectGroupBox;
        private System.Windows.Forms.Button extraLargeSizeBtn;
        private System.Windows.Forms.Button largeSizeBtn;
        private System.Windows.Forms.Button regularSizeBtn;
        private System.Windows.Forms.Button mediumSizeBtn;
        private System.Windows.Forms.Button smallSizeBtn;
        private System.Windows.Forms.GroupBox orderDetailsGroupBox;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.Label priceDisplayLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button saleReportBtn;
        private System.Windows.Forms.Button stockToFileBtn;
        private System.Windows.Forms.GroupBox searchTrxGroupBox;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchInputTextBox;
        private System.Windows.Forms.RadioButton transactionNoRadioButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox extraImagePictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip btnToolTip;
        private System.Windows.Forms.ListBox ItemGroupBox;
    }
}

