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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HomePage_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePage_tab
            // 
            this.HomePage_tab.Controls.Add(this.Home_tab);
            this.HomePage_tab.Controls.Add(this.tabPage2);
            this.HomePage_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePage_tab.HotTrack = true;
            this.HomePage_tab.Location = new System.Drawing.Point(0, 0);
            this.HomePage_tab.Name = "HomePage_tab";
            this.HomePage_tab.SelectedIndex = 0;
            this.HomePage_tab.Size = new System.Drawing.Size(717, 548);
            this.HomePage_tab.TabIndex = 0;
            this.HomePage_tab.UseWaitCursor = true;
            // 
            // Home_tab
            // 
            this.Home_tab.Location = new System.Drawing.Point(4, 22);
            this.Home_tab.Margin = new System.Windows.Forms.Padding(20);
            this.Home_tab.Name = "Home_tab";
            this.Home_tab.Padding = new System.Windows.Forms.Padding(30);
            this.Home_tab.Size = new System.Drawing.Size(709, 522);
            this.Home_tab.TabIndex = 0;
            this.Home_tab.Text = "Home";
            this.Home_tab.UseVisualStyleBackColor = true;
            this.Home_tab.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}