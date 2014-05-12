namespace PoliHilton
{
    partial class Form5
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
            this.form5_panel = new System.Windows.Forms.Panel();
            this.form5_btn_newRes = new System.Windows.Forms.Button();
            this.form5_btn_cancelRes = new System.Windows.Forms.Button();
            this.form5_btn_getRes = new System.Windows.Forms.Button();
            this.form5_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form5_label = new System.Windows.Forms.Label();
            this.Form5_label_name = new System.Windows.Forms.Label();
            this.Form5_lb = new System.Windows.Forms.ListBox();
            this.form5_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form5_panel
            // 
            this.form5_panel.Controls.Add(this.Form5_lb);
            this.form5_panel.Controls.Add(this.Form5_label_name);
            this.form5_panel.Controls.Add(this.form5_btn_newRes);
            this.form5_panel.Controls.Add(this.form5_btn_cancelRes);
            this.form5_panel.Controls.Add(this.form5_btn_getRes);
            this.form5_panel.Controls.Add(this.form5_llabel_signout);
            this.form5_panel.Controls.Add(this.form5_label);
            this.form5_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form5_panel.Location = new System.Drawing.Point(0, 0);
            this.form5_panel.Name = "form5_panel";
            this.form5_panel.Size = new System.Drawing.Size(487, 233);
            this.form5_panel.TabIndex = 1;
            // 
            // form5_btn_newRes
            // 
            this.form5_btn_newRes.Location = new System.Drawing.Point(12, 130);
            this.form5_btn_newRes.Name = "form5_btn_newRes";
            this.form5_btn_newRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_newRes.TabIndex = 7;
            this.form5_btn_newRes.Text = "new reservation";
            this.form5_btn_newRes.UseVisualStyleBackColor = true;
            this.form5_btn_newRes.Click += new System.EventHandler(this.form5_btn_newRes_Click);
            // 
            // form5_btn_cancelRes
            // 
            this.form5_btn_cancelRes.Location = new System.Drawing.Point(12, 188);
            this.form5_btn_cancelRes.Name = "form5_btn_cancelRes";
            this.form5_btn_cancelRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_cancelRes.TabIndex = 6;
            this.form5_btn_cancelRes.Text = "cancel reservation";
            this.form5_btn_cancelRes.UseVisualStyleBackColor = true;
            this.form5_btn_cancelRes.Click += new System.EventHandler(this.form5_btn_cancelRes_Click);
            // 
            // form5_btn_getRes
            // 
            this.form5_btn_getRes.Location = new System.Drawing.Point(12, 159);
            this.form5_btn_getRes.Name = "form5_btn_getRes";
            this.form5_btn_getRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_getRes.TabIndex = 5;
            this.form5_btn_getRes.Text = "current reservations";
            this.form5_btn_getRes.UseVisualStyleBackColor = true;
            this.form5_btn_getRes.Click += new System.EventHandler(this.form5_btn_getRes_Click);
            // 
            // form5_llabel_signout
            // 
            this.form5_llabel_signout.AutoSize = true;
            this.form5_llabel_signout.Location = new System.Drawing.Point(412, 40);
            this.form5_llabel_signout.Name = "form5_llabel_signout";
            this.form5_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form5_llabel_signout.TabIndex = 3;
            this.form5_llabel_signout.TabStop = true;
            this.form5_llabel_signout.Text = "sign out";
            this.form5_llabel_signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form5_llabel_signout_LinkClicked);
            // 
            // form5_label
            // 
            this.form5_label.AutoSize = true;
            this.form5_label.Location = new System.Drawing.Point(388, 18);
            this.form5_label.Name = "form5_label";
            this.form5_label.Size = new System.Drawing.Size(52, 13);
            this.form5_label.TabIndex = 1;
            this.form5_label.Text = "welcome,";
            // 
            // Form5_label_name
            // 
            this.Form5_label_name.AutoSize = true;
            this.Form5_label_name.Location = new System.Drawing.Point(444, 18);
            this.Form5_label_name.Name = "Form5_label_name";
            this.Form5_label_name.Size = new System.Drawing.Size(35, 13);
            this.Form5_label_name.TabIndex = 9;
            this.Form5_label_name.Text = "label1";
            // 
            // Form5_lb
            // 
            this.Form5_lb.FormattingEnabled = true;
            this.Form5_lb.Location = new System.Drawing.Point(143, 130);
            this.Form5_lb.Name = "Form5_lb";
            this.Form5_lb.Size = new System.Drawing.Size(336, 82);
            this.Form5_lb.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 233);
            this.Controls.Add(this.form5_panel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.form5_panel.ResumeLayout(false);
            this.form5_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form5_panel;
        private System.Windows.Forms.Button form5_btn_cancelRes;
        private System.Windows.Forms.Button form5_btn_getRes;
        private System.Windows.Forms.LinkLabel form5_llabel_signout;
        private System.Windows.Forms.Label form5_label;
        private System.Windows.Forms.Button form5_btn_newRes;
        private System.Windows.Forms.Label Form5_label_name;
        private System.Windows.Forms.ListBox Form5_lb;
    }
}