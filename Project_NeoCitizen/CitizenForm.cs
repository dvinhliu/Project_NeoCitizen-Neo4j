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
                var lstcitizen = neo4JConnection.GetAllCitizenAsync();

                dgv_Citizen.Rows.Clear();

                foreach (var citizen in await lstcitizen)
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
    }
}
