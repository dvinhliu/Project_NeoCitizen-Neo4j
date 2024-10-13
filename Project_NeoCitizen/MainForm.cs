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
        public MainForm()
        {
            InitializeComponent();
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

        private void btn_Employment_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new EmploymentForm());
            btn_Employment.ForeColor = Color.DarkGreen;
            activeForm = null;
        }
    }
}
