﻿
namespace Project_NeoCitizen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelChild = new System.Windows.Forms.Panel();
            this.btn_Citizen = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Employment = new System.Windows.Forms.Button();
            this.btn_Education = new System.Windows.Forms.Button();
            this.btn_Family = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.duongthang2 = new System.Windows.Forms.Label();
            this.duongthang1 = new System.Windows.Forms.Label();
            this.lblID_NV = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.Location = new System.Drawing.Point(200, 54);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1148, 648);
            this.panelChild.TabIndex = 5;
            // 
            // btn_Citizen
            // 
            this.btn_Citizen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_Citizen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Citizen.FlatAppearance.BorderSize = 0;
            this.btn_Citizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Citizen.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Citizen.ForeColor = System.Drawing.Color.White;
            this.btn_Citizen.Image = ((System.Drawing.Image)(resources.GetObject("btn_Citizen.Image")));
            this.btn_Citizen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Citizen.Location = new System.Drawing.Point(0, 51);
            this.btn_Citizen.Name = "btn_Citizen";
            this.btn_Citizen.Size = new System.Drawing.Size(201, 45);
            this.btn_Citizen.TabIndex = 12;
            this.btn_Citizen.Text = "Công dân";
            this.btn_Citizen.UseVisualStyleBackColor = false;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TrangChu.FlatAppearance.BorderSize = 0;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.Location = new System.Drawing.Point(0, 0);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(201, 45);
            this.btn_TrangChu.TabIndex = 8;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Employment);
            this.panel3.Controls.Add(this.btn_Education);
            this.panel3.Controls.Add(this.btn_Citizen);
            this.panel3.Controls.Add(this.btn_TrangChu);
            this.panel3.Controls.Add(this.btn_Family);
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 533);
            this.panel3.TabIndex = 2;
            // 
            // btn_Employment
            // 
            this.btn_Employment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_Employment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Employment.FlatAppearance.BorderSize = 0;
            this.btn_Employment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employment.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employment.ForeColor = System.Drawing.Color.White;
            this.btn_Employment.Image = ((System.Drawing.Image)(resources.GetObject("btn_Employment.Image")));
            this.btn_Employment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employment.Location = new System.Drawing.Point(0, 204);
            this.btn_Employment.Name = "btn_Employment";
            this.btn_Employment.Size = new System.Drawing.Size(201, 45);
            this.btn_Employment.TabIndex = 14;
            this.btn_Employment.Text = "Công việc";
            this.btn_Employment.UseVisualStyleBackColor = false;
            // 
            // btn_Education
            // 
            this.btn_Education.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_Education.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Education.FlatAppearance.BorderSize = 0;
            this.btn_Education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Education.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Education.ForeColor = System.Drawing.Color.White;
            this.btn_Education.Image = ((System.Drawing.Image)(resources.GetObject("btn_Education.Image")));
            this.btn_Education.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Education.Location = new System.Drawing.Point(0, 153);
            this.btn_Education.Name = "btn_Education";
            this.btn_Education.Size = new System.Drawing.Size(201, 45);
            this.btn_Education.TabIndex = 13;
            this.btn_Education.Text = "Giáo dục";
            this.btn_Education.UseVisualStyleBackColor = false;
            // 
            // btn_Family
            // 
            this.btn_Family.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_Family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Family.FlatAppearance.BorderSize = 0;
            this.btn_Family.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Family.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Family.ForeColor = System.Drawing.Color.White;
            this.btn_Family.Image = ((System.Drawing.Image)(resources.GetObject("btn_Family.Image")));
            this.btn_Family.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Family.Location = new System.Drawing.Point(0, 102);
            this.btn_Family.Name = "btn_Family";
            this.btn_Family.Size = new System.Drawing.Size(201, 45);
            this.btn_Family.TabIndex = 7;
            this.btn_Family.Text = "Gia đình";
            this.btn_Family.UseVisualStyleBackColor = false;
            this.btn_Family.Click += new System.EventHandler(this.btn_Family_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.duongthang2);
            this.panel2.Controls.Add(this.duongthang1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 648);
            this.panel2.TabIndex = 4;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 603);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(201, 45);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "Đăng xuất";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // duongthang2
            // 
            this.duongthang2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.duongthang2.Location = new System.Drawing.Point(0, 573);
            this.duongthang2.Name = "duongthang2";
            this.duongthang2.Size = new System.Drawing.Size(235, 34);
            this.duongthang2.TabIndex = 3;
            this.duongthang2.Text = "label2";
            // 
            // duongthang1
            // 
            this.duongthang1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.duongthang1.Location = new System.Drawing.Point(0, 0);
            this.duongthang1.Name = "duongthang1";
            this.duongthang1.Size = new System.Drawing.Size(235, 34);
            this.duongthang1.TabIndex = 1;
            this.duongthang1.Text = "label2";
            // 
            // lblID_NV
            // 
            this.lblID_NV.AutoSize = true;
            this.lblID_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_NV.ForeColor = System.Drawing.Color.White;
            this.lblID_NV.Location = new System.Drawing.Point(351, 9);
            this.lblID_NV.Name = "lblID_NV";
            this.lblID_NV.Size = new System.Drawing.Size(62, 21);
            this.lblID_NV.TabIndex = 4;
            this.lblID_NV.Text = "label3";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(1169, 12);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(54, 21);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "label4";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(351, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblID_NV);
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 54);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button btn_Citizen;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label duongthang2;
        private System.Windows.Forms.Label duongthang1;
        public System.Windows.Forms.Label lblID_NV;
        private System.Windows.Forms.Label lbl_Time;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Employment;
        private System.Windows.Forms.Button btn_Education;
        private System.Windows.Forms.Button btn_Family;
        private System.Windows.Forms.Button btn_LogOut;
    }
}

