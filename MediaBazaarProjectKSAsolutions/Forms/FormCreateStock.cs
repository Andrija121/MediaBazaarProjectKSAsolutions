using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormCreateStock : Form
    {
        public FormCreateStock()
        {
            InitializeComponent();
        }

        private void btnAddStockConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
