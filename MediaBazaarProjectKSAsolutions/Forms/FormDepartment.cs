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
        DepartmentManagement dm = new DepartmentManagement();
        public FormDepartment()
        {
            InitializeComponent();
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
            formCreateDepartment.ShowDialog();
            RefreshListBox();
        }

        private void btnEditDepartments_Click(object sender, EventArgs e)
        {
            Department department = (Department)lbDepartments.SelectedItem;
            FormUpdateDepartment formUpdateDepartment = new FormUpdateDepartment(department);
            formUpdateDepartment.Show();
            RefreshListBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnRefreshDepartments_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void btnDelDepartment_Click(object sender, EventArgs e)
        {
            Department department = (Department)lbDepartments.SelectedItem;
            dm.DeleteDepartment(department.Id);
            MessageBox.Show("Department Delted Successfully");
            RefreshListBox();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }
    }
}
