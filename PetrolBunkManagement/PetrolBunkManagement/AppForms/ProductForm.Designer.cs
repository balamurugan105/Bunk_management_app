namespace PetrolBunkManagement.AppForms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemCategoryLabel;
            System.Windows.Forms.Label openingStockLabel;
            System.Windows.Forms.Label unitsLabel;
            System.Windows.Forms.Label mRPLabel;
            System.Windows.Forms.Label sellPriceLabel;
            System.Windows.Forms.Label buyPriceLabel;
            System.Windows.Forms.Label vAT_categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProductlistBox1 = new System.Windows.Forms.ListBox();
            this.items_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDetails_DataSet = new PetrolBunkManagement.DataSets.ProductDetails_DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Vat_Categ_link = new System.Windows.Forms.LinkLabel();
            this.Add_categ_link = new System.Windows.Forms.LinkLabel();
            this.items_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.items_tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Cate_LookupbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_LookUpDataSet = new PetrolBunkManagement.DataSets.Category_LookUpDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vATcategorytableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATCatelookupDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATCate_lookup_DataSet = new PetrolBunkManagement.DataSets.VATCate_lookup_DataSet();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.openingStockTextBox = new System.Windows.Forms.TextBox();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.mRPTextBox = new System.Windows.Forms.TextBox();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.buyPriceTextBox = new System.Windows.Forms.TextBox();
            this.items_tableTableAdapter = new PetrolBunkManagement.DataSets.ProductDetails_DataSetTableAdapters.Items_tableTableAdapter();
            this.tableAdapterManager = new PetrolBunkManagement.DataSets.ProductDetails_DataSetTableAdapters.TableAdapterManager();
            this.itemCategory_tableTableAdapter = new PetrolBunkManagement.DataSets.Category_LookUpDataSetTableAdapters.ItemCategory_tableTableAdapter();
            this.vAT_category_tableTableAdapter = new PetrolBunkManagement.DataSets.VATCate_lookup_DataSetTableAdapters.VAT_category_tableTableAdapter();
            itemNameLabel = new System.Windows.Forms.Label();
            itemCategoryLabel = new System.Windows.Forms.Label();
            openingStockLabel = new System.Windows.Forms.Label();
            unitsLabel = new System.Windows.Forms.Label();
            mRPLabel = new System.Windows.Forms.Label();
            sellPriceLabel = new System.Windows.Forms.Label();
            buyPriceLabel = new System.Windows.Forms.Label();
            vAT_categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetails_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_tableBindingNavigator)).BeginInit();
            this.items_tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cate_LookupbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_LookUpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATcategorytableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATCatelookupDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATCate_lookup_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemNameLabel.Location = new System.Drawing.Point(25, 33);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(84, 18);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemCategoryLabel
            // 
            itemCategoryLabel.AutoSize = true;
            itemCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemCategoryLabel.Location = new System.Drawing.Point(25, 59);
            itemCategoryLabel.Name = "itemCategoryLabel";
            itemCategoryLabel.Size = new System.Drawing.Size(104, 18);
            itemCategoryLabel.TabIndex = 2;
            itemCategoryLabel.Text = "Item Category:";
            // 
            // openingStockLabel
            // 
            openingStockLabel.AutoSize = true;
            openingStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openingStockLabel.Location = new System.Drawing.Point(25, 85);
            openingStockLabel.Name = "openingStockLabel";
            openingStockLabel.Size = new System.Drawing.Size(110, 18);
            openingStockLabel.TabIndex = 4;
            openingStockLabel.Text = "Opening Stock:";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitsLabel.Location = new System.Drawing.Point(25, 111);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(46, 18);
            unitsLabel.TabIndex = 6;
            unitsLabel.Text = "Units:";
            // 
            // mRPLabel
            // 
            mRPLabel.AutoSize = true;
            mRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mRPLabel.Location = new System.Drawing.Point(25, 137);
            mRPLabel.Name = "mRPLabel";
            mRPLabel.Size = new System.Drawing.Size(46, 18);
            mRPLabel.TabIndex = 8;
            mRPLabel.Text = "MRP:";
            // 
            // sellPriceLabel
            // 
            sellPriceLabel.AutoSize = true;
            sellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sellPriceLabel.Location = new System.Drawing.Point(25, 163);
            sellPriceLabel.Name = "sellPriceLabel";
            sellPriceLabel.Size = new System.Drawing.Size(74, 18);
            sellPriceLabel.TabIndex = 10;
            sellPriceLabel.Text = "Sell Price:";
            // 
            // buyPriceLabel
            // 
            buyPriceLabel.AutoSize = true;
            buyPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buyPriceLabel.Location = new System.Drawing.Point(25, 189);
            buyPriceLabel.Name = "buyPriceLabel";
            buyPriceLabel.Size = new System.Drawing.Size(75, 18);
            buyPriceLabel.TabIndex = 12;
            buyPriceLabel.Text = "Buy Price:";
            // 
            // vAT_categoryLabel
            // 
            vAT_categoryLabel.AutoSize = true;
            vAT_categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vAT_categoryLabel.Location = new System.Drawing.Point(25, 215);
            vAT_categoryLabel.Name = "vAT_categoryLabel";
            vAT_categoryLabel.Size = new System.Drawing.Size(100, 18);
            vAT_categoryLabel.TabIndex = 14;
            vAT_categoryLabel.Text = "VAT category:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProductlistBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(733, 472);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProductlistBox1
            // 
            this.ProductlistBox1.DataSource = this.items_tableBindingSource;
            this.ProductlistBox1.DisplayMember = "ItemName";
            this.ProductlistBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductlistBox1.FormattingEnabled = true;
            this.ProductlistBox1.Location = new System.Drawing.Point(0, 0);
            this.ProductlistBox1.Name = "ProductlistBox1";
            this.ProductlistBox1.Size = new System.Drawing.Size(225, 472);
            this.ProductlistBox1.TabIndex = 0;
            this.ProductlistBox1.ValueMember = "ID";
            // 
            // items_tableBindingSource
            // 
            this.items_tableBindingSource.DataMember = "Items_table";
            this.items_tableBindingSource.DataSource = this.productDetails_DataSet;
            // 
            // productDetails_DataSet
            // 
            this.productDetails_DataSet.DataSetName = "ProductDetails_DataSet";
            this.productDetails_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetrolBunkManagement.Properties.Resources.product;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(84, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Add_Vat_Categ_link);
            this.groupBox1.Controls.Add(this.Add_categ_link);
            this.groupBox1.Controls.Add(this.items_tableBindingNavigator);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Controls.Add(itemCategoryLabel);
            this.groupBox1.Controls.Add(openingStockLabel);
            this.groupBox1.Controls.Add(this.openingStockTextBox);
            this.groupBox1.Controls.Add(unitsLabel);
            this.groupBox1.Controls.Add(this.unitsTextBox);
            this.groupBox1.Controls.Add(mRPLabel);
            this.groupBox1.Controls.Add(this.mRPTextBox);
            this.groupBox1.Controls.Add(sellPriceLabel);
            this.groupBox1.Controls.Add(this.sellPriceTextBox);
            this.groupBox1.Controls.Add(buyPriceLabel);
            this.groupBox1.Controls.Add(this.buyPriceTextBox);
            this.groupBox1.Controls.Add(vAT_categoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // Add_Vat_Categ_link
            // 
            this.Add_Vat_Categ_link.AutoSize = true;
            this.Add_Vat_Categ_link.Location = new System.Drawing.Point(347, 226);
            this.Add_Vat_Categ_link.Name = "Add_Vat_Categ_link";
            this.Add_Vat_Categ_link.Size = new System.Drawing.Size(103, 15);
            this.Add_Vat_Categ_link.TabIndex = 18;
            this.Add_Vat_Categ_link.TabStop = true;
            this.Add_Vat_Categ_link.Text = "Add VAT Category";
            this.Add_Vat_Categ_link.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Add_categ_link
            // 
            this.Add_categ_link.AutoSize = true;
            this.Add_categ_link.Location = new System.Drawing.Point(347, 90);
            this.Add_categ_link.Name = "Add_categ_link";
            this.Add_categ_link.Size = new System.Drawing.Size(79, 15);
            this.Add_categ_link.TabIndex = 17;
            this.Add_categ_link.TabStop = true;
            this.Add_categ_link.Text = "Add Category";
            this.Add_categ_link.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // items_tableBindingNavigator
            // 
            this.items_tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.items_tableBindingNavigator.BindingSource = this.items_tableBindingSource;
            this.items_tableBindingNavigator.CountItem = null;
            this.items_tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.items_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.items_tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.items_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.items_tableBindingNavigatorSaveItem});
            this.items_tableBindingNavigator.Location = new System.Drawing.Point(3, 263);
            this.items_tableBindingNavigator.MoveFirstItem = null;
            this.items_tableBindingNavigator.MoveLastItem = null;
            this.items_tableBindingNavigator.MoveNextItem = null;
            this.items_tableBindingNavigator.MovePreviousItem = null;
            this.items_tableBindingNavigator.Name = "items_tableBindingNavigator";
            this.items_tableBindingNavigator.PositionItem = null;
            this.items_tableBindingNavigator.Size = new System.Drawing.Size(462, 32);
            this.items_tableBindingNavigator.TabIndex = 1;
            this.items_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::PetrolBunkManagement.Properties.Resources.add_button_new_edit_car_plus_green_equal1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(92, 29);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::PetrolBunkManagement.Properties.Resources._120px_Crystal_Clear_action_button_cancel;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(77, 29);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // items_tableBindingNavigatorSaveItem
            // 
            this.items_tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("items_tableBindingNavigatorSaveItem.Image")));
            this.items_tableBindingNavigatorSaveItem.Name = "items_tableBindingNavigatorSaveItem";
            this.items_tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(99, 29);
            this.items_tableBindingNavigatorSaveItem.Text = "Save Data";
            this.items_tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.items_tableBindingNavigatorSaveItem_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.items_tableBindingSource, "ItemCategory", true));
            this.comboBox2.DataSource = this.Cate_LookupbindingSource;
            this.comboBox2.DisplayMember = "Category";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 26);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "ID";
            // 
            // Cate_LookupbindingSource
            // 
            this.Cate_LookupbindingSource.DataMember = "ItemCategory_table";
            this.Cate_LookupbindingSource.DataSource = this.category_LookUpDataSet;
            // 
            // category_LookUpDataSet
            // 
            this.category_LookUpDataSet.DataSetName = "Category_LookUpDataSet";
            this.category_LookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.items_tableBindingSource, "VAT_category", true));
            this.comboBox1.DataSource = this.vATcategorytableBindingSource;
            this.comboBox1.DisplayMember = "VAT_category";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 26);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "ID";
            // 
            // vATcategorytableBindingSource
            // 
            this.vATcategorytableBindingSource.DataMember = "VAT_category_table";
            this.vATcategorytableBindingSource.DataSource = this.vATCatelookupDataSetBindingSource;
            // 
            // vATCatelookupDataSetBindingSource
            // 
            this.vATCatelookupDataSetBindingSource.DataSource = this.vATCate_lookup_DataSet;
            this.vATCatelookupDataSetBindingSource.Position = 0;
            // 
            // vATCate_lookup_DataSet
            // 
            this.vATCate_lookup_DataSet.DataSetName = "VATCate_lookup_DataSet";
            this.vATCate_lookup_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "ItemName", true));
            this.itemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(137, 30);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(203, 24);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // openingStockTextBox
            // 
            this.openingStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "OpeningStock", true));
            this.openingStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingStockTextBox.Location = new System.Drawing.Point(137, 82);
            this.openingStockTextBox.Name = "openingStockTextBox";
            this.openingStockTextBox.Size = new System.Drawing.Size(203, 24);
            this.openingStockTextBox.TabIndex = 2;
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "Units", true));
            this.unitsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsTextBox.Location = new System.Drawing.Point(137, 108);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(203, 24);
            this.unitsTextBox.TabIndex = 3;
            // 
            // mRPTextBox
            // 
            this.mRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "MRP", true));
            this.mRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRPTextBox.Location = new System.Drawing.Point(137, 134);
            this.mRPTextBox.Name = "mRPTextBox";
            this.mRPTextBox.Size = new System.Drawing.Size(203, 24);
            this.mRPTextBox.TabIndex = 4;
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "SellPrice", true));
            this.sellPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPriceTextBox.Location = new System.Drawing.Point(137, 160);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(203, 24);
            this.sellPriceTextBox.TabIndex = 5;
            // 
            // buyPriceTextBox
            // 
            this.buyPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.items_tableBindingSource, "BuyPrice", true));
            this.buyPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPriceTextBox.Location = new System.Drawing.Point(137, 186);
            this.buyPriceTextBox.Name = "buyPriceTextBox";
            this.buyPriceTextBox.Size = new System.Drawing.Size(203, 24);
            this.buyPriceTextBox.TabIndex = 6;
            // 
            // items_tableTableAdapter
            // 
            this.items_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemCategory_tableTableAdapter = null;
            this.tableAdapterManager.Items_tableTableAdapter = this.items_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = PetrolBunkManagement.DataSets.ProductDetails_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAT_category_tableTableAdapter = null;
            // 
            // itemCategory_tableTableAdapter
            // 
            this.itemCategory_tableTableAdapter.ClearBeforeFill = true;
            // 
            // vAT_category_tableTableAdapter
            // 
            this.vAT_category_tableTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 472);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.items_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetails_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_tableBindingNavigator)).EndInit();
            this.items_tableBindingNavigator.ResumeLayout(false);
            this.items_tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cate_LookupbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_LookUpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATcategorytableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATCatelookupDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATCate_lookup_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ProductlistBox1;
        private DataSets.ProductDetails_DataSet productDetails_DataSet;
        private System.Windows.Forms.BindingSource items_tableBindingSource;
        private DataSets.ProductDetails_DataSetTableAdapters.Items_tableTableAdapter items_tableTableAdapter;
        private DataSets.ProductDetails_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator items_tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton items_tableBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox openingStockTextBox;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.TextBox mRPTextBox;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.TextBox buyPriceTextBox;
        private System.Windows.Forms.BindingSource Cate_LookupbindingSource;
        private DataSets.Category_LookUpDataSet category_LookUpDataSet;
        private DataSets.Category_LookUpDataSetTableAdapters.ItemCategory_tableTableAdapter itemCategory_tableTableAdapter;
        private System.Windows.Forms.BindingSource vATCatelookupDataSetBindingSource;
        private DataSets.VATCate_lookup_DataSet vATCate_lookup_DataSet;
        private System.Windows.Forms.BindingSource vATcategorytableBindingSource;
        private DataSets.VATCate_lookup_DataSetTableAdapters.VAT_category_tableTableAdapter vAT_category_tableTableAdapter;
        private System.Windows.Forms.LinkLabel Add_Vat_Categ_link;
        private System.Windows.Forms.LinkLabel Add_categ_link;
        private System.Windows.Forms.PictureBox pictureBox1;           
    }
}