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
    public partial class MainForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public MainForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }

        private Form activeForm = null;
        public void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                panelChild.Controls.Add(childform);
                panelChild.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
        }

        public void btnClear()
        {
            btn_TrangChu.ForeColor = Color.White;
            btn_Citizen.ForeColor = Color.White;
            btn_Family.ForeColor = Color.White;
            btn_Education.ForeColor = Color.White;
            btn_Employment.ForeColor = Color.White;
            btn_Address.ForeColor = Color.White;
        }
        public string GetDayOfWeekInVietnamese(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Chủ nhật";
                case DayOfWeek.Monday:
                    return "Thứ hai";
                case DayOfWeek.Tuesday:
                    return "Thứ ba";
                case DayOfWeek.Wednesday:
                    return "Thứ tư";
                case DayOfWeek.Thursday:
                    return "Thứ năm";
                case DayOfWeek.Friday:
                    return "Thứ sáu";
                case DayOfWeek.Saturday:
                    return "Thứ bảy";
                default:
                    return "";
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            duongthang1.Height = 2;
            duongthang2.Height = 2;
            btn_TrangChu_Click(sender, e);
            DateTime currentTime = DateTime.Now;
            string formattedTime = string.Format("{0}, ngày {1:D2}/{2:D2}/{3}", GetDayOfWeekInVietnamese(currentTime.DayOfWeek), currentTime.Day, currentTime.Month, currentTime.Year);
            lbl_Time.Text = formattedTime;
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new HomeForm());
            btn_TrangChu.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btn_Family_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new FamilyForm());
            btn_Family.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_Citizen_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new CitizenForm());
            btn_Citizen.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_Address_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new AddressForm());
            btn_Address.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Chọn nơi lưu và đặt tên file sao lưu";
                saveFileDialog.FileName = "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = saveFileDialog.FileName;
                    await neo4JConnection.BackupNeo4jData(backupFilePath);

                    // Hiển thị thông báo sao lưu thành công
                    MessageBox.Show("Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void btn_restore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn file CSV để phục hồi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string restoreFilePath = openFileDialog.FileName;
                    await neo4JConnection.RestoreNeo4jData(restoreFilePath);

                    // Hiển thị thông báo phục hồi thành công
                    MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi hàm đăng xuất để đăng nhập lại
                    btn_LogOut_Click(sender, e);
                }
            }
        }
    }
}
