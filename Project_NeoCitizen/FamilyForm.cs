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
                if (col.CellType != typeof(DataGridViewImageCell))
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }
        public async void GetData()
        {
            try
            {
                var families = neo4JConnection.GetAllFamilyAsync();

                dgv_Family.Rows.Clear();

                foreach (var family in await families)
                {
                    dgv_Family.Rows.Add(family.Id, family.FamilyName);
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
                dgv_Family.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDFamily.Clear();
                txt_Familyname.Clear();
                dgv_Family.Cursor = Cursors.Default;
            }
        }

        private void txt_SearchFamily_TextChanged(object sender, EventArgs e)
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
                    if (cbb_sortsearch.SelectedItem.ToString() == "ID Gia Đình")
                    {

                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Tên Gia Đình")
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
