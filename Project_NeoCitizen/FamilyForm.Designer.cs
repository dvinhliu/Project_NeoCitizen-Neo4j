
namespace Project_NeoCitizen
{
    partial class FamilyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyForm));
            this.dgv_Family = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AddFamily = new System.Windows.Forms.Button();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_SearchFamily = new System.Windows.Forms.TextBox();
            this.txt_Familyname = new System.Windows.Forms.TextBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDFamily = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Family)).BeginInit();
            this.grpBox_Search.SuspendLayout();
            this.grpBox_TK.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Family
            // 
            this.dgv_Family.AllowUserToAddRows = false;
            this.dgv_Family.AllowUserToResizeColumns = false;
            this.dgv_Family.AllowUserToResizeRows = false;
            this.dgv_Family.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Family.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Family.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Family.ColumnHeadersHeight = 30;
            this.dgv_Family.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Details,
            this.Edit,
            this.Delete});
            this.dgv_Family.EnableHeadersVisualStyles = false;
            this.dgv_Family.Location = new System.Drawing.Point(1, 220);
            this.dgv_Family.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Family.Name = "dgv_Family";
            this.dgv_Family.ReadOnly = true;
            this.dgv_Family.RowHeadersWidth = 51;
            this.dgv_Family.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Family.RowTemplate.Height = 24;
            this.dgv_Family.Size = new System.Drawing.Size(1147, 439);
            this.dgv_Family.TabIndex = 7;
            this.dgv_Family.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Family_CellContentClickAsync);
            this.dgv_Family.SelectionChanged += new System.EventHandler(this.dgv_Family_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Gia Đình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Gia Đình";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Danh sách gia đình";
            // 
            // btn_AddFamily
            // 
            this.btn_AddFamily.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddFamily.FlatAppearance.BorderSize = 0;
            this.btn_AddFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFamily.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFamily.ForeColor = System.Drawing.Color.White;
            this.btn_AddFamily.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddFamily.Image")));
            this.btn_AddFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddFamily.Location = new System.Drawing.Point(858, 129);
            this.btn_AddFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddFamily.Name = "btn_AddFamily";
            this.btn_AddFamily.Size = new System.Drawing.Size(123, 30);
            this.btn_AddFamily.TabIndex = 27;
            this.btn_AddFamily.Text = "Thêm";
            this.btn_AddFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddFamily.UseVisualStyleBackColor = false;
            this.btn_AddFamily.Click += new System.EventHandler(this.btn_AddFamily_Click);
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
            this.btn_ResetSearch.Click += new System.EventHandler(this.btn_ResetSearch_Click);
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
            // txt_SearchFamily
            // 
            this.txt_SearchFamily.Location = new System.Drawing.Point(435, 41);
            this.txt_SearchFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchFamily.Name = "txt_SearchFamily";
            this.txt_SearchFamily.Size = new System.Drawing.Size(353, 29);
            this.txt_SearchFamily.TabIndex = 11;
            this.txt_SearchFamily.TextChanged += new System.EventHandler(this.txt_SearchFamily_TextChangedAsync);
            // 
            // txt_Familyname
            // 
            this.txt_Familyname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Familyname.Location = new System.Drawing.Point(189, 50);
            this.txt_Familyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Familyname.Name = "txt_Familyname";
            this.txt_Familyname.ReadOnly = true;
            this.txt_Familyname.Size = new System.Drawing.Size(169, 29);
            this.txt_Familyname.TabIndex = 32;
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchFamily);
            this.grpBox_Search.Location = new System.Drawing.Point(23, 88);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Size = new System.Drawing.Size(811, 98);
            this.grpBox_Search.TabIndex = 25;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Gia Đình";
            // 
            // txt_IDFamily
            // 
            this.txt_IDFamily.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDFamily.Location = new System.Drawing.Point(23, 50);
            this.txt_IDFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDFamily.Name = "txt_IDFamily";
            this.txt_IDFamily.ReadOnly = true;
            this.txt_IDFamily.Size = new System.Drawing.Size(124, 29);
            this.txt_IDFamily.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Gia Đình";
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_Address);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.btn_AddFamily);
            this.grpBox_TK.Controls.Add(this.btn_ResetSearch);
            this.grpBox_TK.Controls.Add(this.txt_Familyname);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDFamily);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(1, 7);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1147, 191);
            this.grpBox_TK.TabIndex = 5;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý gia đình";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Address.Location = new System.Drawing.Point(388, 50);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(446, 29);
            this.txt_Address.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Địa Chỉ";
            // 
            // FamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.dgv_Family);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpBox_TK);
            this.Name = "FamilyForm";
            this.Text = "FamilyForm";
            this.Load += new System.EventHandler(this.FamilyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Family)).EndInit();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_Family;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AddFamily;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_SearchFamily;
        private System.Windows.Forms.TextBox txt_Familyname;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label3;
    }
}