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
    public partial class FamilyModule : Form
    {
        public bool isAddMode = false;
        private readonly Neo4jConnection neo4JConnection;
        FamilyForm fm;
        public FamilyModule(FamilyForm f)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            fm = f;
        }

        public void UpdateButtonState()
        {
            if (isAddMode)
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN GIA ĐÌNH";
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN GIA ĐÌNH";
            }
        }
        public void Clear()
        {
            txt_FN.Clear();
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_IDF.Text) && !string.IsNullOrEmpty(txt_FN.Text))
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
                if (MessageBox.Show("Bạn có chắc muốn thêm gia đình này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var familyname = txt_FN.Text.Trim();

                        await neo4JConnection.AddFamilyWithManagerAsync(familyname);

                        MessageBox.Show("Thêm Gia Đình Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
                        Clear();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                if (MessageBox.Show("Bạn có chắc muốn sửa gia đình này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var familyId = txt_IDF.Text.Trim();
                        var familyName = txt_FN.Text.Trim();
                        
                        await neo4JConnection.EditFamilyWithManagerAsync(familyId, familyName);

                        MessageBox.Show("Cập Nhật Gia Đình Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void FamilyModule_LoadAsync(object sender, EventArgs e)
        {
            UpdateButtonState();
            txt_IDF.Text = await neo4JConnection.GetNextFamilyIDAsync();
        }
    }
}
