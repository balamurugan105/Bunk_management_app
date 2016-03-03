using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetrolBunkManagement.src;
using PetrolBunkManagement.src.DatabaseInterface;

namespace PetrolBunkManagement.AppForms
{
    public partial class HomePage : Form
    {        
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
            this.HomeForm_welcome_label.Text = "Welcome " + iUsrName;
            MSAccessDB lDBQuery = new MSAccessDB();
            if (lDBQuery.isReportsViewAllowed(iUsrName))
            {
                this.reportsToolStripMenuItem.Visible = true;
            }
            else
            {
                this.reportsToolStripMenuItem.Visible = false;
            }
        }
        private void Exit_tab_Click(object sender, EventArgs e)
        {           
                // your stuff
                cUtility lutil = new cUtility();
                lutil.shutdown(this);                
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Product_form lProductForm = new Product_form();            
            //lProductForm.Show();
            ProductForm lProdForm = new ProductForm();
            lProdForm.MdiParent = this;
            lProdForm.Show();
        }

        private void profitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
