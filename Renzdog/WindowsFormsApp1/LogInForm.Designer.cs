namespace Karbro
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameTxt = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.Color.White;
            this.UsernameTxt.Location = new System.Drawing.Point(82, 214);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(86, 18);
            this.UsernameTxt.TabIndex = 1;
            this.UsernameTxt.Text = "Username:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoSize = true;
            this.PasswordTxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.White;
            this.PasswordTxt.Location = new System.Drawing.Point(87, 243);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(81, 18);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.Text = "Password:";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtBox.Location = new System.Drawing.Point(184, 212);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(193, 20);
            this.UsernameTxtBox.TabIndex = 3;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(184, 244);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(193, 20);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInBtn.Location = new System.Drawing.Point(244, 281);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(68, 23);
            this.LogInBtn.TabIndex = 5;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 381);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karbro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UsernameTxt;
        private System.Windows.Forms.Label PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button LogInBtn;
    }
}

