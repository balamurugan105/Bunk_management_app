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
            this.HomePage_tab = new System.Windows.Forms.TabControl();
            this.Home_tab = new System.Windows.Forms.TabPage();
            this.Inventory_tab = new System.Windows.Forms.TabPage();
            this.Reports_tab = new System.Windows.Forms.TabPage();
            this.Settings_tab = new System.Windows.Forms.TabPage();
            this.Exit_tab = new System.Windows.Forms.TabPage();
            this.HomePage_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePage_tab
            // 
            this.HomePage_tab.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.HomePage_tab.Controls.Add(this.Home_tab);
            this.HomePage_tab.Controls.Add(this.Inventory_tab);
            this.HomePage_tab.Controls.Add(this.Reports_tab);
            this.HomePage_tab.Controls.Add(this.Settings_tab);
            this.HomePage_tab.Controls.Add(this.Exit_tab);
            this.HomePage_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePage_tab.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage_tab.HotTrack = true;
            this.HomePage_tab.Location = new System.Drawing.Point(0, 0);
            this.HomePage_tab.Name = "HomePage_tab";
            this.HomePage_tab.Padding = new System.Drawing.Point(25, 10);
            this.HomePage_tab.SelectedIndex = 0;
            this.HomePage_tab.Size = new System.Drawing.Size(717, 548);
            this.HomePage_tab.TabIndex = 0;
            // 
            // Home_tab
            // 
            this.Home_tab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Home_tab.AllowDrop = true;
            this.Home_tab.AutoScroll = true;
            this.Home_tab.BackgroundImage = global::PetrolBunkManagement.Properties.Resources.Car_Oil;
            this.Home_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_tab.Location = new System.Drawing.Point(4, 45);
            this.Home_tab.Margin = new System.Windows.Forms.Padding(20);
            this.Home_tab.Name = "Home_tab";
            this.Home_tab.Padding = new System.Windows.Forms.Padding(30);
            this.Home_tab.Size = new System.Drawing.Size(709, 499);
            this.Home_tab.TabIndex = 0;
            this.Home_tab.Text = "Home";
            this.Home_tab.UseVisualStyleBackColor = true;
            // 
            // Inventory_tab
            // 
            this.Inventory_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_tab.Location = new System.Drawing.Point(4, 45);
            this.Inventory_tab.Name = "Inventory_tab";
            this.Inventory_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory_tab.Size = new System.Drawing.Size(709, 499);
            this.Inventory_tab.TabIndex = 1;
            this.Inventory_tab.Text = "Inventory";
            this.Inventory_tab.UseVisualStyleBackColor = true;
            this.Inventory_tab.UseWaitCursor = true;
            // 
            // Reports_tab
            // 
            this.Reports_tab.Location = new System.Drawing.Point(4, 45);
            this.Reports_tab.Name = "Reports_tab";
            this.Reports_tab.Size = new System.Drawing.Size(709, 499);
            this.Reports_tab.TabIndex = 2;
            this.Reports_tab.Text = "Reports";
            this.Reports_tab.UseVisualStyleBackColor = true;
            this.Reports_tab.UseWaitCursor = true;
            this.Reports_tab.Click += new System.EventHandler(this.Reports_tab_Click);
            // 
            // Settings_tab
            // 
            this.Settings_tab.Location = new System.Drawing.Point(4, 45);
            this.Settings_tab.Name = "Settings_tab";
            this.Settings_tab.Size = new System.Drawing.Size(709, 499);
            this.Settings_tab.TabIndex = 3;
            this.Settings_tab.Text = "Settings";
            this.Settings_tab.UseVisualStyleBackColor = true;
            this.Settings_tab.UseWaitCursor = true;
            // 
            // Exit_tab
            // 
            this.Exit_tab.Location = new System.Drawing.Point(4, 45);
            this.Exit_tab.Name = "Exit_tab";
            this.Exit_tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit_tab.Size = new System.Drawing.Size(709, 499);
            this.Exit_tab.TabIndex = 8;
            this.Exit_tab.Text = "Exit";
            this.Exit_tab.UseVisualStyleBackColor = true;
            this.Exit_tab.UseWaitCursor = true;
            this.Exit_tab.Click += new System.EventHandler(this.Exit_tab_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 548);
            this.Controls.Add(this.HomePage_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HomePage_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HomePage_tab;
        private System.Windows.Forms.TabPage Home_tab;
        private System.Windows.Forms.TabPage Inventory_tab;
        private System.Windows.Forms.TabPage Reports_tab;
        private System.Windows.Forms.TabPage Settings_tab;
        private System.Windows.Forms.TabPage Exit_tab;
    }
}