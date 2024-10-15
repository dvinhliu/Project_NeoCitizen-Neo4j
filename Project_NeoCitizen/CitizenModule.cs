﻿using Project_NeoCitizen.Models;
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
        }
        public async void UpdateButtonStateAsync()
        {
            if (isAddMode)
            {
                txtIDCD.Text = await neo4JConnection.GetNextCitizenIDAsync();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN CÔNG DÂN";
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                lblTittle.Text = "SỬA THÔNG TIN CÔNG DÂN";
            }
        }

        public async void LoadCBB()
        {
            // Thêm tùy chọn giới tính
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
            cbb_GioiTinh.SelectedIndex = 0;

            // Xóa tất cả các mục cũ trong ComboBox
            cbbCCCD.Items.Clear();
            cbbDiaChi.Items.Clear();

            // Thêm tùy chọn mặc định "Không có thông tin"
            cbbCCCD.Items.Add("Không có thông tin");
            cbbDiaChi.Items.Add("Không có thông tin");

            // Lấy danh sách thẻ căn cước
            var identityCards = await neo4JConnection.GetAllIdentityCardsAsync();
            if (identityCards != null && identityCards.Any()) // Kiểm tra nếu có dữ liệu
            {
                foreach (var card in identityCards)
                {
                    cbbCCCD.Items.Add(new KeyValuePair<string, string>(card.IdentityCardID, $"{card.IDDocument_ToString()}"));
                }

                cbbCCCD.DisplayMember = "Value";
                cbbCCCD.ValueMember = "Key";
            }

            // Lấy danh sách địa chỉ
            var addresses = await neo4JConnection.GetAllAddressesAsync();
            if (addresses != null && addresses.Any()) // Kiểm tra nếu có dữ liệu
            {
                foreach (var address in addresses)
                {
                    cbbDiaChi.Items.Add(new KeyValuePair<string, string>(address.AddressID, $"{address.GetFullAddress()}"));
                }

                cbbDiaChi.DisplayMember = "Value";
                cbbDiaChi.ValueMember = "Key";
            }

            // Đặt lựa chọn mặc định
            if (isAddMode)
            {
                cbbCCCD.SelectedIndex = 0;
                cbbDiaChi.SelectedIndex = 0;
            }
            else
            {
                string citizenID = citizenForm.dgv_Citizen.CurrentRow.Cells[0].Value.ToString();

                var citizenToEdit = await neo4JConnection.GetCitizenByIdAsync(citizenID);

                txtIDCD.Text = citizenToEdit.CitizenID;
                txtTenCD.Text = citizenToEdit.FullName;
                txtSDT.Text = citizenToEdit.PhoneNumber;
                cbb_GioiTinh.SelectedItem = citizenToEdit.Gender;
                dtNgaySinh.Value = DateTime.Parse(citizenToEdit.DateOfBirth); // Chuyển đổi thành DateTime

                // Kiểm tra và thiết lập giá trị cho cbbCCCD
                if (citizenToEdit.IdentityCard != null)
                {
                    var identityCardID = citizenToEdit.IdentityCard.IdentityCardID; // Lấy ID từ IdentityCard
                    var identityCardValue = citizenToEdit.IdentityCard.IDDocument_ToString(); // Lấy giá trị hiển thị

                    // Tìm kiếm trong Items của cbbCCCD để thiết lập giá trị
                    var foundItem = cbbCCCD.Items.OfType<KeyValuePair<string, string>>()
                        .FirstOrDefault(item => item.Key == identityCardID);

                    if (foundItem.Key != null)
                    {
                        cbbCCCD.SelectedItem = foundItem; // Thiết lập selected item
                    }
                    else
                    {
                        var newItem = new KeyValuePair<string, string>(citizenToEdit.IdentityCard.IdentityCardID, $"{citizenToEdit.IdentityCard.IDDocument_ToString()}");
                        cbbCCCD.Items.Add(newItem);
                        cbbCCCD.DisplayMember = "Value";
                        cbbCCCD.ValueMember = "Key";
                        cbbCCCD.SelectedItem = newItem;
                    }    
                }
                else
                {
                    cbbCCCD.SelectedItem = "Không có thông tin"; // Thiết lập nếu không có thông tin
                }

                // Kiểm tra và thiết lập giá trị cho cbbDiaChi
                if (citizenToEdit.Address != null)
                {
                    var addressID = citizenToEdit.Address.AddressID; // Lấy ID từ Address
                    var addressValue = citizenToEdit.Address.GetFullAddress(); // Lấy giá trị hiển thị

                    // Tìm kiếm trong Items của cbbDiaChi để thiết lập giá trị
                    var foundAddressItem = cbbDiaChi.Items.OfType<KeyValuePair<string, string>>()
                        .FirstOrDefault(item => item.Key == addressID);

                    if (foundAddressItem.Key != null)
                    {
                        cbbDiaChi.SelectedItem = foundAddressItem; // Thiết lập selected item
                    }
                }
                else
                {
                    cbbDiaChi.SelectedItem = "Không có thông tin"; // Thiết lập nếu không có thông tin
                }

                if (citizenToEdit.Employment != null)
                {
                    txt_TenCT.Text = citizenToEdit.Employment.Company;
                    txt_Vitri.Text = citizenToEdit.Employment.Position;
                    dt_ngayBD.Value = DateTime.Parse(citizenToEdit.Employment.StartDate);
                }
                else
                {
                    txt_TenCT.Text = "Không có thông tin";
                    txt_Vitri.Text = "Không có thông tin";
                    dt_ngayBD.Value = DateTime.Now;
                }
            }    
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

                // Kiểm tra và lấy IDCard
                string selectedIDCardID = "Không có thông tin";
                if (cbbCCCD.SelectedItem is KeyValuePair<string, string> selectedIDCard)
                {
                    selectedIDCardID = selectedIDCard.Key;
                }

                // Kiểm tra và lấy Address
                string selectedAddressID = "Không có thông tin";
                if (cbbDiaChi.SelectedItem is KeyValuePair<string, string> selectedAddress)
                {
                    selectedAddressID = selectedAddress.Key;
                }

                // Lấy thông tin việc làm
                var employmentCompany = string.IsNullOrWhiteSpace(txt_TenCT.Text) ? "Không có thông tin" : txt_TenCT.Text;
                var employmentPosition = string.IsNullOrWhiteSpace(txt_Vitri.Text) ? "Không có thông tin" : txt_Vitri.Text;
                var startDate = dt_ngayBD.Value.ToString("yyyy-MM-dd");

                // Cập nhật công dân
                await neo4JConnection.UpdateCitizenAsync(updatedCitizen, selectedIDCardID, selectedAddressID, employmentCompany, employmentPosition, startDate);

                MessageBox.Show("Cập nhật thông tin công dân và các mối quan hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                citizenForm.GetData();
                this.Close();
            }
        }

        private void CitizenModule_Load(object sender, EventArgs e)
        {
            UpdateButtonStateAsync();
            LoadCBB();
        }
    }
}
