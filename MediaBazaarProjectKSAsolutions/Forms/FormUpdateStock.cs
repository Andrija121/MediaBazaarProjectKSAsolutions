using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormUpdateStock : Form
    {
        public FormUpdateStock()
        {
            InitializeComponent();
        }

        private void btnUpdateStockConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
