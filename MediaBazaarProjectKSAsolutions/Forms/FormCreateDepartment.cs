using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormCreateDepartment : Form
    {
        public FormCreateDepartment()
        {
            InitializeComponent();
        }

        private void btnAddDepartmentConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
