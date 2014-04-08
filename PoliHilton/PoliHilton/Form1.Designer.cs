namespace PoliHilton
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.form1_label_username = new System.Windows.Forms.Label();
            this.form1_label_password = new System.Windows.Forms.Label();
            this.form1_button_signin = new System.Windows.Forms.Button();
            this.form1_button_signup = new System.Windows.Forms.Button();
            this.form1_label_signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // form1_label_username
            // 
            this.form1_label_username.AutoSize = true;
            this.form1_label_username.Location = new System.Drawing.Point(12, 36);
            this.form1_label_username.Name = "form1_label_username";
            this.form1_label_username.Size = new System.Drawing.Size(55, 13);
            this.form1_label_username.TabIndex = 2;
            this.form1_label_username.Text = "Username";
            // 
            // form1_label_password
            // 
            this.form1_label_password.AutoSize = true;
            this.form1_label_password.Location = new System.Drawing.Point(12, 76);
            this.form1_label_password.Name = "form1_label_password";
            this.form1_label_password.Size = new System.Drawing.Size(53, 13);
            this.form1_label_password.TabIndex = 3;
            this.form1_label_password.Text = "Password";
            // 
            // form1_button_signin
            // 
            this.form1_button_signin.AutoSize = true;
            this.form1_button_signin.Location = new System.Drawing.Point(213, 48);
            this.form1_button_signin.Name = "form1_button_signin";
            this.form1_button_signin.Size = new System.Drawing.Size(100, 27);
            this.form1_button_signin.TabIndex = 4;
            this.form1_button_signin.Text = "Sign In";
            this.form1_button_signin.UseVisualStyleBackColor = true;
            this.form1_button_signin.Click += new System.EventHandler(this.form1_button_signin_Click);
            // 
            // form1_button_signup
            // 
            this.form1_button_signup.AutoSize = true;
            this.form1_button_signup.Location = new System.Drawing.Point(76, 150);
            this.form1_button_signup.Name = "form1_button_signup";
            this.form1_button_signup.Size = new System.Drawing.Size(100, 27);
            this.form1_button_signup.TabIndex = 5;
            this.form1_button_signup.Text = "Sign Up";
            this.form1_button_signup.UseVisualStyleBackColor = true;
            // 
            // form1_label_signup
            // 
            this.form1_label_signup.AutoSize = true;
            this.form1_label_signup.Location = new System.Drawing.Point(12, 134);
            this.form1_label_signup.Name = "form1_label_signup";
            this.form1_label_signup.Size = new System.Drawing.Size(203, 13);
            this.form1_label_signup.TabIndex = 6;
            this.form1_label_signup.Text = "Don\'t have an account yet? Sign Up now";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 230);
            this.Controls.Add(this.form1_label_signup);
            this.Controls.Add(this.form1_button_signup);
            this.Controls.Add(this.form1_button_signin);
            this.Controls.Add(this.form1_label_password);
            this.Controls.Add(this.form1_label_username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label form1_label_username;
        private System.Windows.Forms.Label form1_label_password;
        private System.Windows.Forms.Button form1_button_signin;
        private System.Windows.Forms.Button form1_button_signup;
        private System.Windows.Forms.Label form1_label_signup;

    }
}

