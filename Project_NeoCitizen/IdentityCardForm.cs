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
    public partial class IdentityCardForm : Form
    {
        private readonly Neo4jConnection neo4JConnection;
        public IdentityCardForm()
        {
            InitializeComponent();
            neo4JConnection = new Neo4jConnection();
        }

        public void LoadCBBSort()
        {
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_IdentityCard.Columns)
            {
                if (col.CellType != typeof(DataGridViewImageCell) && col.Index != 2)
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }
        public async void GetData()
        {
            try
            {
                var lstInCard = neo4JConnection.GetAllIdentityCardAsync();

                dgv_IdentityCard.Rows.Clear();

                foreach (var inCard in await lstInCard)
                {
                    dgv_IdentityCard.Rows.Add(inCard.IdentityCardID, inCard.DocumentNumber, inCard.IssueDate, inCard.ExpirationDate, inCard.IssuedBy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdentityCardForm_Load(object sender, EventArgs e)
        {
            GetData();
            LoadCBBSort();
        }
    }
    
}
