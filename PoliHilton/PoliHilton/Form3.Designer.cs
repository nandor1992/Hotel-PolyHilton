namespace PoliHilton
{
    partial class Form3
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
            this.form3_panel = new System.Windows.Forms.Panel();
            this.form3_btn_asigne = new System.Windows.Forms.Button();
            this.form3_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form3_llabel_name = new System.Windows.Forms.LinkLabel();
            this.form3_label = new System.Windows.Forms.Label();
            this.form3_btn_submit = new System.Windows.Forms.Button();
            this.form3_dgv = new System.Windows.Forms.DataGridView();
            this.form3_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form3_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // form3_panel
            // 
            this.form3_panel.Controls.Add(this.form3_btn_asigne);
            this.form3_panel.Controls.Add(this.form3_llabel_signout);
            this.form3_panel.Controls.Add(this.form3_llabel_name);
            this.form3_panel.Controls.Add(this.form3_label);
            this.form3_panel.Controls.Add(this.form3_btn_submit);
            this.form3_panel.Controls.Add(this.form3_dgv);
            this.form3_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form3_panel.Location = new System.Drawing.Point(0, 0);
            this.form3_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form3_panel.Name = "form3_panel";
            this.form3_panel.Size = new System.Drawing.Size(1097, 399);
            this.form3_panel.TabIndex = 1;
            // 
            // form3_btn_asigne
            // 
            this.form3_btn_asigne.Location = new System.Drawing.Point(16, 143);
            this.form3_btn_asigne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form3_btn_asigne.Name = "form3_btn_asigne";
            this.form3_btn_asigne.Size = new System.Drawing.Size(288, 28);
            this.form3_btn_asigne.TabIndex = 6;
            this.form3_btn_asigne.Text = "asigned rooms";
            this.form3_btn_asigne.UseVisualStyleBackColor = true;
            this.form3_btn_asigne.Click += new System.EventHandler(this.form3_btn_asigne_Click);
            // 
            // form3_llabel_signout
            // 
            this.form3_llabel_signout.AutoSize = true;
            this.form3_llabel_signout.Location = new System.Drawing.Point(960, 38);
            this.form3_llabel_signout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form3_llabel_signout.Name = "form3_llabel_signout";
            this.form3_llabel_signout.Size = new System.Drawing.Size(58, 17);
            this.form3_llabel_signout.TabIndex = 4;
            this.form3_llabel_signout.TabStop = true;
            this.form3_llabel_signout.Text = "sign out";
            // 
            // form3_llabel_name
            // 
            this.form3_llabel_name.AutoSize = true;
            this.form3_llabel_name.Location = new System.Drawing.Point(1031, 11);
            this.form3_llabel_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form3_llabel_name.Name = "form3_llabel_name";
            this.form3_llabel_name.Size = new System.Drawing.Size(43, 17);
            this.form3_llabel_name.TabIndex = 3;
            this.form3_llabel_name.TabStop = true;
            this.form3_llabel_name.Text = "name";
            // 
            // form3_label
            // 
            this.form3_label.AutoSize = true;
            this.form3_label.Location = new System.Drawing.Point(956, 11);
            this.form3_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form3_label.Name = "form3_label";
            this.form3_label.Size = new System.Drawing.Size(74, 17);
            this.form3_label.TabIndex = 2;
            this.form3_label.Text = "Welcome, ";
            // 
            // form3_btn_submit
            // 
            this.form3_btn_submit.Location = new System.Drawing.Point(675, 143);
            this.form3_btn_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form3_btn_submit.Name = "form3_btn_submit";
            this.form3_btn_submit.Size = new System.Drawing.Size(293, 28);
            this.form3_btn_submit.TabIndex = 1;
            this.form3_btn_submit.Text = "Cleand";
            this.form3_btn_submit.UseVisualStyleBackColor = true;
            this.form3_btn_submit.Click += new System.EventHandler(this.form3_btn_submit_Click);
            // 
            // form3_dgv
            // 
            this.form3_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form3_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.form3_dgv.Location = new System.Drawing.Point(0, 179);
            this.form3_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form3_dgv.Name = "form3_dgv";
            this.form3_dgv.Size = new System.Drawing.Size(1097, 220);
            this.form3_dgv.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 399);
            this.Controls.Add(this.form3_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.form3_panel.ResumeLayout(false);
            this.form3_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form3_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form3_panel;
        private System.Windows.Forms.Button form3_btn_asigne;
        private System.Windows.Forms.LinkLabel form3_llabel_signout;
        private System.Windows.Forms.LinkLabel form3_llabel_name;
        private System.Windows.Forms.Label form3_label;
        private System.Windows.Forms.Button form3_btn_submit;
        private System.Windows.Forms.DataGridView form3_dgv;
    }
}