namespace WinformProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.emailTbox = new System.Windows.Forms.TextBox();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.logRcrdsTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // emailTbox
            // 
            this.emailTbox.Location = new System.Drawing.Point(63, 41);
            this.emailTbox.Name = "emailTbox";
            this.emailTbox.Size = new System.Drawing.Size(200, 23);
            this.emailTbox.TabIndex = 1;
            // 
            // passTbox
            // 
            this.passTbox.Location = new System.Drawing.Point(359, 41);
            this.passTbox.Name = "passTbox";
            this.passTbox.Size = new System.Drawing.Size(200, 23);
            this.passTbox.TabIndex = 2;
            this.passTbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(598, 41);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logRcrdsTbox
            // 
            this.logRcrdsTbox.Location = new System.Drawing.Point(21, 92);
            this.logRcrdsTbox.Multiline = true;
            this.logRcrdsTbox.Name = "logRcrdsTbox";
            this.logRcrdsTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logRcrdsTbox.Size = new System.Drawing.Size(652, 274);
            this.logRcrdsTbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 386);
            this.Controls.Add(this.logRcrdsTbox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTbox;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox logRcrdsTbox;
    }
}

