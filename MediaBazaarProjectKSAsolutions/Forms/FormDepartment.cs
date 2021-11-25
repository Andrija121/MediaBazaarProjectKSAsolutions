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
        User u;
        DepartmentManagement dm = new DepartmentManagement();
        public FormDepartment(User user)
        {
            this.u = user;
            InitializeComponent();
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            lbDepartments.Items.Clear();
            foreach (var d in dm.GetActiveDepartments())
            {
                d.Department_Manager = u;
                lbDepartments.Items.Add(d);
            }
            

        }
        private void btnCreateDepartments_Click(object sender, EventArgs e)
        {
            FormCreateDepartment formCreateDepartment = new FormCreateDepartment(u);
            formCreateDepartment.ShowDialog();
            RefreshListBox();
        }

        private void btnEditDepartments_Click(object sender, EventArgs e)
        {
            Department department = (Department)lbDepartments.SelectedItem;
            if(department==null)
            {
                MessageBox.Show("Please select department");
            }
            else 
            {
                FormUpdateDepartment formUpdateDepartment = new FormUpdateDepartment(department);
                formUpdateDepartment.Show();
                RefreshListBox();
            }
            
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
            if (department == null)
            {
                MessageBox.Show("Please select department");
            }
            else
            {
                dm.SetDepartmentInactive(department);
                MessageBox.Show("Department Inactivated Successfully");
                RefreshListBox();
            }
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void btnSeeInactiveUsers_Click(object sender, EventArgs e)
        {
            InactiveDepartmentsForm inactiveDepartmentsForm = new InactiveDepartmentsForm();
            inactiveDepartmentsForm.ShowDialog();
        }

        private void pnlEmployees_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
