using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VG_DB_2013
{
    public partial class AddSales : Form
    {

        private Opacity opacity;

        public AddSales(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void AddSales_Load(object sender, EventArgs e)
        {
            this.BindData();
        }

        private string query = "SELECT Game_ID , Game_Name FROM Games WHERE 1=1";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gamegrid.DataSource = dt;

                gamegrid.Columns.Clear();
                gamegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game ID", DataPropertyName = "Game_ID" });
                gamegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game Name", DataPropertyName = "Game_Name" });

                gamegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                gamegrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

    }
}
