
namespace Project_NeoCitizen
{
    partial class DetailFamilyModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailFamilyModule));
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstB_InTV = new System.Windows.Forms.ListBox();
            this.grp_TV = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsB_OutTV = new System.Windows.Forms.ListBox();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grp_TV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(643, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 27);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 27);
            this.panel1.TabIndex = 50;
            // 
            // lstB_InTV
            // 
            this.lstB_InTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstB_InTV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstB_InTV.FormattingEnabled = true;
            this.lstB_InTV.ItemHeight = 21;
            this.lstB_InTV.Location = new System.Drawing.Point(3, 25);
            this.lstB_InTV.Name = "lstB_InTV";
            this.lstB_InTV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstB_InTV.Size = new System.Drawing.Size(262, 352);
            this.lstB_InTV.TabIndex = 51;
            // 
            // grp_TV
            // 
            this.grp_TV.Controls.Add(this.lstB_InTV);
            this.grp_TV.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TV.Location = new System.Drawing.Point(12, 42);
            this.grp_TV.Name = "grp_TV";
            this.grp_TV.Size = new System.Drawing.Size(268, 380);
            this.grp_TV.TabIndex = 53;
            this.grp_TV.TabStop = false;
            this.grp_TV.Text = "Thành viên trong gia đình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsB_OutTV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(407, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 377);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công dân khác";
            // 
            // lsB_OutTV
            // 
            this.lsB_OutTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsB_OutTV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsB_OutTV.FormattingEnabled = true;
            this.lsB_OutTV.ItemHeight = 21;
            this.lsB_OutTV.Location = new System.Drawing.Point(3, 25);
            this.lsB_OutTV.Name = "lsB_OutTV";
            this.lsB_OutTV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsB_OutTV.Size = new System.Drawing.Size(256, 349);
            this.lsB_OutTV.TabIndex = 51;
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(308, 187);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(75, 36);
            this.btn_Left.TabIndex = 55;
            this.btn_Left.Text = "<";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_ClickAsync);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(308, 258);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(75, 36);
            this.btn_Right.TabIndex = 56;
            this.btn_Right.Text = ">";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_ClickAsync);
            // 
            // DetailFamilyModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_TV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailFamilyModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailFamilyForm";
            this.panel1.ResumeLayout(false);
            this.grp_TV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstB_InTV;
        private System.Windows.Forms.GroupBox grp_TV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsB_OutTV;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
    }
}