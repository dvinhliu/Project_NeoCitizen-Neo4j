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
    public partial class DetailFamilyModule : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public string FamilyID { get; set; }

        public DetailFamilyModule(string familyID)
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
            this.FamilyID = familyID;
            LoadDetails();
        }
        private string GetCitizenIDFromListItem(string listItem)
        {
            var parts = listItem.Split('-');

            return parts[0].Trim();
        }
        private async void LoadDetails()
        {
            try
            {
                var familyMembers = await neo4JConnection.GetAllCitizensWithFamilyAsync(FamilyID);
                foreach (var member in familyMembers)
                {
                    lstB_InTV.Items.Add(member.IDFullName_ToString());
                }

                var unlinkedCitizens = await neo4JConnection.GetUnlinkedCitizensAsync();
                foreach (var citizen in unlinkedCitizens)
                {
                    lsB_OutTV.Items.Add(citizen.IDFullName_ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_Left_ClickAsync(object sender, EventArgs e)
        {
            if (lsB_OutTV.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (var selectedItem in lsB_OutTV.SelectedItems)
                    {
                        var citizenID = GetCitizenIDFromListItem(selectedItem.ToString());

                        // Thêm từng công dân vào gia đình
                        await neo4JConnection.AddCitizenToFamilyAsync(citizenID, FamilyID);

                        // Di chuyển từng công dân từ lsB_OutTV sang lstB_InTV
                        lstB_InTV.Items.Add(selectedItem);
                    }

                    // Sau khi di chuyển, xóa các mục đã chọn khỏi lsB_OutTV
                    foreach (var selectedItem in lsB_OutTV.SelectedItems.Cast<string>().ToList())
                    {
                        lsB_OutTV.Items.Remove(selectedItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi liên kết công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một công dân chưa liên kết để thêm vào gia đình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btn_Right_ClickAsync(object sender, EventArgs e)
        {
            if (lstB_InTV.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (var selectedItem in lstB_InTV.SelectedItems)
                    {
                        var citizenID = GetCitizenIDFromListItem(selectedItem.ToString());

                        // Xóa mối quan hệ BELONGS_TO giữa công dân và gia đình
                        await neo4JConnection.RemoveCitizenFromFamilyAsync(citizenID, FamilyID);

                        // Di chuyển từng công dân từ lstB_InTV sang lsB_OutTV
                        lsB_OutTV.Items.Add(selectedItem);
                    }

                    // Sau khi di chuyển, xóa các mục đã chọn khỏi lstB_InTV
                    foreach (var selectedItem in lstB_InTV.SelectedItems.Cast<string>().ToList())
                    {
                        lstB_InTV.Items.Remove(selectedItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa liên kết công dân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một công dân đã liên kết để xóa khỏi gia đình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
