namespace PoliHilton
{
    partial class Form7
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
            this.form7_panel = new System.Windows.Forms.Panel();
            this.form7_label_roomCap = new System.Windows.Forms.Label();
            this.form7_label_price = new System.Windows.Forms.Label();
            this.form7_label_roomType = new System.Windows.Forms.Label();
            this.form7_cb_roomCap = new System.Windows.Forms.ComboBox();
            this.form7_cb_price = new System.Windows.Forms.ComboBox();
            this.form7_cb_roomType = new System.Windows.Forms.ComboBox();
            this.form7_btn_search = new System.Windows.Forms.Button();
            this.form7_dgv = new System.Windows.Forms.DataGridView();
            this.form7_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form7_llabel_name = new System.Windows.Forms.LinkLabel();
            this.form7_label = new System.Windows.Forms.Label();
            this.form7_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form7_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // form7_panel
            // 
            this.form7_panel.Controls.Add(this.form7_label_roomCap);
            this.form7_panel.Controls.Add(this.form7_label_price);
            this.form7_panel.Controls.Add(this.form7_label_roomType);
            this.form7_panel.Controls.Add(this.form7_cb_roomCap);
            this.form7_panel.Controls.Add(this.form7_cb_price);
            this.form7_panel.Controls.Add(this.form7_cb_roomType);
            this.form7_panel.Controls.Add(this.form7_btn_search);
            this.form7_panel.Controls.Add(this.form7_dgv);
            this.form7_panel.Controls.Add(this.form7_llabel_signout);
            this.form7_panel.Controls.Add(this.form7_llabel_name);
            this.form7_panel.Controls.Add(this.form7_label);
            this.form7_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form7_panel.Location = new System.Drawing.Point(0, 0);
            this.form7_panel.Name = "form7_panel";
            this.form7_panel.Size = new System.Drawing.Size(664, 337);
            this.form7_panel.TabIndex = 1;
            // 
            // form7_label_roomCap
            // 
            this.form7_label_roomCap.AutoSize = true;
            this.form7_label_roomCap.Location = new System.Drawing.Point(156, 168);
            this.form7_label_roomCap.Name = "form7_label_roomCap";
            this.form7_label_roomCap.Size = new System.Drawing.Size(106, 13);
            this.form7_label_roomCap.TabIndex = 11;
            this.form7_label_roomCap.Text = "Select room capacity";
            // 
            // form7_label_price
            // 
            this.form7_label_price.AutoSize = true;
            this.form7_label_price.Location = new System.Drawing.Point(156, 141);
            this.form7_label_price.Name = "form7_label_price";
            this.form7_label_price.Size = new System.Drawing.Size(93, 13);
            this.form7_label_price.TabIndex = 10;
            this.form7_label_price.Text = "Select price range";
            // 
            // form7_label_roomType
            // 
            this.form7_label_roomType.AutoSize = true;
            this.form7_label_roomType.Location = new System.Drawing.Point(156, 113);
            this.form7_label_roomType.Name = "form7_label_roomType";
            this.form7_label_roomType.Size = new System.Drawing.Size(86, 13);
            this.form7_label_roomType.TabIndex = 9;
            this.form7_label_roomType.Text = "Select room type";
            // 
            // form7_cb_roomCap
            // 
            this.form7_cb_roomCap.FormattingEnabled = true;
            this.form7_cb_roomCap.Location = new System.Drawing.Point(18, 160);
            this.form7_cb_roomCap.Name = "form7_cb_roomCap";
            this.form7_cb_roomCap.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_roomCap.TabIndex = 8;
            this.form7_cb_roomCap.Text = "All";
            // 
            // form7_cb_price
            // 
            this.form7_cb_price.FormattingEnabled = true;
            this.form7_cb_price.Location = new System.Drawing.Point(18, 133);
            this.form7_cb_price.Name = "form7_cb_price";
            this.form7_cb_price.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_price.TabIndex = 7;
            this.form7_cb_price.Text = "All";
            // 
            // form7_cb_roomType
            // 
            this.form7_cb_roomType.FormattingEnabled = true;
            this.form7_cb_roomType.Location = new System.Drawing.Point(18, 106);
            this.form7_cb_roomType.Name = "form7_cb_roomType";
            this.form7_cb_roomType.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_roomType.TabIndex = 6;
            this.form7_cb_roomType.Text = "All";
            // 
            // form7_btn_search
            // 
            this.form7_btn_search.Location = new System.Drawing.Point(64, 200);
            this.form7_btn_search.Name = "form7_btn_search";
            this.form7_btn_search.Size = new System.Drawing.Size(75, 23);
            this.form7_btn_search.TabIndex = 5;
            this.form7_btn_search.Text = "search";
            this.form7_btn_search.UseVisualStyleBackColor = true;
            // 
            // form7_dgv
            // 
            this.form7_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form7_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.form7_dgv.Location = new System.Drawing.Point(0, 229);
            this.form7_dgv.Name = "form7_dgv";
            this.form7_dgv.Size = new System.Drawing.Size(664, 108);
            this.form7_dgv.TabIndex = 4;
            // 
            // form7_llabel_signout
            // 
            this.form7_llabel_signout.AutoSize = true;
            this.form7_llabel_signout.Location = new System.Drawing.Point(548, 30);
            this.form7_llabel_signout.Name = "form7_llabel_signout";
            this.form7_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form7_llabel_signout.TabIndex = 3;
            this.form7_llabel_signout.TabStop = true;
            this.form7_llabel_signout.Text = "sign out";
            // 
            // form7_llabel_name
            // 
            this.form7_llabel_name.AutoSize = true;
            this.form7_llabel_name.Location = new System.Drawing.Point(610, 13);
            this.form7_llabel_name.Name = "form7_llabel_name";
            this.form7_llabel_name.Size = new System.Drawing.Size(33, 13);
            this.form7_llabel_name.TabIndex = 2;
            this.form7_llabel_name.TabStop = true;
            this.form7_llabel_name.Text = "name";
            // 
            // form7_label
            // 
            this.form7_label.AutoSize = true;
            this.form7_label.Location = new System.Drawing.Point(545, 13);
            this.form7_label.Name = "form7_label";
            this.form7_label.Size = new System.Drawing.Size(58, 13);
            this.form7_label.TabIndex = 1;
            this.form7_label.Text = "Welcome, ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.form7_panel);
            this.Name = "Form7";
            this.Text = "Form7";
            this.form7_panel.ResumeLayout(false);
            this.form7_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form7_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form7_panel;
        private System.Windows.Forms.Label form7_label_roomCap;
        private System.Windows.Forms.Label form7_label_price;
        private System.Windows.Forms.Label form7_label_roomType;
        private System.Windows.Forms.ComboBox form7_cb_roomCap;
        private System.Windows.Forms.ComboBox form7_cb_price;
        private System.Windows.Forms.ComboBox form7_cb_roomType;
        private System.Windows.Forms.Button form7_btn_search;
        private System.Windows.Forms.DataGridView form7_dgv;
        private System.Windows.Forms.LinkLabel form7_llabel_signout;
        private System.Windows.Forms.LinkLabel form7_llabel_name;
        private System.Windows.Forms.Label form7_label;
    }
}