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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vATCate_lookup_DataSet.VAT_category_table' table. You can move, or remove it, as needed.
            this.vAT_category_tableTableAdapter.Fill(this.vATCate_lookup_DataSet.VAT_category_table);
            // TODO: This line of code loads data into the 'category_LookUpDataSet.ItemCategory_table' table. You can move, or remove it, as needed.
            this.itemCategory_tableTableAdapter.Fill(this.category_LookUpDataSet.ItemCategory_table);
           
            // TODO: This line of code loads data into the 'productDetails_DataSet.Items_table' table. You can move, or remove it, as needed.
            this.items_tableTableAdapter.Fill(this.productDetails_DataSet.Items_table);
     
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           /* try {
            this.Validate();
            this.items_tableBindingSource.EndEdit();
            this.vATcategorytableBindingSource.EndEdit();
            this.itemCategorytableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemDataSet);
            MessageBox.Show("Update Success ");
                }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed " + ex.ToString());
            }
            */
        }

        private void items_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      

        }

        private void items_tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.items_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDetails_DataSet);

        }
    }
}
