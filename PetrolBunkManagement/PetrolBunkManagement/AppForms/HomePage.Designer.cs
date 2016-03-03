namespace PetrolBunkManagement.AppForms
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HomeForm_welcome_label = new System.Windows.Forms.Label();
            this.Footer_label = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "00-bml-reports.png");
            this.imageList1.Images.SetKeyName(1, "9.png");
            this.imageList1.Images.SetKeyName(2, "120px-Crystal_Clear_action_button_cancel.png");
            this.imageList1.Images.SetKeyName(3, "500px-Crystal_Clear_action_exit.svg.png");
            this.imageList1.Images.SetKeyName(4, "administrator_256.png");
            this.imageList1.Images.SetKeyName(5, "Ampeross-Qetto-2-Add-contact.ico");
            this.imageList1.Images.SetKeyName(6, "bill.jpg");
            this.imageList1.Images.SetKeyName(7, "build-icon.png");
            this.imageList1.Images.SetKeyName(8, "cash_register_256.png");
            this.imageList1.Images.SetKeyName(9, "Custom-Icon-Design-Pretty-Office-7-Save.ico");
            this.imageList1.Images.SetKeyName(10, "Digital-Billing-Machines.jpg");
            this.imageList1.Images.SetKeyName(11, "editb2.jpg");
            this.imageList1.Images.SetKeyName(12, "employee7.png");
            this.imageList1.Images.SetKeyName(13, "exit.png");
            this.imageList1.Images.SetKeyName(14, "exit-stop-stop-disable-icone-4911-128.png");
            this.imageList1.Images.SetKeyName(15, "Folder customer.ico");
            this.imageList1.Images.SetKeyName(16, "Home Icon.png");
            this.imageList1.Images.SetKeyName(17, "Indian-Oil-Petrol-925593120s.jpg");
            this.imageList1.Images.SetKeyName(18, "Workers.png");
            // 
            // MainMenu
            // 
            this.MainMenu.AllowDrop = true;
            this.MainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(690, 68);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.homeToolStripMenuItem.Image = global::PetrolBunkManagement.Properties.Resources.Dock_Icon_Home_Button_by_Moa_isa_JediKnight;
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(79, 48);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.pumpToolStripMenuItem,
            this.tankToolStripMenuItem});
            this.inventoryToolStripMenuItem.Image = global::PetrolBunkManagement.Properties.Resources.cabinet_hires_2;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(105, 62);
            this.inventoryToolStripMenuItem.Text = "Inventory";            
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // pumpToolStripMenuItem
            // 
            this.pumpToolStripMenuItem.Name = "pumpToolStripMenuItem";
            this.pumpToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.pumpToolStripMenuItem.Text = "Pump";
            // 
            // tankToolStripMenuItem
            // 
            this.tankToolStripMenuItem.Name = "tankToolStripMenuItem";
            this.tankToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.tankToolStripMenuItem.Text = "Tank";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.profitLossToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::PetrolBunkManagement.Properties.Resources._00_bml_reports;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(92, 62);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.dailyToolStripMenuItem.Text = "Daily Sales";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // profitLossToolStripMenuItem
            // 
            this.profitLossToolStripMenuItem.Name = "profitLossToolStripMenuItem";
            this.profitLossToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.profitLossToolStripMenuItem.Text = "Profit&Loss";
            this.profitLossToolStripMenuItem.Click += new System.EventHandler(this.profitLossToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::PetrolBunkManagement.Properties.Resources.tools_icon;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(94, 62);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PetrolBunkManagement.Properties.Resources.exit_stop_stop_disable_icone_4911_128;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(63, 62);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_tab_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HomeForm_welcome_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainMenu);
            this.splitContainer1.Size = new System.Drawing.Size(690, 106);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // HomeForm_welcome_label
            // 
            this.HomeForm_welcome_label.AutoSize = true;
            this.HomeForm_welcome_label.Location = new System.Drawing.Point(18, 9);
            this.HomeForm_welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeForm_welcome_label.Name = "HomeForm_welcome_label";
            this.HomeForm_welcome_label.Size = new System.Drawing.Size(0, 17);
            this.HomeForm_welcome_label.TabIndex = 0;
            // 
            // Footer_label
            // 
            this.Footer_label.AutoSize = true;
            this.Footer_label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Footer_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Footer_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer_label.Location = new System.Drawing.Point(0, 585);
            this.Footer_label.Name = "Footer_label";
            this.Footer_label.Size = new System.Drawing.Size(151, 19);
            this.Footer_label.TabIndex = 3;
            this.Footer_label.Text = "CopyRights Received";
            this.Footer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 604);
            this.Controls.Add(this.Footer_label);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;        
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label HomeForm_welcome_label;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Label Footer_label;
        private System.Windows.Forms.ToolStripMenuItem profitLossToolStripMenuItem;
    }
}