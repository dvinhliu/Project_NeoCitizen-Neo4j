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
    public partial class DetailCitizenModule : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public string CitizenID { get; set; }
        public DetailCitizenModule(string citizenID)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            this.CitizenID = citizenID;
        }

        private async void DetailCitizenModule_Load(object sender, EventArgs e)
        {
            await LoadCitizenDetails();
            lblTittle.Text = "THÔNG TIN CHI TIẾT CÔNG DÂN";
        }

        private async Task LoadCitizenDetails()
        {
            try
            {
                var citizenDetails = await neo4JConnection.GetCitizenByIdAsync(CitizenID);
                if (citizenDetails != null)
                {
                    txt_IDCongDan.Text = string.IsNullOrEmpty(citizenDetails.CitizenID) ? "Không có thông tin" : citizenDetails.CitizenID;
                    txt_HoTen.Text = string.IsNullOrEmpty(citizenDetails.FullName) ? "Không có thông tin" : citizenDetails.FullName;
                    txt_NgaySinh.Text = string.IsNullOrEmpty(citizenDetails.DateOfBirth) ? "Không có thông tin" : citizenDetails.DateOfBirth;
                    txt_GT.Text = string.IsNullOrEmpty(citizenDetails.Gender) ? "Không có thông tin" : citizenDetails.Gender;
                    txt_SDT.Text = string.IsNullOrEmpty(citizenDetails.PhoneNumber) ? "Không có thông tin" : citizenDetails.PhoneNumber;
                    txt_GD.Text = citizenDetails.Family?.FamilyName ?? "Không có thông tin";
                    txt_SoCC.Text = citizenDetails.IdentityCard?.DocumentNumber ?? "Không có thông tin";
                    txt_DC.Text = citizenDetails.Address?.GetFullAddress() ?? "Không có thông tin";
                    txt_CongViec.Text = citizenDetails.Employment?.Company ?? "Không có thông tin";
                    txt_ViTri.Text = citizenDetails.Employment?.Position ?? "Không có thông tin";

                    if (txt_CongViec.Text.Equals("Không có thông tin"))
                    {
                        lbl_ngayBD.Visible = false;
                        dt_ngayBD.Visible = false;
                    }    
                    else
                    {
                        lbl_ngayBD.Visible = true;
                        dt_ngayBD.Visible = true;
                        dt_ngayBD.Value = DateTime.Parse(citizenDetails.Employment.StartDate);
                    }    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin công dân.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
