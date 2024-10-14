
namespace Project_NeoCitizen
{
    partial class EmploymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmploymentForm));
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Employment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_IDEmployment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_StarDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Possition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddEmployment = new System.Windows.Forms.Button();
            this.btn_ResetEmployment = new System.Windows.Forms.Button();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.txt_SearchEmployment = new System.Windows.Forms.TextBox();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employment)).BeginInit();
            this.grpBox_Search.SuspendLayout();
            this.grpBox_TK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách công việc";
            // 
            // dgv_Employment
            // 
            this.dgv_Employment.AllowUserToAddRows = false;
            this.dgv_Employment.AllowUserToResizeColumns = false;
            this.dgv_Employment.AllowUserToResizeRows = false;
            this.dgv_Employment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Employment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employment.ColumnHeadersHeight = 30;
            this.dgv_Employment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Employment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Details,
            this.Edit,
            this.Delete});
            this.dgv_Employment.EnableHeadersVisualStyles = false;
            this.dgv_Employment.Location = new System.Drawing.Point(4, 216);
            this.dgv_Employment.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Employment.Name = "dgv_Employment";
            this.dgv_Employment.ReadOnly = true;
            this.dgv_Employment.RowHeadersWidth = 51;
            this.dgv_Employment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Employment.RowTemplate.Height = 24;
            this.dgv_Employment.Size = new System.Drawing.Size(860, 357);
            this.dgv_Employment.TabIndex = 13;
            this.dgv_Employment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employment_CellContentClickAsync);
            this.dgv_Employment.SelectionChanged += new System.EventHandler(this.dgv_Employment_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Công Việc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Công Ty";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vị Trí";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Ngày Bắt Đầu Làm Việc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 60;
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
            // txt_IDEmployment
            // 
            this.txt_IDEmployment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDEmployment.Location = new System.Drawing.Point(17, 41);
            this.txt_IDEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDEmployment.Name = "txt_IDEmployment";
            this.txt_IDEmployment.ReadOnly = true;
            this.txt_IDEmployment.Size = new System.Drawing.Size(94, 25);
            this.txt_IDEmployment.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Công Việc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm theo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Công Ty";
            // 
            // cbb_sortsearch
            // 
            this.cbb_sortsearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbb_sortsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sortsearch.FormattingEnabled = true;
            this.cbb_sortsearch.Location = new System.Drawing.Point(124, 33);
            this.cbb_sortsearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_sortsearch.Name = "cbb_sortsearch";
            this.cbb_sortsearch.Size = new System.Drawing.Size(128, 25);
            this.cbb_sortsearch.TabIndex = 12;
            // 
            // txt_StarDate
            // 
            this.txt_StarDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_StarDate.Location = new System.Drawing.Point(643, 41);
            this.txt_StarDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StarDate.Name = "txt_StarDate";
            this.txt_StarDate.ReadOnly = true;
            this.txt_StarDate.Size = new System.Drawing.Size(140, 25);
            this.txt_StarDate.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày bắt đầu làm việc";
            // 
            // txt_Possition
            // 
            this.txt_Possition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Possition.Location = new System.Drawing.Point(421, 41);
            this.txt_Possition.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Possition.Name = "txt_Possition";
            this.txt_Possition.ReadOnly = true;
            this.txt_Possition.Size = new System.Drawing.Size(193, 25);
            this.txt_Possition.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vị Trí";
            // 
            // btn_AddEmployment
            // 
            this.btn_AddEmployment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddEmployment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddEmployment.FlatAppearance.BorderSize = 0;
            this.btn_AddEmployment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEmployment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEmployment.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployment.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEmployment.Image")));
            this.btn_AddEmployment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEmployment.Location = new System.Drawing.Point(644, 105);
            this.btn_AddEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddEmployment.Name = "btn_AddEmployment";
            this.btn_AddEmployment.Size = new System.Drawing.Size(92, 24);
            this.btn_AddEmployment.TabIndex = 27;
            this.btn_AddEmployment.Text = "Thêm";
            this.btn_AddEmployment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddEmployment.UseVisualStyleBackColor = false;
            this.btn_AddEmployment.Click += new System.EventHandler(this.btn_AddEmployment_Click);
            // 
            // btn_ResetEmployment
            // 
            this.btn_ResetEmployment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ResetEmployment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetEmployment.FlatAppearance.BorderSize = 0;
            this.btn_ResetEmployment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetEmployment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetEmployment.ForeColor = System.Drawing.Color.White;
            this.btn_ResetEmployment.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetEmployment.Image")));
            this.btn_ResetEmployment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetEmployment.Location = new System.Drawing.Point(753, 105);
            this.btn_ResetEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetEmployment.Name = "btn_ResetEmployment";
            this.btn_ResetEmployment.Size = new System.Drawing.Size(92, 24);
            this.btn_ResetEmployment.TabIndex = 26;
            this.btn_ResetEmployment.Text = "Làm mới";
            this.btn_ResetEmployment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetEmployment.UseVisualStyleBackColor = false;
            this.btn_ResetEmployment.Click += new System.EventHandler(this.btn_ResetEmployment_Click);
            // 
            // txt_Company
            // 
            this.txt_Company.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Company.Location = new System.Drawing.Point(136, 41);
            this.txt_Company.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.ReadOnly = true;
            this.txt_Company.Size = new System.Drawing.Size(253, 25);
            this.txt_Company.TabIndex = 32;
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchEmployment);
            this.grpBox_Search.Location = new System.Drawing.Point(17, 72);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox_Search.Size = new System.Drawing.Size(608, 80);
            this.grpBox_Search.TabIndex = 25;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Tìm kiếm";
            // 
            // txt_SearchEmployment
            // 
            this.txt_SearchEmployment.Location = new System.Drawing.Point(326, 33);
            this.txt_SearchEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SearchEmployment.Name = "txt_SearchEmployment";
            this.txt_SearchEmployment.Size = new System.Drawing.Size(266, 25);
            this.txt_SearchEmployment.TabIndex = 11;
            this.txt_SearchEmployment.TextChanged += new System.EventHandler(this.txt_SearchEmployment_TextChangedAsync);
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_StarDate);
            this.grpBox_TK.Controls.Add(this.label4);
            this.grpBox_TK.Controls.Add(this.txt_Possition);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.btn_AddEmployment);
            this.grpBox_TK.Controls.Add(this.btn_ResetEmployment);
            this.grpBox_TK.Controls.Add(this.txt_Company);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDEmployment);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(5, 11);
            this.grpBox_TK.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox_TK.Size = new System.Drawing.Size(860, 155);
            this.grpBox_TK.TabIndex = 11;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý công việc";
            // 
            // EmploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 584);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Employment);
            this.Controls.Add(this.grpBox_TK);
            this.Name = "EmploymentForm";
            this.Text = "EmploymentForm";
            this.Load += new System.EventHandler(this.EmploymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employment)).EndInit();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgv_Employment;
        private System.Windows.Forms.TextBox txt_IDEmployment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_StarDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Possition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddEmployment;
        private System.Windows.Forms.Button btn_ResetEmployment;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.TextBox txt_SearchEmployment;
        private System.Windows.Forms.GroupBox grpBox_TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}