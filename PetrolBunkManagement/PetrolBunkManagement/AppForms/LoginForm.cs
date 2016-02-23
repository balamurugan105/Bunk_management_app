using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetrolBunkManagement.AppForms;
using PetrolBunkManagement.src.DatabaseInterface;

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
                Program.ExitApp();
            }
            else
            {
                this.Show();
            }
        }

        private void Login_but_Click(object sender, EventArgs e)
        {
            if (!ValidateCredentials())
            {
                MessageBox.Show("Invalid USER Name/ password");
                this.Show();
            }
            else
            {   // Load Homepage              
                HomePage lHomeForm = new HomePage(uname_box.Text);
                this.Hide();
                lHomeForm.Show();
            }
        }
        private bool ValidateCredentials()
        {
            //  string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Petrol_bunk\Software\project_1\Bunk_management\Bunk_management\bmanagdb.accdb"
            MSAccessDB lDBQuery = new MSAccessDB();            
            return lDBQuery.Login(uname_box.Text, pwd_box.Text);
        }

    }
}
