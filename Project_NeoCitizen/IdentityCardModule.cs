using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NeoCitizen
{
    public partial class IdentityCardModule : Form
    {
        public bool isAddMode = false;
        private readonly Neo4jConnection neo4JConnection;
        IdentityCardForm fm;
        public IdentityCardModule(IdentityCardForm f)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            fm = f;
        }

        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txt_IDCCCD.Text = await neo4JConnection.GetNextIdentityCardIDAsync();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN CCCD";
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN CCCD";
            }
        }
        public void Clear()
        { 
            txt_SoCCCD.Clear();
            txt_NgayCap.Clear();
            txt_NHH.Clear();
            txt_CB.Clear();
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_IDCCCD.Text) && !string.IsNullOrEmpty(txt_SoCCCD.Text) && !string.IsNullOrEmpty(txt_NgayCap.Text) && !string.IsNullOrEmpty(txt_NHH.Text) && !string.IsNullOrEmpty(txt_CB.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void btn_them_ClickAsync(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm CCCD này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var idCard = txt_IDCCCD.Text.Trim();
                        var idNum = txt_SoCCCD.Text.Trim();
                        var IssueDate = txt_NgayCap.Text.Trim();
                        var ExDate = txt_NHH.Text.Trim();
                        var IssueBy = txt_CB.Text.Trim();

                        await neo4JConnection.AddIdentityCardAsync(idCard, idNum, IssueDate, ExDate, IssueBy);

                        MessageBox.Show("Thêm CCCD Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
                        Clear();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_sua_ClickAsync(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa CCCD này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var idCard = txt_IDCCCD.Text.Trim();
                        var idNum = txt_SoCCCD.Text.Trim();
                        var IssueDate = txt_NgayCap.Text.Trim();
                        var ExDate = txt_NHH.Text.Trim();
                        var IssueBy = txt_CB.Text.Trim();

                        await neo4JConnection.EditIdentityCardAsync(idCard, idNum, IssueDate, ExDate, IssueBy);

                        MessageBox.Show("Cập Nhật CCCD Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void FamilyModule_LoadAsync(object sender, EventArgs e)
        {
            UpdateButtonStateAsync();
        }
    }
}
