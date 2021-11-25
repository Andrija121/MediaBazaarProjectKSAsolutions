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
    public partial class AddUserForm : Form
    {

        UserManagement um;
        DepartmentManagement dm;
        
        public AddUserForm()
        {
            InitializeComponent();
            um = new UserManagement();
            dm = new DepartmentManagement();
            
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
            cbContractType.DataSource = Enum.GetValues(typeof(ContractType));
            PopulateCBDepartments();
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
              
                string userName = tbUserName.Text;
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                DateTime birthday = DTPBirthday.Value;
                int bsn = Convert.ToInt32(tbBSN.Text);
                string zipCode = tbZipCode.Text;
                string address = tbAddress.Text;
                Gender gender = (Gender)cbGender.SelectedItem;
                Role role = (Role)cbRole.SelectedItem;
                Status status = (Status)cbStatus.SelectedItem;
                Department department = (Department)cbDepartments.SelectedItem;
                DateTime startDate = StartDatedateTimePicker.Value;
                DateTime endDate = EndDatedateTimePicker.Value;
                double salaryPH = Convert.ToDouble(tbSalaryPH.Text);
                ContractType contractType = (ContractType)cbContractType.SelectedItem;
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(bsn.ToString()))
                {
                    MessageBox.Show("Fields are empty");

                }
                else if (um.CheckIfUserAlreadyExist(userName, email, bsn))
                {
                    MessageBox.Show("Values already exist");
                }
                else
                {
                    if (startDate >= endDate)
                    {
                        MessageBox.Show("Please Select proper values for contract");
                    }
                    else
                    {
                        Contract contract = new Contract(0, startDate, endDate, contractType, salaryPH);
                        User user = new User(0, userName, firstName, lastName, email, password, birthday, bsn, zipCode, address, contract, gender, role, status,department);
                        int id = um.AddUser(user);
                        MessageBox.Show("User Created Successfully");
                        um.AssignContractToUser(contract, id);
                        MessageBox.Show("Contract Made Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in all the values " + ex.Message);
            }
        }

        private void PopulateCBDepartments()
        {
            List<Department> departments = dm.GetActiveDepartments();
            foreach (var d in departments)
            {
                cbDepartments.Items.Add(d);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
