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
            this.form5_btn_cancelRes = new System.Windows.Forms.Button();
            this.form5_btn_getRes = new System.Windows.Forms.Button();
            this.form5_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form5_llabel_name = new System.Windows.Forms.LinkLabel();
            this.form5_label = new System.Windows.Forms.Label();
            this.form5_btn_newRes = new System.Windows.Forms.Button();
            this.form5_dgv = new System.Windows.Forms.DataGridView();
            this.form5_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form5_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // form5_panel
            // 
            this.form5_panel.Controls.Add(this.form5_dgv);
            this.form5_panel.Controls.Add(this.form5_btn_newRes);
            this.form5_panel.Controls.Add(this.form5_btn_cancelRes);
            this.form5_panel.Controls.Add(this.form5_btn_getRes);
            this.form5_panel.Controls.Add(this.form5_llabel_signout);
            this.form5_panel.Controls.Add(this.form5_llabel_name);
            this.form5_panel.Controls.Add(this.form5_label);
            this.form5_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form5_panel.Location = new System.Drawing.Point(0, 0);
            this.form5_panel.Name = "form5_panel";
            this.form5_panel.Size = new System.Drawing.Size(406, 233);
            this.form5_panel.TabIndex = 1;
            // 
            // form5_btn_cancelRes
            // 
            this.form5_btn_cancelRes.Location = new System.Drawing.Point(12, 188);
            this.form5_btn_cancelRes.Name = "form5_btn_cancelRes";
            this.form5_btn_cancelRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_cancelRes.TabIndex = 6;
            this.form5_btn_cancelRes.Text = "cancel reservation";
            this.form5_btn_cancelRes.UseVisualStyleBackColor = true;
            // 
            // form5_btn_getRes
            // 
            this.form5_btn_getRes.Location = new System.Drawing.Point(12, 159);
            this.form5_btn_getRes.Name = "form5_btn_getRes";
            this.form5_btn_getRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_getRes.TabIndex = 5;
            this.form5_btn_getRes.Text = "current reservations";
            this.form5_btn_getRes.UseVisualStyleBackColor = true;
            // 
            // form5_llabel_signout
            // 
            this.form5_llabel_signout.AutoSize = true;
            this.form5_llabel_signout.Location = new System.Drawing.Point(303, 37);
            this.form5_llabel_signout.Name = "form5_llabel_signout";
            this.form5_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form5_llabel_signout.TabIndex = 3;
            this.form5_llabel_signout.TabStop = true;
            this.form5_llabel_signout.Text = "sign out";
            // 
            // form5_llabel_name
            // 
            this.form5_llabel_name.AutoSize = true;
            this.form5_llabel_name.Location = new System.Drawing.Point(361, 14);
            this.form5_llabel_name.Name = "form5_llabel_name";
            this.form5_llabel_name.Size = new System.Drawing.Size(33, 13);
            this.form5_llabel_name.TabIndex = 2;
            this.form5_llabel_name.TabStop = true;
            this.form5_llabel_name.Text = "name";
            // 
            // form5_label
            // 
            this.form5_label.AutoSize = true;
            this.form5_label.Location = new System.Drawing.Point(303, 14);
            this.form5_label.Name = "form5_label";
            this.form5_label.Size = new System.Drawing.Size(52, 13);
            this.form5_label.TabIndex = 1;
            this.form5_label.Text = "welcome,";
            // 
            // form5_btn_newRes
            // 
            this.form5_btn_newRes.Location = new System.Drawing.Point(12, 130);
            this.form5_btn_newRes.Name = "form5_btn_newRes";
            this.form5_btn_newRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_newRes.TabIndex = 7;
            this.form5_btn_newRes.Text = "new reservation";
            this.form5_btn_newRes.UseVisualStyleBackColor = true;
            // 
            // form5_dgv
            // 
            this.form5_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form5_dgv.Location = new System.Drawing.Point(130, 130);
            this.form5_dgv.Name = "form5_dgv";
            this.form5_dgv.Size = new System.Drawing.Size(264, 81);
            this.form5_dgv.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 233);
            this.Controls.Add(this.form5_panel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.form5_panel.ResumeLayout(false);
            this.form5_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form5_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form5_panel;
        private System.Windows.Forms.Button form5_btn_cancelRes;
        private System.Windows.Forms.Button form5_btn_getRes;
        private System.Windows.Forms.LinkLabel form5_llabel_signout;
        private System.Windows.Forms.LinkLabel form5_llabel_name;
        private System.Windows.Forms.Label form5_label;
        private System.Windows.Forms.DataGridView form5_dgv;
        private System.Windows.Forms.Button form5_btn_newRes;
    }
}