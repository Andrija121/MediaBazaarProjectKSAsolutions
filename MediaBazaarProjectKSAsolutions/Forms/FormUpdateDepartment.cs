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
    public partial class FormUpdateDepartment : Form
    {
        Department dep; 
        DepartmentManagement depM;
        public FormUpdateDepartment()
        {
            
            InitializeComponent();
            Department dep = new Department();
            _ = new DepartmentManagement();
        }

        private void btnUpdateDepartmentConfirmation_Click(object sender, EventArgs e)
        {
            try
            {
                dep.Name = tbxUpdateDepartmentName.Text;
                depM.AddDepartment(dep);
                MessageBox.Show("You successfuly updated your department name");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            this.Close();

        }
    }
}
