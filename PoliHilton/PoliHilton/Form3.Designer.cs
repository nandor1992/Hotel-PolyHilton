﻿namespace PoliHilton
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
            this.form3_lb = new System.Windows.Forms.ListBox();
            this.form3_label_asignedRooms = new System.Windows.Forms.Label();
            this.form3_btn_cleaned = new System.Windows.Forms.Button();
            this.form3_btn_inProgress = new System.Windows.Forms.Button();
            this.form3_label_roomStatus = new System.Windows.Forms.Label();
            this.form3_btn_refresh = new System.Windows.Forms.Button();
            this.form3_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form3_label_welcome = new System.Windows.Forms.Label();
            this.Form3_label_name = new System.Windows.Forms.Label();
            this.form3_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form3_panel
            // 
            this.form3_panel.Controls.Add(this.Form3_label_name);
            this.form3_panel.Controls.Add(this.form3_lb);
            this.form3_panel.Controls.Add(this.form3_label_asignedRooms);
            this.form3_panel.Controls.Add(this.form3_btn_cleaned);
            this.form3_panel.Controls.Add(this.form3_btn_inProgress);
            this.form3_panel.Controls.Add(this.form3_label_roomStatus);
            this.form3_panel.Controls.Add(this.form3_btn_refresh);
            this.form3_panel.Controls.Add(this.form3_llabel_signout);
            this.form3_panel.Controls.Add(this.form3_label_welcome);
            this.form3_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form3_panel.Location = new System.Drawing.Point(0, 0);
            this.form3_panel.Name = "form3_panel";
            this.form3_panel.Size = new System.Drawing.Size(347, 324);
            this.form3_panel.TabIndex = 1;
            // 
            // form3_lb
            // 
            this.form3_lb.FormattingEnabled = true;
            this.form3_lb.Location = new System.Drawing.Point(31, 133);
            this.form3_lb.Name = "form3_lb";
            this.form3_lb.Size = new System.Drawing.Size(155, 108);
            this.form3_lb.TabIndex = 12;
            // 
            // form3_label_asignedRooms
            // 
            this.form3_label_asignedRooms.AutoSize = true;
            this.form3_label_asignedRooms.Location = new System.Drawing.Point(28, 117);
            this.form3_label_asignedRooms.Name = "form3_label_asignedRooms";
            this.form3_label_asignedRooms.Size = new System.Drawing.Size(75, 13);
            this.form3_label_asignedRooms.TabIndex = 11;
            this.form3_label_asignedRooms.Text = "asigned rooms";
            // 
            // form3_btn_cleaned
            // 
            this.form3_btn_cleaned.Location = new System.Drawing.Point(220, 181);
            this.form3_btn_cleaned.Name = "form3_btn_cleaned";
            this.form3_btn_cleaned.Size = new System.Drawing.Size(75, 23);
            this.form3_btn_cleaned.TabIndex = 10;
            this.form3_btn_cleaned.Text = "Cleaned";
            this.form3_btn_cleaned.UseVisualStyleBackColor = true;
            this.form3_btn_cleaned.Click += new System.EventHandler(this.form3_btn_cleaned_Click);
            // 
            // form3_btn_inProgress
            // 
            this.form3_btn_inProgress.Location = new System.Drawing.Point(220, 151);
            this.form3_btn_inProgress.Name = "form3_btn_inProgress";
            this.form3_btn_inProgress.Size = new System.Drawing.Size(75, 23);
            this.form3_btn_inProgress.TabIndex = 9;
            this.form3_btn_inProgress.Text = "In progress";
            this.form3_btn_inProgress.UseVisualStyleBackColor = true;
            this.form3_btn_inProgress.Click += new System.EventHandler(this.form3_btn_inProgress_Click);
            // 
            // form3_label_roomStatus
            // 
            this.form3_label_roomStatus.AutoSize = true;
            this.form3_label_roomStatus.Location = new System.Drawing.Point(217, 134);
            this.form3_label_roomStatus.Name = "form3_label_roomStatus";
            this.form3_label_roomStatus.Size = new System.Drawing.Size(100, 13);
            this.form3_label_roomStatus.TabIndex = 8;
            this.form3_label_roomStatus.Text = "change room status";
            // 
            // form3_btn_refresh
            // 
            this.form3_btn_refresh.Location = new System.Drawing.Point(51, 247);
            this.form3_btn_refresh.Name = "form3_btn_refresh";
            this.form3_btn_refresh.Size = new System.Drawing.Size(100, 23);
            this.form3_btn_refresh.TabIndex = 6;
            this.form3_btn_refresh.Text = "Refresh";
            this.form3_btn_refresh.UseVisualStyleBackColor = true;
            this.form3_btn_refresh.Click += new System.EventHandler(this.form3_btn_asigne_Click);
            // 
            // form3_llabel_signout
            // 
            this.form3_llabel_signout.AutoSize = true;
            this.form3_llabel_signout.Location = new System.Drawing.Point(273, 31);
            this.form3_llabel_signout.Name = "form3_llabel_signout";
            this.form3_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form3_llabel_signout.TabIndex = 4;
            this.form3_llabel_signout.TabStop = true;
            this.form3_llabel_signout.Text = "sign out";
            this.form3_llabel_signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form3_llabel_signout_LinkClicked);
            // 
            // form3_label_welcome
            // 
            this.form3_label_welcome.AutoSize = true;
            this.form3_label_welcome.Location = new System.Drawing.Point(248, 9);
            this.form3_label_welcome.Name = "form3_label_welcome";
            this.form3_label_welcome.Size = new System.Drawing.Size(58, 13);
            this.form3_label_welcome.TabIndex = 2;
            this.form3_label_welcome.Text = "Welcome, ";
            // 
            // Form3_label_name
            // 
            this.Form3_label_name.AutoSize = true;
            this.Form3_label_name.Location = new System.Drawing.Point(300, 9);
            this.Form3_label_name.Name = "Form3_label_name";
            this.Form3_label_name.Size = new System.Drawing.Size(35, 13);
            this.Form3_label_name.TabIndex = 13;
            this.Form3_label_name.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 324);
            this.Controls.Add(this.form3_panel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.form3_panel.ResumeLayout(false);
            this.form3_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form3_panel;
        private System.Windows.Forms.Button form3_btn_refresh;
        private System.Windows.Forms.LinkLabel form3_llabel_signout;
        private System.Windows.Forms.Label form3_label_welcome;
        private System.Windows.Forms.Label form3_label_asignedRooms;
        private System.Windows.Forms.Button form3_btn_cleaned;
        private System.Windows.Forms.Button form3_btn_inProgress;
        private System.Windows.Forms.Label form3_label_roomStatus;
        private System.Windows.Forms.ListBox form3_lb;
        private System.Windows.Forms.Label Form3_label_name;
    }
}