namespace PetrolBunkManagement.AppForms
{
    partial class LoginForm
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
            this.login_info_container = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.uname_box = new System.Windows.Forms.TextBox();
            this.login_exit_but = new System.Windows.Forms.Button();
            this.Login_but = new System.Windows.Forms.Button();
            this.login_info_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_info_container
            // 
            this.login_info_container.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.login_info_container.Controls.Add(this.label2);
            this.login_info_container.Controls.Add(this.label1);
            this.login_info_container.Controls.Add(this.pwd_box);
            this.login_info_container.Controls.Add(this.uname_box);
            this.login_info_container.Controls.Add(this.login_exit_but);
            this.login_info_container.Controls.Add(this.Login_but);
            this.login_info_container.Location = new System.Drawing.Point(299, 33);
            this.login_info_container.Name = "login_info_container";
            this.login_info_container.Size = new System.Drawing.Size(310, 203);
            this.login_info_container.TabIndex = 0;
            this.login_info_container.TabStop = false;
            this.login_info_container.UseCompatibleTextRendering = true;
            this.login_info_container.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            this.label1.UseWaitCursor = true;
            // 
            // pwd_box
            // 
            this.pwd_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd_box.Location = new System.Drawing.Point(155, 106);
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.PasswordChar = '*';
            this.pwd_box.Size = new System.Drawing.Size(143, 20);
            this.pwd_box.TabIndex = 2;
            this.pwd_box.UseWaitCursor = true;
            // 
            // uname_box
            // 
            this.uname_box.Location = new System.Drawing.Point(155, 62);
            this.uname_box.Name = "uname_box";
            this.uname_box.Size = new System.Drawing.Size(143, 20);
            this.uname_box.TabIndex = 1;
            this.uname_box.UseWaitCursor = true;
            // 
            // login_exit_but
            // 
            this.login_exit_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_exit_but.Location = new System.Drawing.Point(61, 145);
            this.login_exit_but.Name = "login_exit_but";
            this.login_exit_but.Size = new System.Drawing.Size(108, 37);
            this.login_exit_but.TabIndex = 4;
            this.login_exit_but.Text = "Exit";
            this.login_exit_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_exit_but.UseVisualStyleBackColor = true;
            this.login_exit_but.UseWaitCursor = true;
            this.login_exit_but.Click += new System.EventHandler(this.login_exit_but_Click);
            // 
            // Login_but
            // 
            this.Login_but.Location = new System.Drawing.Point(186, 145);
            this.Login_but.Name = "Login_but";
            this.Login_but.Size = new System.Drawing.Size(112, 37);
            this.Login_but.TabIndex = 3;
            this.Login_but.Text = "login";
            this.Login_but.UseVisualStyleBackColor = true;
            this.Login_but.UseWaitCursor = true;
            this.Login_but.Click += new System.EventHandler(this.Login_but_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetrolBunkManagement.Properties.Resources.bit_locker_icon;
            this.ClientSize = new System.Drawing.Size(621, 292);
            this.Controls.Add(this.login_info_container);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.login_info_container.ResumeLayout(false);
            this.login_info_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_info_container;
        private System.Windows.Forms.Button login_exit_but;
        private System.Windows.Forms.Button Login_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.TextBox uname_box;
    }
}