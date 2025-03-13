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
            this.BindDataCust();
            game_qty.Value = 1;
        }

        private string query = "select Games.Game_ID, Games.Game_Name, Games_Stock from Games_Inventory inner join Games on Games_Inventory.Game_ID=Games.Game_ID WHERE 1=1";

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
                gamegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Games_Stock" });

                gamegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                gamegrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private string query2 = "SELECT Customer_ID , CONCAT(Game_Customers.First_Name, ' ', Game_Customers.Middle_Initial, '. ', Game_Customers.Last_Name) AS Full_Name FROM Game_Customers WHERE 1=1";

        public void BindDataCust()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query2, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                custgrid.DataSource = dt;

                custgrid.Columns.Clear();
                custgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer ID", DataPropertyName = "Customer_ID" });
                custgrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Full Name", DataPropertyName = "Full_Name" });

                custgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                custgrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void game_id_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(game_id.Text))
            {
                MessageBox.Show("Enter Game ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FetchGameName(Convert.ToInt32(game_id.Text));
        }

        private void FetchGameName(int gameId)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT Game_Name FROM Games WHERE Game_ID = @GameID";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            game_name.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Game not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            game_name.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT Price FROM Games WHERE Game_ID = @GameID";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            price.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Game not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            game_name.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            total_amount.Text = price.Text;

        }

        private void UpdateGameStock(int gameId, decimal salesQty, int custoid, decimal totalamount, string paymethod, DateTime saledate)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string selectQuery = "SELECT Games_Stock FROM Games_Inventory WHERE Game_ID = @GameID";
                    int currentStock = 0;

                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            currentStock = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Game ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    if (currentStock < salesQty)
                    {
                        MessageBox.Show("Not enough stock available!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string updateQuery = "UPDATE Games_Inventory SET Games_Stock = Games_Stock - @SalesQty WHERE Game_ID = @GameID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        cmd.Parameters.AddWithValue("@SalesQty", salesQty);
                        cmd.ExecuteNonQuery();
                    }

                    string insertQuery = "insert into Games_Sales values (@GameID, @CustomerID, @qty, @amount, @payment_method, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        cmd.Parameters.AddWithValue("@CustomerID", custoid);
                        cmd.Parameters.AddWithValue("@qty", salesQty);
                        cmd.Parameters.AddWithValue("@amount", totalamount);
                        cmd.Parameters.AddWithValue("@payment_method", paymethod);
                        cmd.Parameters.AddWithValue("@date", saledate);
                        cmd.ExecuteNonQuery(); 
                    }

                    MessageBox.Show("Stock updated and Game Sale Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(game_id.Text) ||
              string.IsNullOrWhiteSpace(game_name.Text) ||
              string.IsNullOrWhiteSpace(price.Text) ||
              string.IsNullOrWhiteSpace(game_qty.Text) ||
              string.IsNullOrWhiteSpace(total_amount.Text) ||
              string.IsNullOrWhiteSpace(cust_id.Text) ||
              string.IsNullOrWhiteSpace(payment_method.Text))
            {
                MessageBox.Show("All Fields Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           decimal salesQty = game_qty.Value;
           string payment = payment_method.Text;
           DateTime dateofsale = date.Value;
           UpdateGameStock(Convert.ToInt32(game_id.Text), salesQty, Convert.ToInt32(cust_id.Text), Convert.ToDecimal(total_amount.Text), payment, dateofsale);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.BindData();
            gamegrid.Update();
            gamegrid.Refresh();

            this.BindDataCust();
            custgrid.Update();
            custgrid.Refresh();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            opacity.Close();
        }

        private void game_qty_ValueChanged(object sender, EventArgs e)
        {
            decimal qty = game_qty.Value;
            decimal Price = Convert.ToDecimal(price.Text);

            decimal total = qty * Price;
            total_amount.Text = total.ToString();
        }

        private void add_cust_btn_Click(object sender, EventArgs e)
        {
            AddCustomer custform = new AddCustomer();
            custform.Show();
            custform.TopMost = true;
        }

    }
}

