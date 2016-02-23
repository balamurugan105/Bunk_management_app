using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolBunkManagement.AppForms
{
    public partial class HomePage : Form
    {
        private string mUserName;
        public HomePage()
        {
            InitializeComponent();            
        }
      /*  private void HomePage_Load(object sender, EventArgs e)
        {

        }*/
        public HomePage(string iUsrName)
        {
            InitializeComponent();
            mUserName = iUsrName;            
        }
        private void Home_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want close Bunk management",
                        "Confirm Exit ", MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Program.ExitApp();
            }
            else
            {
                this.Show();
            }
        }

    }
}
