using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MediaBazaarProjectKSAsolutions
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        UserManagement um = new UserManagement();
        public RadForm1()
        {
            InitializeComponent();
            
        }
    }
}
