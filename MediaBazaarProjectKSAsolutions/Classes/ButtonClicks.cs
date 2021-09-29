using System;
using MediaBazaarProjectKSAsolutions.Classes;
using System.Collections.Generic;
using System.Text;
using MediaBazaarProjectKSAsolutions.Forms;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class ButtonClicks
    {
        public void btnEmployee(User loggedIn)
        {
            FormEmployee formEmployee = new FormEmployee(loggedIn);
            formEmployee.Show();
        }
        public void btnStock(User loggedIn)
        {
            FormStock formStock = new FormStock(loggedIn);
            formStock.Show();
        }
        public void btnDepartment(User loggedIn)
        {
            FormDepartment formDepartment = new FormDepartment(loggedIn);
            formDepartment.Show();
        }
        public void btnSchedule(User loggedIn)
        {
            //FormEmployee formEmployee = new FormEmployee(loggedIn);
            //formEmployee.Show();
        }
        public void btnStatistics(User loggedIn)
        {
            //FormEmployee formEmployee = new FormEmployee(loggedIn);
            //formEmployee.Show();
        }
        public void btnLogout(User loggedIn)
        {
            FormEmployee formEmployee = new FormEmployee(loggedIn);
            formEmployee.Show();
        }

    }
}
