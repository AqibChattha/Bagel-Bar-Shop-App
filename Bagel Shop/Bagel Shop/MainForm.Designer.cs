namespace Bagel_Shop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContant = new System.Windows.Forms.Panel();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlMenu1 = new System.Windows.Forms.Panel();
            this.pnlSubMenuEvaluation = new System.Windows.Forms.Panel();
            this.btnSaveStocksData = new System.Windows.Forms.Button();
            this.btnSalesPerItem = new System.Windows.Forms.Button();
            this.pnlShowCliked = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenuBottomMargin = new System.Windows.Forms.Panel();
            this.btnSellerDashboard = new System.Windows.Forms.Button();
            this.pnlMenuLogo = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.pnlMenu1.SuspendLayout();
            this.pnlSubMenuEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContant);
            this.pnlMain.Controls.Add(this.pnlSideMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1074, 621);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContant
            // 
            this.pnlContant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContant.Location = new System.Drawing.Point(234, 0);
            this.pnlContant.Name = "pnlContant";
            this.pnlContant.Size = new System.Drawing.Size(840, 621);
            this.pnlContant.TabIndex = 1;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideMenu.Controls.Add(this.pnlMenu1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(234, 621);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.AutoScroll = true;
            this.pnlMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.pnlMenu1.Controls.Add(this.pnlSubMenuEvaluation);
            this.pnlMenu1.Controls.Add(this.pnlShowCliked);
            this.pnlMenu1.Controls.Add(this.btnSummary);
            this.pnlMenu1.Controls.Add(this.btnTransactions);
            this.pnlMenu1.Controls.Add(this.btnExit);
            this.pnlMenu1.Controls.Add(this.pnlMenuBottomMargin);
            this.pnlMenu1.Controls.Add(this.btnSellerDashboard);
            this.pnlMenu1.Controls.Add(this.pnlMenuLogo);
            this.pnlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu1.Name = "pnlMenu1";
            this.pnlMenu1.Size = new System.Drawing.Size(234, 621);
            this.pnlMenu1.TabIndex = 0;
            // 
            // pnlSubMenuEvaluation
            // 
            this.pnlSubMenuEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.pnlSubMenuEvaluation.Controls.Add(this.btnSaveStocksData);
            this.pnlSubMenuEvaluation.Controls.Add(this.btnSalesPerItem);
            this.pnlSubMenuEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEvaluation.Location = new System.Drawing.Point(0, 309);
            this.pnlSubMenuEvaluation.Name = "pnlSubMenuEvaluation";
            this.pnlSubMenuEvaluation.Size = new System.Drawing.Size(234, 84);
            this.pnlSubMenuEvaluation.TabIndex = 5;
            // 
            // btnSaveStocksData
            // 
            this.btnSaveStocksData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveStocksData.FlatAppearance.BorderSize = 0;
            this.btnSaveStocksData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStocksData.ForeColor = System.Drawing.Color.White;
            this.btnSaveStocksData.Location = new System.Drawing.Point(0, 42);
            this.btnSaveStocksData.Name = "btnSaveStocksData";
            this.btnSaveStocksData.Size = new System.Drawing.Size(234, 42);
            this.btnSaveStocksData.TabIndex = 1;
            this.btnSaveStocksData.Text = "Save Stocks Data";
            this.btnSaveStocksData.UseVisualStyleBackColor = true;
            // 
            // btnSalesPerItem
            // 
            this.btnSalesPerItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesPerItem.FlatAppearance.BorderSize = 0;
            this.btnSalesPerItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesPerItem.ForeColor = System.Drawing.Color.White;
            this.btnSalesPerItem.Location = new System.Drawing.Point(0, 0);
            this.btnSalesPerItem.Name = "btnSalesPerItem";
            this.btnSalesPerItem.Size = new System.Drawing.Size(234, 42);
            this.btnSalesPerItem.TabIndex = 0;
            this.btnSalesPerItem.Text = "Sales Per Item";
            this.btnSalesPerItem.UseVisualStyleBackColor = true;
            this.btnSalesPerItem.Click += new System.EventHandler(this.btnSalesPerItem_Click);
            // 
            // pnlShowCliked
            // 
            this.pnlShowCliked.BackColor = System.Drawing.Color.White;
            this.pnlShowCliked.Location = new System.Drawing.Point(0, 183);
            this.pnlShowCliked.Name = "pnlShowCliked";
            this.pnlShowCliked.Size = new System.Drawing.Size(2, 42);
            this.pnlShowCliked.TabIndex = 1;
            // 
            // btnSummary
            // 
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnSummary.Image")));
            this.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.Location = new System.Drawing.Point(0, 267);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(234, 42);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = " Summary";
            this.btnSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnEvaluations_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(0, 225);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(234, 42);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = " Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 569);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenuBottomMargin
            // 
            this.pnlMenuBottomMargin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.pnlMenuBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenuBottomMargin.Location = new System.Drawing.Point(0, 611);
            this.pnlMenuBottomMargin.Name = "pnlMenuBottomMargin";
            this.pnlMenuBottomMargin.Size = new System.Drawing.Size(234, 10);
            this.pnlMenuBottomMargin.TabIndex = 5;
            // 
            // btnSellerDashboard
            // 
            this.btnSellerDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellerDashboard.FlatAppearance.BorderSize = 0;
            this.btnSellerDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellerDashboard.ForeColor = System.Drawing.Color.White;
            this.btnSellerDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnSellerDashboard.Image")));
            this.btnSellerDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellerDashboard.Location = new System.Drawing.Point(0, 183);
            this.btnSellerDashboard.Name = "btnSellerDashboard";
            this.btnSellerDashboard.Size = new System.Drawing.Size(234, 42);
            this.btnSellerDashboard.TabIndex = 0;
            this.btnSellerDashboard.Text = "  Seller Dashboard";
            this.btnSellerDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellerDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellerDashboard.UseVisualStyleBackColor = true;
            this.btnSellerDashboard.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // pnlMenuLogo
            // 
            this.pnlMenuLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenuLogo.BackgroundImage")));
            this.pnlMenuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLogo.Name = "pnlMenuLogo";
            this.pnlMenuLogo.Size = new System.Drawing.Size(234, 183);
            this.pnlMenuLogo.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1074, 621);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bagel Shop";
            this.pnlMain.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlMenu1.ResumeLayout(false);
            this.pnlSubMenuEvaluation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlMenu1;
        private System.Windows.Forms.Panel pnlSubMenuEvaluation;
        private System.Windows.Forms.Button btnSaveStocksData;
        private System.Windows.Forms.Button btnSalesPerItem;
        private System.Windows.Forms.Panel pnlShowCliked;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuBottomMargin;
        private System.Windows.Forms.Button btnSellerDashboard;
        private System.Windows.Forms.Panel pnlMenuLogo;
        private System.Windows.Forms.Panel pnlContant;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

