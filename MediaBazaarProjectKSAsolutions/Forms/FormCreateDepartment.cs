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
    public partial class FormCreateDepartment : Form
    {
        DepartmentManagement dep = new DepartmentManagement();
        public FormCreateDepartment()
        {
            InitializeComponent();
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void btnAddDepartmentConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                string name = tbxNewDepartmentName.Text;
                Status status = (Status)cbStatus.SelectedItem;
                
               
                Department department = new Department();
                if (department.Name == "")
                {
                    MessageBox.Show("Please input proper values");
                }
                else
                {
                    dep.AddDepartment(department);
                    MessageBox.Show("Department has been added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }
    }
}
