using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetrolBunkManagement.src;
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
            this.Text = "my page";
        }
        private void Exit_tab_Click(object sender, EventArgs e)
        {
            cUtility lutil = new cUtility();
            lutil.shutdown(this);  
        }

        private void Reports_tab_Click(object sender, EventArgs e)
        {

        }

    }
}
