namespace App
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.linkToReg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.White;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AuthButton.Location = new System.Drawing.Point(128, 246);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(122, 43);
            this.AuthButton.TabIndex = 7;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = false;
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.White;
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(102, 177);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(170, 19);
            this.UserPasswordField.TabIndex = 6;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.White;
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(102, 122);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(170, 19);
            this.UserLoginField.TabIndex = 5;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // linkToReg
            // 
            this.linkToReg.AutoSize = true;
            this.linkToReg.Location = new System.Drawing.Point(114, 349);
            this.linkToReg.Name = "linkToReg";
            this.linkToReg.Size = new System.Drawing.Size(144, 16);
            this.linkToReg.TabIndex = 8;
            this.linkToReg.TabStop = true;
            this.linkToReg.Text = "Зарегистрироваться";
            this.linkToReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToReg_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 425);
            this.Controls.Add(this.linkToReg);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.LinkLabel linkToReg;
    }
}