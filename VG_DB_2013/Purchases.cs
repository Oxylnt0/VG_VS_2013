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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            this.BindData();
        }

        private string query = "select Games.Game_Name, Games_Stock, Date_Updated from Games_Inventory inner join Games on Games_Inventory.Game_ID=Games.Game_ID";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                purchasegrid.DataSource = dt;

                purchasegrid.Columns.Clear();
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game Title", DataPropertyName = "Game_Name" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Games_Stock" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date Updated", DataPropertyName = "Date_Updated" });

                purchasegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                purchasegrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (sortby.SelectedItem == null)
            {
                sortby.SelectedValue = null;
            }

            else if (sortby.SelectedItem.ToString() == "Newest")
            {
                query += " order by Date_Updated desc";
            }

            else if (sortby.SelectedItem.ToString() == "Oldest")
            {
                query += " order by Date_Updated asc";

            }

            this.BindData();
            purchasegrid.Update();
            purchasegrid.Refresh();

            query = "select Games.Game_Name, Games_Stock, Date_Updated from Games_Inventory inner join Games on Games_Inventory.Game_ID=Games.Game_ID";

        }

 

 


    }
}
