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
    public partial class EmploymentForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public EmploymentForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }
        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_Employment.Columns)
            {
                if (col.CellType != typeof(DataGridViewImageCell))
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }

        public async void GetDataEmpl()
        {
            try
            {
                dgv_Employment.Rows.Clear(); 

                var lstempl = await neo4JConnection.GetAllEmploymentAsync();

                // Đợi kết quả từ lstempl
                foreach (var empl in lstempl)
                {
                    dgv_Employment.Rows.Add(empl.EmploymentID, empl.Company, empl.Position, empl.StartDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmploymentForm_Load(object sender, EventArgs e)
        {
            GetDataEmpl();
            LoadCBBSort();
        }

        private void dgv_Employment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Employment.SelectedRows.Count > 0)
            {
                txt_IDEmployment.Text = dgv_Employment.CurrentRow.Cells[0].Value.ToString();
                txt_Company.Text = dgv_Employment.CurrentRow.Cells[1].Value.ToString();
                txt_Possition.Text = dgv_Employment.CurrentRow.Cells[2].Value.ToString();
                txt_StarDate.Text = dgv_Employment.CurrentRow.Cells[3].Value.ToString();
                dgv_Employment.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDEmployment.Clear();
                txt_Company.Clear();
                txt_Possition.Clear();
                txt_StarDate.Clear();
                dgv_Employment.Cursor = Cursors.Default;
            }
        }

        private async void txt_SearchEmployment_TextChangedAsync(object sender, EventArgs e)
        {
            string search = txt_SearchEmployment.Text.Trim();
            if (cbb_sortsearch.Text != "")
            {
                if (search == "")
                {
                    dgv_Employment.Rows.Clear();
                    GetDataEmpl();
                }
                else
                {
                    try
                    {
                        var employments = await neo4JConnection.SearchEmploymentAsync(search, cbb_sortsearch.SelectedItem.ToString());

                        dgv_Employment.Rows.Clear();

                        foreach (var empl in employments)
                        {
                            dgv_Employment.Rows.Clear();
                            dgv_Employment.Rows.Add(empl.EmploymentID, empl.Company, empl.Position, empl.StartDate);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm công việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_ResetEmployment_Click(object sender, EventArgs e)
        {
            txt_SearchEmployment.Clear();
        }

        private async void dgv_Employment_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Employment.Columns[e.ColumnIndex].Name;
            if (colName == "Details")
            {
                EmploymentModule module = new EmploymentModule(this);
                module.isDetail = true;
                module.txt_IDEmpl.Text = dgv_Employment.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenCTy.Text = dgv_Employment.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_VT.Text = dgv_Employment.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_NVL.Text = dgv_Employment.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.ShowDialog();
            }
            else if (colName == "Edit")
            {
                EmploymentModule module = new EmploymentModule(this);
                module.txt_IDEmpl.Text = dgv_Employment.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenCTy.Text = dgv_Employment.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_VT.Text = dgv_Employment.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_NVL.Text = dgv_Employment.Rows[e.RowIndex].Cells[3].Value.ToString();
               
                module.txt_IDEmpl.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa công việc này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var emplid = dgv_Employment.Rows[e.RowIndex].Cells[0].Value.ToString();

                        await neo4JConnection.DeleteEmploymentWithManagerAsync(emplid);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetDataEmpl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_AddEmployment_Click(object sender, EventArgs e)
        {
            EmploymentModule module = new EmploymentModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }
    }
}
