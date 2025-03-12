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
    public partial class Sales : Form
    {
        private Opacity opacity;

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.salesgrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.salesgrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.salesgrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.salesgrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.salesgrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.salesgrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private string query = "select CONCAT(Game_Customers.First_Name, ' ', Game_Customers.Middle_Initial, '. ', Game_Customers.Last_Name) AS Full_Name, Games.Game_Name, Sale_QTY, Total_Amount_Sales, Payment_Method, Sales_Date from Games_Sales inner join Games on Games_Sales.Game_ID=Games.Game_ID inner join Game_Customers on Games_Sales.Customer_ID=Game_Customers.Customer_ID where 1=1";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                salesgrid.DataSource = dt;

                salesgrid.Columns.Clear();
                salesgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer Name", DataPropertyName = "Full_Name" });
                salesgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game Title", DataPropertyName = "Game_Name" });
                salesgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Sale_QTY" });

                var totalColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Total Amount",
                    DataPropertyName = "Total_Amount_Sales",
                    DefaultCellStyle = { Format = "C2", FormatProvider = new System.Globalization.CultureInfo("en-PH") }
                };
                salesgrid.Columns.Add(totalColumn);

                salesgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Payment Method", DataPropertyName = "Payment_Method" });
                salesgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date of Sale", DataPropertyName = "Sales_Date" });

                salesgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                salesgrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (sortby.SelectedItem == null)
            {
                sortby.SelectedValue = null;
            }

            else if (sortby.SelectedItem.ToString() == "Date - Newest")
            {
                query += " order by Sales_Date desc";
            }

            else if (sortby.SelectedItem.ToString() == "Date - Oldest")
            {
                query += " order by Sales_Date asc";
            }

            else if (sortby.SelectedItem.ToString() == "Amount - Highest")
            {
                query += " order by Total_Amount_Sales asc";
            }

            else if (sortby.SelectedItem.ToString() == "Amount - Lowest")
            {
                query += " order by Total_Amount_Sales desc";
            }

            this.BindData();
            salesgrid.Update();
            salesgrid.Refresh();

            query = "select CONCAT(Game_Customers.First_Name, ' ', Game_Customers.Middle_Initial, '. ', Game_Customers.Last_Name) AS Full_Name, Games.Game_Name, Sale_QTY, Total_Amount_Sales, Payment_Method, Sales_Date from Games_Sales inner join Games on Games_Sales.Game_ID=Games.Game_ID inner join Game_Customers on Games_Sales.Customer_ID=Game_Customers.Customer_ID where 1=1";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.BindData();
            salesgrid.Update();
            salesgrid.Refresh();
        }

        private void addsalesbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;
            
            AddSales sales = new AddSales(opacity);

            sales.Show();
            sales.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mainForm = Application.OpenForms["Menu"] as Menu;
            if (mainForm != null)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }

     


    }
}
