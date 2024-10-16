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

        private async void txt_SearchAddress_TextChangedAsync(object sender, EventArgs e)
        {
            string search = txt_SearchAddress.Text.Trim();
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
                        var lstadrs = await neo4JConnection.SearchAddressAsync(search, cbb_sortsearch.SelectedItem.ToString());

                        dgv_Address.Rows.Clear();

                        foreach (var address in lstadrs)
                        {
                            dgv_Address.Rows.Add(address.AddressID, address.Street, address.Ward, address.District, address.City, address.Country);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm địa chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbb_sortsearch.SelectedIndex = -1;
            txt_SearchAddress.Clear();
        }

        private void btn_AddAdrs_Click(object sender, EventArgs e)
        {
            AddressModule module = new AddressModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private async void dgv_Address_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Address.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AddressModule module = new AddressModule(this);
                module.txt_IDA.Text = dgv_Address.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_Street.Text = dgv_Address.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_Ward.Text = dgv_Address.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_District.Text = dgv_Address.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_City.Text = dgv_Address.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txt_Country.Text = dgv_Address.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.txt_IDA.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa địa chỉ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var addressid = dgv_Address.Rows[e.RowIndex].Cells[0].Value.ToString();

                        await neo4JConnection.DeleteAddressWithManagerAsync(addressid);

                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa địa chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
