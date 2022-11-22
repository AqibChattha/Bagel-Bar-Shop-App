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
    public partial class ucSell : UserControl
    {
        private static ucSell _instence;
        public static ucSell Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucSell();
                }
                return _instence;
            }
        }
        private ucSell()
        {
            InitializeComponent();
        }
    }
}
