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

namespace VG_DB_2013
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand("Select * from Admins", connection))
                {
                    command.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable table = new DataTable())
                        {
                            adapter.Fill(table);
                            AdminGrid.DataSource = table;
                        }
                    }
                }

            }


        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.AdminGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

 

    }
}
