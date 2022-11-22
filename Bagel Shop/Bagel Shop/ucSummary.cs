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
    public partial class ucSummary : UserControl
    {
        private static ucSummary _instence;
        public static ucSummary Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucSummary();
                }
                return _instence;
            }
        }
        
        private ucSummary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formSalesPerItem formSalesPerItem = new formSalesPerItem();
            formSalesPerItem.ShowDialog();
        }
    }
}
