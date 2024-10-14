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
    public partial class EmploymentModule : Form
    {
        public bool isAddMode = false;
        public bool isDetail = false;
        private readonly Neo4jConnection neo4JConnection;
        EmploymentForm fm;
        public EmploymentModule(EmploymentForm f)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            fm = f;
        }

        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txt_IDEmpl.Text = await neo4JConnection.GetNextEmploymentIDAsync();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN CÔNG VIỆC";
            }
            else if (isDetail)
            {
                lblTittle.Text = "THÔNG TIN CÔNG VIỆC";
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_huy.Enabled = false;
                btn_them.Visible = false;
                btn_sua.Visible = false;
                btn_huy.Visible = false;

                txt_IDEmpl.Enabled = false;
                txt_TenCTy.Enabled = false;
                txt_NVL.Enabled = false;
                txt_VT.Enabled = false;
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN CÔNG VIỆC";
            }
        }
        public void Clear()
        {
            txt_NVL.Clear();
            txt_TenCTy.Clear();
            txt_VT.Clear();
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_IDEmpl.Text) && !string.IsNullOrEmpty(txt_TenCTy.Text) && !string.IsNullOrEmpty(txt_VT.Text) && !string.IsNullOrEmpty(txt_NVL.Text))
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
                if (MessageBox.Show("Bạn có chắc muốn thêm công việc này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var emplId = txt_IDEmpl.Text.Trim();
                        var company = txt_TenCTy.Text.Trim();
                        var vịtri = txt_VT.Text.Trim();
                        var nvl = txt_NVL.Text.Trim();

                        await neo4JConnection.AddEmploymentAsync(emplId, company, vịtri, nvl);

                        MessageBox.Show("Thêm Công Việc Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetDataEmpl();
                        Clear();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Bạn có chắc muốn sửa công việc này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var emplId = txt_IDEmpl.Text.Trim();
                        var company = txt_TenCTy.Text.Trim();
                        var vịtri = txt_VT.Text.Trim();
                        var nvl = txt_NVL.Text.Trim();

                        await neo4JConnection.EditEmploymentAsync(emplId, company, vịtri, nvl);

                        MessageBox.Show("Cập Nhật Công Việc Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetDataEmpl();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void EmploymentModule_LoadAsync(object sender, EventArgs e)
        {
            UpdateButtonStateAsync();
        }
    }
}
