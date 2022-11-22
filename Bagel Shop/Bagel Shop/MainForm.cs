using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagel_Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pnlSubMenuEvaluation.Visible = false;
            pnlContant.Controls.Add(ucSell.Instence);
            ucSell.Instence.Dock = DockStyle.Fill;
            ucSell.Instence.BringToFront();
        }

        private void hideSubMenu()
        {
            if (pnlSubMenuEvaluation.Visible == true)
            {
                pnlSubMenuEvaluation.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            pnlShowCliked.Height = btnSellerDashboard.Height;
            pnlShowCliked.Top = btnSellerDashboard.Top;
            if (pnlContant.Controls.Contains(ucSell.Instence))
            {
                pnlContant.Controls.Add(ucSell.Instence);
                ucSell.Instence.Dock = DockStyle.Fill;
                ucSell.Instence.BringToFront();
            }
            else
            {
                ucSell.Instence.BringToFront();
            }
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            pnlShowCliked.Height = btnTransactions.Height;
            pnlShowCliked.Top = btnTransactions.Top;
            if (!pnlContant.Controls.Contains(ucTransactions.Instence))
            {
                pnlContant.Controls.Add(ucTransactions.Instence);
                ucTransactions.Instence.Dock = DockStyle.Fill;
                ucTransactions.Instence.BringToFront();
            }
            else
            {
                ucTransactions.Instence.BringToFront();
            }
        }

        private void btnEvaluations_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuEvaluation);
            pnlShowCliked.Height = btnSummary.Height;
            pnlShowCliked.Top = btnSummary.Top;
            if (!pnlContant.Controls.Contains(ucSummary.Instence))
            {
                pnlContant.Controls.Add(ucSummary.Instence);
                ucSummary.Instence.Dock = DockStyle.Fill;
                ucSummary.Instence.BringToFront();
            }
            else
            {
                ucSummary.Instence.BringToFront();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalesPerItem_Click(object sender, EventArgs e)
        {
            formSalesPerItem formSalesPerItem = new formSalesPerItem();
            formSalesPerItem.ShowDialog();
        }
    }
}
