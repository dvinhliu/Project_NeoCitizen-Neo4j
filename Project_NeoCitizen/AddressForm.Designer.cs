
namespace Project_NeoCitizen
{
    partial class AddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddAdrs = new System.Windows.Forms.Button();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.txt_Adrs = new System.Windows.Forms.TextBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_SearchAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDAdrs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Address = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBox_TK.SuspendLayout();
            this.grpBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(700, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Thành Phố";
            // 
            // txt_district
            // 
            this.txt_district.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_district.Location = new System.Drawing.Point(527, 50);
            this.txt_district.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_district.Name = "txt_district";
            this.txt_district.ReadOnly = true;
            this.txt_district.Size = new System.Drawing.Size(138, 29);
            this.txt_district.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quận";
            // 
            // txt_ward
            // 
            this.txt_ward.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_ward.Location = new System.Drawing.Point(398, 50);
            this.txt_ward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ward.Name = "txt_ward";
            this.txt_ward.ReadOnly = true;
            this.txt_ward.Size = new System.Drawing.Size(88, 29);
            this.txt_ward.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Phường";
            // 
            // txt_city
            // 
            this.txt_city.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_city.Location = new System.Drawing.Point(706, 50);
            this.txt_city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_city.Name = "txt_city";
            this.txt_city.ReadOnly = true;
            this.txt_city.Size = new System.Drawing.Size(169, 29);
            this.txt_city.TabIndex = 38;
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_country);
            this.grpBox_TK.Controls.Add(this.label9);
            this.grpBox_TK.Controls.Add(this.txt_city);
            this.grpBox_TK.Controls.Add(this.label5);
            this.grpBox_TK.Controls.Add(this.txt_district);
            this.grpBox_TK.Controls.Add(this.label4);
            this.grpBox_TK.Controls.Add(this.txt_ward);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.btn_AddAdrs);
            this.grpBox_TK.Controls.Add(this.btn_ResetSearch);
            this.grpBox_TK.Controls.Add(this.txt_Adrs);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDAdrs);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(1, 7);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1147, 191);
            this.grpBox_TK.TabIndex = 11;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý địa chỉ";
            // 
            // txt_country
            // 
            this.txt_country.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_country.Location = new System.Drawing.Point(916, 50);
            this.txt_country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_country.Name = "txt_country";
            this.txt_country.ReadOnly = true;
            this.txt_country.Size = new System.Drawing.Size(169, 29);
            this.txt_country.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(915, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 39;
            this.label9.Text = "Quốc Gia";
            // 
            // btn_AddAdrs
            // 
            this.btn_AddAdrs.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddAdrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddAdrs.FlatAppearance.BorderSize = 0;
            this.btn_AddAdrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAdrs.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAdrs.ForeColor = System.Drawing.Color.White;
            this.btn_AddAdrs.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddAdrs.Image")));
            this.btn_AddAdrs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddAdrs.Location = new System.Drawing.Point(858, 129);
            this.btn_AddAdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddAdrs.Name = "btn_AddAdrs";
            this.btn_AddAdrs.Size = new System.Drawing.Size(123, 30);
            this.btn_AddAdrs.TabIndex = 27;
            this.btn_AddAdrs.Text = "Thêm";
            this.btn_AddAdrs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddAdrs.UseVisualStyleBackColor = false;
            this.btn_AddAdrs.Click += new System.EventHandler(this.btn_AddAdrs_Click);
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
            // txt_Adrs
            // 
            this.txt_Adrs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Adrs.Location = new System.Drawing.Point(188, 50);
            this.txt_Adrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adrs.Name = "txt_Adrs";
            this.txt_Adrs.ReadOnly = true;
            this.txt_Adrs.Size = new System.Drawing.Size(169, 29);
            this.txt_Adrs.TabIndex = 32;
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchAddress);
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
            // txt_SearchAddress
            // 
            this.txt_SearchAddress.Location = new System.Drawing.Point(435, 41);
            this.txt_SearchAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchAddress.Name = "txt_SearchAddress";
            this.txt_SearchAddress.Size = new System.Drawing.Size(353, 29);
            this.txt_SearchAddress.TabIndex = 11;
            this.txt_SearchAddress.TextChanged += new System.EventHandler(this.txt_SearchAddress_TextChangedAsync);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Địa Chỉ";
            // 
            // txt_IDAdrs
            // 
            this.txt_IDAdrs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDAdrs.Location = new System.Drawing.Point(23, 50);
            this.txt_IDAdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDAdrs.Name = "txt_IDAdrs";
            this.txt_IDAdrs.ReadOnly = true;
            this.txt_IDAdrs.Size = new System.Drawing.Size(124, 29);
            this.txt_IDAdrs.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Địa Chỉ";
            // 
            // dgv_Address
            // 
            this.dgv_Address.AllowUserToAddRows = false;
            this.dgv_Address.AllowUserToResizeColumns = false;
            this.dgv_Address.AllowUserToResizeRows = false;
            this.dgv_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Address.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Address.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Address.ColumnHeadersHeight = 30;
            this.dgv_Address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Address.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Edit,
            this.Delete});
            this.dgv_Address.EnableHeadersVisualStyles = false;
            this.dgv_Address.Location = new System.Drawing.Point(1, 220);
            this.dgv_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Address.Name = "dgv_Address";
            this.dgv_Address.ReadOnly = true;
            this.dgv_Address.RowHeadersWidth = 51;
            this.dgv_Address.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Address.RowTemplate.Height = 24;
            this.dgv_Address.Size = new System.Drawing.Size(1147, 439);
            this.dgv_Address.TabIndex = 13;
            this.dgv_Address.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Address_CellContentClickAsync);
            this.dgv_Address.SelectionChanged += new System.EventHandler(this.dgv_Address_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Địa Chỉ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Địa Chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phường";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quận";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Phố";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quốc Gia";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách địa chỉ";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.grpBox_TK);
            this.Controls.Add(this.dgv_Address);
            this.Controls.Add(this.label7);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.GroupBox grpBox_TK;
        private System.Windows.Forms.Button btn_AddAdrs;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.TextBox txt_Adrs;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_SearchAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDAdrs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}