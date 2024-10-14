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
    public partial class FamilyModule : Form
    {
        public bool isAddMode = false;
        private readonly Neo4jConnection neo4JConnection;
        FamilyForm fm;
        public FamilyModule(FamilyForm f)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            fm = f;
        }

        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txt_IDF.Text = await neo4JConnection.GetNextFamilyIDAsync();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN GIA ĐÌNH";
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN GIA ĐÌNH";
            }
        }
        public void Clear()
        {
            txt_FN.Clear();
            cbb_FullAdrs.SelectedIndex = -1;
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_IDF.Text) && !string.IsNullOrEmpty(txt_FN.Text) && cbb_FullAdrs.SelectedItem != null)
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
                if (MessageBox.Show("Bạn có chắc muốn thêm gia đình này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var familyId = txt_IDF.Text.Trim();
                        var familyname = txt_FN.Text.Trim();

                        var selectedAddress = GetSelectedAddressFromComboBox();

                        await neo4JConnection.AddFamilyWithAddressAsync(familyId, familyname, selectedAddress);

                        MessageBox.Show("Thêm Gia Đình Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
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
                if (MessageBox.Show("Bạn có chắc muốn sửa gia đình này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var familyId = txt_IDF.Text.Trim();
                        var familyName = txt_FN.Text.Trim();

                        var selectedAddress = GetSelectedAddressFromComboBox();

                        await neo4JConnection.EditFamilyWithAddressAsync(familyId, familyName, selectedAddress);

                        MessageBox.Show("Cập Nhật Gia Đình Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fm.GetData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa gia đình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public (string Street, string Ward, string District, string City, string Country) GetSelectedAddressFromComboBox()
        {
            string selectedAddress = cbb_FullAdrs.SelectedItem?.ToString() ?? cbb_FullAdrs.Text;

            string[] addressParts = selectedAddress.Split(',');

            if (addressParts.Length == 5)
            {
                string street = addressParts[0].Trim();
                string ward = addressParts[1].Trim();
                string district = addressParts[2].Trim();
                string city = addressParts[3].Trim();
                string country = addressParts[4].Trim();

                return (street, ward, district, city, country);
            }
            else
            {
                throw new InvalidOperationException("Địa chỉ không hợp lệ hoặc thiếu thành phần.");
            }
        }
        private async void FamilyModule_LoadAsync(object sender, EventArgs e)
        {
            UpdateButtonStateAsync();

            var availableAddresses = await neo4JConnection.GetUnlinkedAddressesAsync();
            foreach (var address in availableAddresses)
            {
                cbb_FullAdrs.Items.Add($"{address.Street}, {address.Ward}, {address.District}, {address.City}, {address.Country}");
            }
        }
    }
}
