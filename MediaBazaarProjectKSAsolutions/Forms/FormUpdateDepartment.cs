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
        public FormUpdateDepartment(Department department)
        {
            InitializeComponent();
            this.dep = department;
            depM = new DepartmentManagement();
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void btnUpdateDepartmentConfirmation_Click(object sender, EventArgs e)
        {
            try
            {

                dep.Name = tbxUpdateDepartmentName.Text;
                dep.Status = (Status)cbStatus.SelectedItem;

                depM.EditDepartment(dep);
                MessageBox.Show("You successfuly updated your department name");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            this.Close();

        }

        private void FormUpdateDepartment_Load(object sender, EventArgs e)
        {
            tbxUpdateDepartmentName.Text = dep.Name;
            cbStatus.Text = dep.Status.ToString();
        }
    }
}
