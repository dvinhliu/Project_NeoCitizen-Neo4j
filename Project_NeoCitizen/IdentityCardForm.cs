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
    public partial class IdentityCardForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public IdentityCardForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }

        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_IdentityCard.Columns)
            {
                if (col.CellType != typeof(DataGridViewImageCell) && col.Index != 2)
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }
        public async void GetData()
        {
            try
            {
                var lstInCard = neo4JConnection.GetAllIdentityCardAsync();

                dgv_IdentityCard.Rows.Clear();

                foreach (var inCard in await lstInCard)
                {
                    dgv_IdentityCard.Rows.Add(inCard.IdentityCardID, inCard.DocumentNumber, inCard.IssueDate, inCard.ExpirationDate, inCard.IssuedBy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdentityCardForm_Load(object sender, EventArgs e)
        {
            GetData();
            LoadCBBSort();
        }

        private async void txt_SearchIdentityCard_TextChangedAsync(object sender, EventArgs e)
        {
            string search = txt_SearchIdentityCard.Text.Trim();
            if (cbb_sortsearch.Text != "")
            {
                if (search == "")
                {
                    GetData();
                }
                else
                {
                    try
                    {
                        var identityCards = await neo4JConnection.SearchIdentityCardAsync(search, cbb_sortsearch.SelectedItem.ToString());

                        dgv_IdentityCard.Rows.Clear();

                        foreach (var idCard in identityCards)
                        {
                            dgv_IdentityCard.Rows.Add(idCard.IdentityCardID, idCard.DocumentNumber, idCard.IssueDate, idCard.ExpirationDate, idCard.IssuedBy); ;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            txt_SearchIdentityCard.Clear();
        }

        private async void dgv_IdentityCard_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_IdentityCard.Columns[e.ColumnIndex].Name;
            if (colName == "Details")
            {
                IdentityCardModule module = new IdentityCardModule(this);
                module.isDetail = true;
                module.txt_IDCCCD.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_SoCCCD.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_NgayCap.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_NHH.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_CB.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.ShowDialog();
            }
            else if (colName == "Edit")
            {
                IdentityCardModule module = new IdentityCardModule(this);
                module.txt_IDCCCD.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_SoCCCD.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_NgayCap.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_NHH.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_CB.Text = dgv_IdentityCard.Rows[e.RowIndex].Cells[4].Value.ToString();
               
                module.txt_IDCCCD.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa CCCD này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var idCard = dgv_IdentityCard.Rows[e.RowIndex].Cells[0].Value.ToString();

                        await neo4JConnection.DeleteIdentityCardWithManagerAsync(idCard);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_AddIdentityCard_Click(object sender, EventArgs e)
        {
            IdentityCardModule module = new IdentityCardModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private void dgv_IdentityCard_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_IdentityCard.SelectedRows.Count > 0)
            {
                txt_IDIdentityCard.Text = dgv_IdentityCard.CurrentRow.Cells[0].Value.ToString();
                txt_DocumentNumber.Text = dgv_IdentityCard.CurrentRow.Cells[1].Value.ToString();
                txt_IssueDate.Text = dgv_IdentityCard.CurrentRow.Cells[2].Value.ToString();
                txt_ExpirationDate.Text = dgv_IdentityCard.CurrentRow.Cells[3].Value.ToString();
                txt_IssuedBy.Text = dgv_IdentityCard.CurrentRow.Cells[4].Value.ToString();
                dgv_IdentityCard.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDIdentityCard.Clear();
                txt_DocumentNumber.Clear();
                txt_IssueDate.Clear();
                txt_ExpirationDate.Clear();
                txt_IssuedBy.Clear();
                dgv_IdentityCard.Cursor = Cursors.Default;
            }
        }
    }
    
}
