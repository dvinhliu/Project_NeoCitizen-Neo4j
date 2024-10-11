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
    public partial class AddressForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public AddressForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }
        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_Address.Columns)
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
                var lstaddress = neo4JConnection.GetAllAddressAsync();

                dgv_Address.Rows.Clear();

                foreach (var address in await lstaddress)
                {
                    dgv_Address.Rows.Add(address.AddressID, address.Street, address.Ward, address.District, address.City, address.Country);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu địa chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            LoadCBBSort();
            GetData();
        }

        private void dgv_Address_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Address.SelectedRows.Count > 0)
            {
                txt_IDAdrs.Text = dgv_Address.CurrentRow.Cells[0].Value.ToString();
                txt_Adrs.Text = dgv_Address.CurrentRow.Cells[1].Value.ToString();
                txt_ward.Text = dgv_Address.CurrentRow.Cells[2].Value.ToString();
                txt_district.Text = dgv_Address.CurrentRow.Cells[3].Value.ToString();
                txt_city.Text = dgv_Address.CurrentRow.Cells[4].Value.ToString();
                txt_country.Text = dgv_Address.CurrentRow.Cells[5].Value.ToString();
                dgv_Address.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDAdrs.Clear();
                txt_Adrs.Clear();
                txt_ward.Clear();
                txt_district.Clear();
                txt_city.Clear();
                txt_country.Clear();
                dgv_Address.Cursor = Cursors.Default;
            }
        }
    }
}
