
namespace Project_NeoCitizen
{
    partial class CitizenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitizenForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.btn_AddCitizen = new System.Windows.Forms.Button();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.txt_Citizenname = new System.Windows.Forms.TextBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_SearchCitizen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDCitizen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Citizen = new System.Windows.Forms.DataGridView();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBox_TK.SuspendLayout();
            this.grpBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citizen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_phone);
            this.grpBox_TK.Controls.Add(this.label5);
            this.grpBox_TK.Controls.Add(this.txt_gender);
            this.grpBox_TK.Controls.Add(this.label4);
            this.grpBox_TK.Controls.Add(this.txt_dob);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.btn_AddCitizen);
            this.grpBox_TK.Controls.Add(this.btn_ResetSearch);
            this.grpBox_TK.Controls.Add(this.txt_Citizenname);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDCitizen);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(1, 7);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1147, 191);
            this.grpBox_TK.TabIndex = 8;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý công dân";
            // 
            // btn_AddCitizen
            // 
            this.btn_AddCitizen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddCitizen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCitizen.FlatAppearance.BorderSize = 0;
            this.btn_AddCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCitizen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCitizen.ForeColor = System.Drawing.Color.White;
            this.btn_AddCitizen.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCitizen.Image")));
            this.btn_AddCitizen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddCitizen.Location = new System.Drawing.Point(858, 129);
            this.btn_AddCitizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCitizen.Name = "btn_AddCitizen";
            this.btn_AddCitizen.Size = new System.Drawing.Size(123, 30);
            this.btn_AddCitizen.TabIndex = 27;
            this.btn_AddCitizen.Text = "Thêm";
            this.btn_AddCitizen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddCitizen.UseVisualStyleBackColor = false;
            // 
            // btn_ResetSearch
            // 
            this.btn_ResetSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ResetSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetSearch.FlatAppearance.BorderSize = 0;
            this.btn_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetSearch.Image")));
            this.btn_ResetSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetSearch.Location = new System.Drawing.Point(1004, 129);
            this.btn_ResetSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ResetSearch.Name = "btn_ResetSearch";
            this.btn_ResetSearch.Size = new System.Drawing.Size(123, 30);
            this.btn_ResetSearch.TabIndex = 26;
            this.btn_ResetSearch.Text = "Làm mới";
            this.btn_ResetSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetSearch.UseVisualStyleBackColor = false;
            // 
            // txt_Citizenname
            // 
            this.txt_Citizenname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Citizenname.Location = new System.Drawing.Point(182, 50);
            this.txt_Citizenname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Citizenname.Name = "txt_Citizenname";
            this.txt_Citizenname.ReadOnly = true;
            this.txt_Citizenname.Size = new System.Drawing.Size(169, 29);
            this.txt_Citizenname.TabIndex = 32;
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchCitizen);
            this.grpBox_Search.Location = new System.Drawing.Point(23, 88);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Size = new System.Drawing.Size(811, 98);
            this.grpBox_Search.TabIndex = 25;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm theo :";
            // 
            // cbb_sortsearch
            // 
            this.cbb_sortsearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbb_sortsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sortsearch.FormattingEnabled = true;
            this.cbb_sortsearch.Location = new System.Drawing.Point(165, 41);
            this.cbb_sortsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_sortsearch.Name = "cbb_sortsearch";
            this.cbb_sortsearch.Size = new System.Drawing.Size(169, 30);
            this.cbb_sortsearch.TabIndex = 12;
            // 
            // txt_SearchCitizen
            // 
            this.txt_SearchCitizen.Location = new System.Drawing.Point(435, 41);
            this.txt_SearchCitizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchCitizen.Name = "txt_SearchCitizen";
            this.txt_SearchCitizen.Size = new System.Drawing.Size(353, 29);
            this.txt_SearchCitizen.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Công Dân";
            // 
            // txt_IDCitizen
            // 
            this.txt_IDCitizen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDCitizen.Location = new System.Drawing.Point(23, 50);
            this.txt_IDCitizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDCitizen.Name = "txt_IDCitizen";
            this.txt_IDCitizen.ReadOnly = true;
            this.txt_IDCitizen.Size = new System.Drawing.Size(124, 29);
            this.txt_IDCitizen.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Công Dân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh sách công dân";
            // 
            // dgv_Citizen
            // 
            this.dgv_Citizen.AllowUserToAddRows = false;
            this.dgv_Citizen.AllowUserToResizeColumns = false;
            this.dgv_Citizen.AllowUserToResizeRows = false;
            this.dgv_Citizen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Citizen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Citizen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Citizen.ColumnHeadersHeight = 30;
            this.dgv_Citizen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Citizen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Details,
            this.Edit,
            this.Delete});
            this.dgv_Citizen.EnableHeadersVisualStyles = false;
            this.dgv_Citizen.Location = new System.Drawing.Point(1, 220);
            this.dgv_Citizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Citizen.Name = "dgv_Citizen";
            this.dgv_Citizen.ReadOnly = true;
            this.dgv_Citizen.RowHeadersWidth = 51;
            this.dgv_Citizen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Citizen.RowTemplate.Height = 24;
            this.dgv_Citizen.Size = new System.Drawing.Size(1147, 439);
            this.dgv_Citizen.TabIndex = 10;
            this.dgv_Citizen.SelectionChanged += new System.EventHandler(this.dgv_Citizen_SelectionChanged);
            // 
            // txt_dob
            // 
            this.txt_dob.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_dob.Location = new System.Drawing.Point(386, 50);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.ReadOnly = true;
            this.txt_dob.Size = new System.Drawing.Size(169, 29);
            this.txt_dob.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày Sinh";
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_gender.Location = new System.Drawing.Point(590, 50);
            this.txt_gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(169, 29);
            this.txt_gender.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Giới tính";
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_phone.Location = new System.Drawing.Point(794, 50);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(169, 29);
            this.txt_phone.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(789, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "SĐT";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Công Dân";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Công Dân";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 125;
            // 
            // CitizenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.grpBox_TK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Citizen);
            this.Name = "CitizenForm";
            this.Text = "CitizenForm";
            this.Load += new System.EventHandler(this.CitizenForm_Load);
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citizen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_TK;
        private System.Windows.Forms.Button btn_AddCitizen;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.TextBox txt_Citizenname;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_SearchCitizen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDCitizen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgv_Citizen;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}