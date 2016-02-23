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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_exit_but_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(" Are you sure you want to exit",
                              "Exit", MessageBoxButtons.YesNoCancel,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {

            }
        }

        private void Login_but_Click(object sender, EventArgs e)
        {

        }
    }
}
