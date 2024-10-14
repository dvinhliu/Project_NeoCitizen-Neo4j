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
    public partial class CitizenForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;

        public CitizenForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }

        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_Citizen.Columns)
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
                var lstcitizen = await neo4JConnection.GetAllCitizenAsync();
                dgv_Citizen.Rows.Clear();

                foreach (var citizen in lstcitizen)
                {
                    dgv_Citizen.Rows.Add(citizen.CitizenID, citizen.FullName, citizen.DateOfBirth, citizen.Gender, citizen.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CitizenForm_Load(object sender, EventArgs e)
        {
            LoadCBBSort();
            GetData();
        }

        private void dgv_Citizen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Citizen.SelectedRows.Count > 0)
            {
                txt_IDCitizen.Text = dgv_Citizen.CurrentRow.Cells[0].Value.ToString();
                txt_Citizenname.Text = dgv_Citizen.CurrentRow.Cells[1].Value.ToString();
                txt_dob.Text = dgv_Citizen.CurrentRow.Cells[2].Value.ToString();
                txt_gender.Text = dgv_Citizen.CurrentRow.Cells[3].Value.ToString();
                txt_phone.Text = dgv_Citizen.CurrentRow.Cells[4].Value.ToString();
                dgv_Citizen.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDCitizen.Clear();
                txt_Citizenname.Clear();
                txt_dob.Clear();
                txt_gender.Clear();
                txt_phone.Clear();
                dgv_Citizen.Cursor = Cursors.Default;
            }
        }

        private async void txt_SearchCitizen_TextChanged(object sender, EventArgs e)
        {
            string search = txt_SearchCitizen.Text.Trim();

            if (!string.IsNullOrEmpty(cbb_sortsearch.Text))
            {
                if (string.IsNullOrEmpty(search))
                {
                    GetData();
                    return;
                }

                try
                {
                    List<Project_NeoCitizen.Models.Citizen> citizens;

                    switch (cbb_sortsearch.SelectedItem.ToString())
                    {
                        case "ID Công Dân":
                            citizens = await neo4JConnection.SearchCitizenAsync(search, "CitizenID");
                            break;
                        case "Tên Công Dân":
                            citizens = await neo4JConnection.SearchCitizenAsync(search, "FullName");
                            break;
                        case "Ngày Sinh":
                            citizens = await neo4JConnection.SearchCitizenAsync(search, "DateOfBirth");
                            break;
                        case "Giới Tính":
                            citizens = await neo4JConnection.SearchCitizenAsync(search, "Gender");
                            break;
                        case "SĐT":
                            citizens = await neo4JConnection.SearchCitizenAsync(search, "PhoneNumber");
                            break;
                        default:
                            MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }

                    dgv_Citizen.Rows.Clear();
                    foreach (var citizen in citizens)
                    {
                        dgv_Citizen.Rows.Add(citizen.CitizenID, citizen.FullName, citizen.DateOfBirth, citizen.Gender, citizen.PhoneNumber);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_AddCitizen_Click(object sender, EventArgs e)
        {
            CitizenModule module = new CitizenModule(this);
            string newCitizenID = await neo4JConnection.GetNextCitizenIDAsync();
            module.txtIDCD.Text = newCitizenID;
            module.isAddMode = true;
            module.ShowDialog();
        }

        private async void dgv_Citizen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Citizen.Columns[e.ColumnIndex].Name;
            if (colName == "Details")
            {
                string CitizenID = dgv_Citizen.Rows[e.RowIndex].Cells[0].Value.ToString();
                DetailCitizenModule module = new DetailCitizenModule(CitizenID);
                module.ShowDialog();

            }
            else if (colName == "Edit")
            {

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa công dân này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var idcitizen = dgv_Citizen.Rows[e.RowIndex].Cells[0].Value.ToString();

                        await neo4JConnection.DeleteCitizenWithManagerAsync(idcitizen);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
