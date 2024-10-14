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
    public partial class AddressModule : Form
    {
        public bool isAddMode = false;
        private readonly Neo4jConnection neo4JConnection;
        AddressForm adf;
        public AddressModule(AddressForm ad)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            adf = ad;
        }
        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txt_IDA.Text = await neo4JConnection.GetNextAddressIDAsync();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN ĐỊA CHỈ";
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN ĐỊA CHỈ";
            }
        }
        public void Clear()
        {
            txt_Street.Clear();
            txt_Ward.Clear();
            txt_District.Clear();
            txt_City.Clear();
            txt_Country.Clear();
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_IDA.Text) && !string.IsNullOrEmpty(txt_Street.Text) && !string.IsNullOrEmpty(txt_Ward.Text) && !string.IsNullOrEmpty(txt_District.Text) && !string.IsNullOrEmpty(txt_City.Text) && !string.IsNullOrEmpty(txt_Country.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void btn_them_ClickAsync(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm địa chỉ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var street = txt_Street.Text.Trim();
                        var ward = txt_Ward.Text.Trim();
                        var district = txt_District.Text.Trim();
                        var city = txt_City.Text.Trim();
                        var country = txt_Country.Text.Trim();

                        bool isAdded = await neo4JConnection.AddAddressWithManagerAsync(street, ward, district, city, country);

                        if (isAdded)
                        {
                            MessageBox.Show("Thêm Địa Chỉ Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            adf.GetData();
                            Clear();
                            this.Close();
                        }    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm địa chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_sua_ClickAsync(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa địa chỉ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var addressid = txt_IDA.Text.Trim();
                        var street = txt_Street.Text.Trim();
                        var ward = txt_Ward.Text.Trim();
                        var district = txt_District.Text.Trim();
                        var city = txt_City.Text.Trim();
                        var country = txt_Country.Text.Trim();


                        bool isEdited = await neo4JConnection.EditAddressWithManagerAsync(addressid, street, ward, district, city, country);

                        if (isEdited)
                        {
                            MessageBox.Show("Cập Nhật Địa Chỉ Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            adf.GetData();
                            this.Close();
                        }    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddressModule_Load(object sender, EventArgs e)
        {
            UpdateButtonStateAsync();
        }
    }
}
