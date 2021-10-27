﻿using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class EditUserForm : Form
    {
        User u;
        UserManagement um;
        public EditUserForm(User user)
        {
            InitializeComponent();
            this.u = user;
            um = new UserManagement();
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
            cbContractType.DataSource = Enum.GetValues(typeof(ContractType));
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                u.UserName = tbUserName.Text;
                u.FirstName = tbFirstName.Text;
                u.LastName = tbLastName.Text;
                u.Email = tbEmail.Text;
                u.Birtyhday = DTPBirthday.Value;
                u.BSN = Convert.ToInt32(tbBSN.Text);
                u.ZipCode = tbZipCode.Text;
                u.Address = tbAddress.Text;
                u.Gender = (Gender)cbGender.SelectedItem;
                u.Role = (Role)cbRole.SelectedItem;
                u.Status = (Status)cbStatus.SelectedItem;

                if (u.Password == null || u.UserName == null || u.BSN.ToString() == null || u.FirstName == null || u.LastName == null)
                {
                    MessageBox.Show("Input value is not correct");
                }
                else
                {
                    um.EditUser(u);
                    MessageBox.Show("Successfully Edited User");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ex);
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {   
                tbUserName.Text = u.UserName;
                tbFirstName.Text = u.FirstName;
                tbLastName.Text = u.LastName;
                tbEmail.Text = u.Email;
                tbPassword.Text = u.Password;
                DTPBirthday.Value = u.Birtyhday;
                tbBSN.Text = u.BSN.ToString();
                tbZipCode.Text = u.ZipCode;
                tbAddress.Text = u.Address;
                cbGender.SelectedItem = u.Gender;
                cbRole.SelectedItem = u.Role;
                cbStatus.SelectedItem = u.Status;
                Contract contract = um.GetContract(u.Id);
                StartDatedateTimePicker.Value = contract.StartDate;
                EndDatedateTimePicker.Value = contract.EndDate;
                cbContractType.SelectedItem = contract.ContractType;
                tbSalaryPH.Text = contract.SalaryPerHour.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
