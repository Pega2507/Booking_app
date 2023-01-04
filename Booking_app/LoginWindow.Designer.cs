namespace Booking_app
{
    partial class LoginWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InpUser = new System.Windows.Forms.TextBox();
            this.InpPassword = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // InpUser
            // 
            this.InpUser.Location = new System.Drawing.Point(171, 40);
            this.InpUser.Name = "InpUser";
            this.InpUser.Size = new System.Drawing.Size(213, 23);
            this.InpUser.TabIndex = 2;
            // 
            // InpPassword
            // 
            this.InpPassword.Location = new System.Drawing.Point(171, 69);
            this.InpPassword.Name = "InpPassword";
            this.InpPassword.PasswordChar = '*';
            this.InpPassword.Size = new System.Drawing.Size(213, 23);
            this.InpPassword.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 139);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(325, 139);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(412, 174);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.InpPassword);
            this.Controls.Add(this.InpUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In To System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox InpUser;
        private TextBox InpPassword;
        private Button BtnCancel;
        private Button BtnLogin;
    }
}