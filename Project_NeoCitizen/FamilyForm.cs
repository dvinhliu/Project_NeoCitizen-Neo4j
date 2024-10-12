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
    public partial class FamilyForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public FamilyForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }
        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_Family.Columns)
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
                var families = neo4JConnection.GetAllFamilyWithAddressAsync();

                dgv_Family.Rows.Clear();

                foreach (var family in await families)
                {
                    dgv_Family.Rows.Add(family.FamilyID, family.FamilyName, family.Address.GetFullAddress());
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FamilyForm_Load(object sender, EventArgs e)
        {
            GetData();
            LoadCBBSort();
        }

        private void dgv_Family_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Family.SelectedRows.Count > 0)
            {
                txt_IDFamily.Text = dgv_Family.CurrentRow.Cells[0].Value.ToString();
                txt_Familyname.Text = dgv_Family.CurrentRow.Cells[1].Value.ToString();
                txt_Address.Text = dgv_Family.CurrentRow.Cells[2].Value.ToString();
                dgv_Family.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDFamily.Clear();
                txt_Familyname.Clear();
                txt_Address.Clear();
                dgv_Family.Cursor = Cursors.Default;
            }
        }

        private async void txt_SearchFamily_TextChangedAsync(object sender, EventArgs e)
        {
            string search = txt_SearchFamily.Text.Trim();
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
                        var familes = await neo4JConnection.SearchFamilyAsync(search, cbb_sortsearch.SelectedItem.ToString());

                        dgv_Family.Rows.Clear();

                        foreach (var family in familes)
                        {
                            dgv_Family.Rows.Add(family.FamilyID, family.FamilyName);
                        }    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_SearchFamily.Clear();
        }

        private async void dgv_Family_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Family.Columns[e.ColumnIndex].Name;
            if (colName == "Details")
            {
                string familyID = dgv_Family.Rows[e.RowIndex].Cells[0].Value.ToString();
                DetailFamilyModule module = new DetailFamilyModule(familyID);
                module.ShowDialog();
            }    
            else if (colName == "Edit")
            {
                FamilyModule module = new FamilyModule(this);
                module.txt_IDF.Text = dgv_Family.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_FN.Text = dgv_Family.Rows[e.RowIndex].Cells[1].Value.ToString();
                var addressValue = dgv_Family.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (module.cbb_FullAdrs.Items.Contains(addressValue))
                {
                    module.cbb_FullAdrs.SelectedItem = addressValue;
                }
                else
                {
                    module.cbb_FullAdrs.Items.Add(addressValue);
                    module.cbb_FullAdrs.SelectedItem = addressValue;
                }
                module.txt_IDF.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var familyid = dgv_Family.Rows[e.RowIndex].Cells[0].Value.ToString();

                        await neo4JConnection.DeleteFamilyWithManagerAsync(familyid);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_AddFamily_Click(object sender, EventArgs e)
        {
            FamilyModule module = new FamilyModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }
    }
}
