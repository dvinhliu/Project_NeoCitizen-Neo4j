
namespace Project_NeoCitizen
{
    partial class IdentityCardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentityCardForm));
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_IdentityCard = new System.Windows.Forms.DataGridView();
            this.txt_IDIdentityCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_IssuedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ExpirationDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IssueDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddIdentityCard = new System.Windows.Forms.Button();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.txt_DocumentNumber = new System.Windows.Forms.TextBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.txt_SearchIdentityCard = new System.Windows.Forms.TextBox();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IdentityCard)).BeginInit();
            this.grpBox_Search.SuspendLayout();
            this.grpBox_TK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách công dân";
            // 
            // dgv_IdentityCard
            // 
            this.dgv_IdentityCard.AllowUserToAddRows = false;
            this.dgv_IdentityCard.AllowUserToResizeColumns = false;
            this.dgv_IdentityCard.AllowUserToResizeRows = false;
            this.dgv_IdentityCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_IdentityCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_IdentityCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_IdentityCard.ColumnHeadersHeight = 30;
            this.dgv_IdentityCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_IdentityCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Details,
            this.Edit,
            this.Delete});
            this.dgv_IdentityCard.EnableHeadersVisualStyles = false;
            this.dgv_IdentityCard.Location = new System.Drawing.Point(0, 179);
            this.dgv_IdentityCard.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_IdentityCard.Name = "dgv_IdentityCard";
            this.dgv_IdentityCard.ReadOnly = true;
            this.dgv_IdentityCard.RowHeadersWidth = 51;
            this.dgv_IdentityCard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_IdentityCard.RowTemplate.Height = 24;
            this.dgv_IdentityCard.Size = new System.Drawing.Size(860, 357);
            this.dgv_IdentityCard.TabIndex = 13;
            // 
            // txt_IDIdentityCard
            // 
            this.txt_IDIdentityCard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDIdentityCard.Location = new System.Drawing.Point(17, 41);
            this.txt_IDIdentityCard.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDIdentityCard.Name = "txt_IDIdentityCard";
            this.txt_IDIdentityCard.ReadOnly = true;
            this.txt_IDIdentityCard.Size = new System.Drawing.Size(94, 25);
            this.txt_IDIdentityCard.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã CCCD";
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
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Số CCCD";
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
            // txt_IssuedBy
            // 
            this.txt_IssuedBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IssuedBy.Location = new System.Drawing.Point(596, 41);
            this.txt_IssuedBy.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IssuedBy.Name = "txt_IssuedBy";
            this.txt_IssuedBy.ReadOnly = true;
            this.txt_IssuedBy.Size = new System.Drawing.Size(197, 25);
            this.txt_IssuedBy.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cấp Bởi";
            // 
            // txt_ExpirationDate
            // 
            this.txt_ExpirationDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_ExpirationDate.Location = new System.Drawing.Point(442, 41);
            this.txt_ExpirationDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ExpirationDate.Name = "txt_ExpirationDate";
            this.txt_ExpirationDate.ReadOnly = true;
            this.txt_ExpirationDate.Size = new System.Drawing.Size(128, 25);
            this.txt_ExpirationDate.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày Hết Hạn";
            // 
            // txt_IssueDate
            // 
            this.txt_IssueDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IssueDate.Location = new System.Drawing.Point(290, 41);
            this.txt_IssueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IssueDate.Name = "txt_IssueDate";
            this.txt_IssueDate.ReadOnly = true;
            this.txt_IssueDate.Size = new System.Drawing.Size(128, 25);
            this.txt_IssueDate.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày Cấp Phát";
            // 
            // btn_AddIdentityCard
            // 
            this.btn_AddIdentityCard.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddIdentityCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddIdentityCard.FlatAppearance.BorderSize = 0;
            this.btn_AddIdentityCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddIdentityCard.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddIdentityCard.ForeColor = System.Drawing.Color.White;
            this.btn_AddIdentityCard.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddIdentityCard.Image")));
            this.btn_AddIdentityCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddIdentityCard.Location = new System.Drawing.Point(644, 105);
            this.btn_AddIdentityCard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddIdentityCard.Name = "btn_AddIdentityCard";
            this.btn_AddIdentityCard.Size = new System.Drawing.Size(92, 24);
            this.btn_AddIdentityCard.TabIndex = 27;
            this.btn_AddIdentityCard.Text = "Thêm";
            this.btn_AddIdentityCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddIdentityCard.UseVisualStyleBackColor = false;
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
            this.btn_ResetSearch.Location = new System.Drawing.Point(753, 105);
            this.btn_ResetSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetSearch.Name = "btn_ResetSearch";
            this.btn_ResetSearch.Size = new System.Drawing.Size(92, 24);
            this.btn_ResetSearch.TabIndex = 26;
            this.btn_ResetSearch.Text = "Làm mới";
            this.btn_ResetSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetSearch.UseVisualStyleBackColor = false;
            // 
            // txt_DocumentNumber
            // 
            this.txt_DocumentNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_DocumentNumber.Location = new System.Drawing.Point(136, 41);
            this.txt_DocumentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DocumentNumber.Name = "txt_DocumentNumber";
            this.txt_DocumentNumber.ReadOnly = true;
            this.txt_DocumentNumber.Size = new System.Drawing.Size(128, 25);
            this.txt_DocumentNumber.TabIndex = 32;
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchIdentityCard);
            this.grpBox_Search.Location = new System.Drawing.Point(17, 72);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox_Search.Size = new System.Drawing.Size(608, 80);
            this.grpBox_Search.TabIndex = 25;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Tìm kiếm";
            // 
            // txt_SearchIdentityCard
            // 
            this.txt_SearchIdentityCard.Location = new System.Drawing.Point(326, 33);
            this.txt_SearchIdentityCard.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SearchIdentityCard.Name = "txt_SearchIdentityCard";
            this.txt_SearchIdentityCard.Size = new System.Drawing.Size(266, 25);
            this.txt_SearchIdentityCard.TabIndex = 11;
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_IssuedBy);
            this.grpBox_TK.Controls.Add(this.label5);
            this.grpBox_TK.Controls.Add(this.txt_ExpirationDate);
            this.grpBox_TK.Controls.Add(this.label4);
            this.grpBox_TK.Controls.Add(this.txt_IssueDate);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.btn_AddIdentityCard);
            this.grpBox_TK.Controls.Add(this.btn_ResetSearch);
            this.grpBox_TK.Controls.Add(this.txt_DocumentNumber);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDIdentityCard);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(0, 6);
            this.grpBox_TK.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox_TK.Size = new System.Drawing.Size(860, 155);
            this.grpBox_TK.TabIndex = 11;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý công dân";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Công Dân";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Số CCCD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Cấp Phát";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Hết Hạn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cấp Bởi";
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
            // IdentityCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 542);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_IdentityCard);
            this.Controls.Add(this.grpBox_TK);
            this.Name = "IdentityCardForm";
            this.Text = "IdentityCardForm";
            this.Load += new System.EventHandler(this.IdentityCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IdentityCard)).EndInit();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgv_IdentityCard;
        private System.Windows.Forms.TextBox txt_IDIdentityCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_IssuedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ExpirationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddIdentityCard;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.TextBox txt_DocumentNumber;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.TextBox txt_SearchIdentityCard;
        private System.Windows.Forms.GroupBox grpBox_TK;
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