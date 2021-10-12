using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class InactiveDepartmentsForm : Form
    {
        DepartmentManagement dm;
        public InactiveDepartmentsForm()
        {
            InitializeComponent();
            dm = new DepartmentManagement();
        }

        private void InactiveDepartmentsForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            lbInactiveUsers.Items.Clear();
            foreach (var d in dm.GetInactiveDepartments())
            {
                lbInactiveUsers.Items.Add(d);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
