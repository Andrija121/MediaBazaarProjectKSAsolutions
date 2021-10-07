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
    public partial class FormDepartment : Form
    {
        User user;
        DepartmentManagement dm;
        public FormDepartment()
        {
            InitializeComponent();
            dm = new DepartmentManagement();
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            lbDepartments.Items.Clear();
            foreach (var d in dm.GetDepartments())
            {
                lbDepartments.Items.Add(d);
            }
        }
        private void btnCreateDepartments_Click(object sender, EventArgs e)
        {
            FormCreateDepartment formCreateDepartment = new FormCreateDepartment();
            formCreateDepartment.Show();
        }

        private void btnEditDepartments_Click(object sender, EventArgs e)
        {
            FormUpdateDepartment formUpdateDepartment = new FormUpdateDepartment();
            formUpdateDepartment.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
