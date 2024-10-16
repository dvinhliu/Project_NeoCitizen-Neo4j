using Project_NeoCitizen.Models;
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
    public partial class CitizenModule : Form
    {
        public bool isAddMode = false;
        private readonly Neo4jConnection neo4JConnection;
        CitizenForm citizenForm;
        public CitizenModule(CitizenForm f)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            citizenForm = f;
            this.isAddMode = isAddMode;
            LoadCBB();
            UpdateButtonStateAsync();
        }
        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txtIDCD.Text = await neo4JConnection.GetNextCitizenIDAsync();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                lblTittle.Text = "THÊM CÔNG DÂN";
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                lblTittle.Text = "SỬA CÔNG DÂN";
            }
        }

        private async void LoadCBB()
        {
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
            cbb_GioiTinh.SelectedIndex = 0;

            var jobs = await neo4JConnection.GetAllJobsAsync();
            foreach (var job in jobs)
            {
                cbbCongViec.Items.Add(new KeyValuePair<string, string>(job.EmploymentID, $"{job.Company} - {job.Position}"));
            }
            cbbCongViec.DisplayMember = "Value";
            cbbCongViec.ValueMember = "Key"; 

            var identityCards = await neo4JConnection.GetAllIdentityCardsAsync();
            foreach (var card in identityCards)
            {
                cbbCCCD.Items.Add(new KeyValuePair<string, string>(card.IdentityCardID, $"{card.DocumentNumber} - {card.IssuedBy}"));
            }
            
            cbbCCCD.DisplayMember = "Value";
            cbbCCCD.ValueMember = "Key";

            var addresses = await neo4JConnection.GetAllAddressesAsync();
            foreach (var address in addresses)
            {
                cbbDiaChi.Items.Add(new KeyValuePair<string, string>(address.AddressID, $"{address.Street}, {address.Ward}, {address.District}, {address.City}"));
            }
            cbbDiaChi.DisplayMember = "Value";
            cbbDiaChi.ValueMember = "Key";

            cbbCongViec.SelectedIndex = -1;
            cbbCCCD.SelectedIndex = -1;
            cbbDiaChi.SelectedIndex = -1;
        }

        private bool KiemTraNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenCD.Text))
            {
                MessageBox.Show("Tên công dân không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap())
            {
                var citizen = new Citizen
                {
                    CitizenID = txtIDCD.Text,
                    FullName = txtTenCD.Text,
                    PhoneNumber = txtSDT.Text,
                    Gender = cbb_GioiTinh.SelectedItem.ToString(),
                    DateOfBirth = dtNgaySinh.Value.ToString("yyyy-MM-dd")
                };

                bool result = await neo4JConnection.AddCitizenAsync(citizen);

                if (result)
                {
                    // Lấy ID (kiểm tra nếu có giá trị mới tạo quan hệ)
                    if (cbbCongViec.SelectedItem != null)
                    {
                        var selectedJobID = ((KeyValuePair<string, string>)cbbCongViec.SelectedItem).Key;
                        await neo4JConnection.AddRelationshipAsync(citizen.CitizenID, selectedJobID, "EMPLOYED_AT");
                    }

                    if (cbbCCCD.SelectedItem != null)
                    {
                        var selectedIDCardID = ((KeyValuePair<string, string>)cbbCCCD.SelectedItem).Key;
                        await neo4JConnection.AddRelationshipAsync(citizen.CitizenID, selectedIDCardID, "HAS_DOCUMENT");
                    }

                    if (cbbDiaChi.SelectedItem != null)
                    {
                        var selectedAddressID = ((KeyValuePair<string, string>)cbbDiaChi.SelectedItem).Key;
                        await neo4JConnection.AddRelationshipAsync(citizen.CitizenID, selectedAddressID, "LIVING_AT");
                    }

                    MessageBox.Show("Thêm công dân và các mối quan hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    citizenForm.GetData();
                    btnHuy_Click(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm công dân không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            txtTenCD.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap())
            {
                var updatedCitizen = new Citizen
                {
                    CitizenID = txtIDCD.Text,
                    FullName = txtTenCD.Text,
                    PhoneNumber = txtSDT.Text,
                    Gender = cbb_GioiTinh.SelectedItem.ToString(),
                    DateOfBirth = dtNgaySinh.Value.ToString("yyyy-MM-dd")
                };

                bool result = await neo4JConnection.UpdateCitizenAsync(updatedCitizen);

                if (result)
                {
                    // Lấy ID
                    var selectedJobID = ((KeyValuePair<string, string>)cbbCongViec.SelectedItem).Key;
                    var selectedIDCardID = ((KeyValuePair<string, string>)cbbCCCD.SelectedItem).Key;
                    var selectedAddressID = ((KeyValuePair<string, string>)cbbDiaChi.SelectedItem).Key;

                    // Xóa các mối quan hệ cũ
                    await neo4JConnection.RemoveAllRelationshipsAsync(updatedCitizen.CitizenID);

                    // Tạo các mối quan hệ mới
                    await neo4JConnection.AddRelationshipAsync(updatedCitizen.CitizenID, selectedAddressID, "LIVING_AT");
                    await neo4JConnection.AddRelationshipAsync(updatedCitizen.CitizenID, selectedJobID, "EMPLOYED_AT");
                    await neo4JConnection.AddRelationshipAsync(updatedCitizen.CitizenID, selectedIDCardID, "HAS_DOCUMENT");

                    MessageBox.Show("Cập nhật thông tin công dân và các mối quan hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    citizenForm.GetData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin công dân không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
