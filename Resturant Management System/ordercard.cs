using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Resturant_Management_System
{
    public partial class ordercard : UserControl
    {
        //Dashboard master = (Dashboard)Application.OpenForms["Dashboard"];

        public ordercard()
        {
            InitializeComponent();
        }

        public string Foodname
        {
            get { return itemname.Text; }
            set { itemname.Text = value; }
        }

        public string Qntity
        {
            get { return quentitylbl.Text; }
            set { quentitylbl.Text = value; }
        }

        public string Totprice
        {
            get { return pricelbl.Text; }
            set { pricelbl.Text = value; }
        }

        

    }
}
