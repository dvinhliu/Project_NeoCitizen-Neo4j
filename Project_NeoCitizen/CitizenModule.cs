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
            LoadGioiTinh();
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

        private void LoadGioiTinh()
        {
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
            cbb_GioiTinh.SelectedIndex = 0;
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
                if (!string.IsNullOrWhiteSpace(txtTenCD.Text) && !string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    var citizen = new Citizen
                    {
                        CitizenID = txtIDCD.Text,
                        FullName = txtTenCD.Text,
                        PhoneNumber = txtSDT.Text,
                        Gender = cbb_GioiTinh.SelectedItem.ToString(),
                        DateOfBirth = dtNgaySinh.Value.ToString("yyyy-MM-dd")
                    };

                    // Thêm công dân vào cơ sở dữ liệu
                    bool result = await neo4JConnection.AddCitizenAsync(citizen);

                    // Kiểm tra kết quả
                    if (result)
                    {
                        MessageBox.Show("Thêm công dân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Reset form hoặc cập nhật giao diện nếu cần
                        citizenForm.GetData();
                        btnHuy_Click(sender, e); // Clear fields
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm công dân không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
    }
}
