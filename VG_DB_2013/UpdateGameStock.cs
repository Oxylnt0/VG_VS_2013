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
    public partial class UpdateGameStock : Form
    {
        private Opacity opacity;

        public UpdateGameStock(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void UpdateGameStock_Load(object sender, EventArgs e)
        {
            this.BindData();
            LoadComboBox();
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(find_gameid.Text))
            {
                MessageBox.Show("Enter Game ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FetchGameName(Convert.ToInt32(find_gameid.Text));
        }

        private void FetchGameName(int gameId)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT Game_Name, Price FROM Games WHERE Game_ID = @GameID";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                gamenamebox.Text = reader["Game_Name"].ToString();
                                pricebox.Text = reader["Price"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Game not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gamenamebox.Text = string.Empty;
                                pricebox.Text = string.Empty;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            opacity.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gamenamebox.Text) ||
                string.IsNullOrWhiteSpace(suppliercombo.Text) ||
                string.IsNullOrWhiteSpace(pricebox.Text) ||
                string.IsNullOrWhiteSpace(qtybox.Text))
            {
                MessageBox.Show("All Fields Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = Convert.ToDouble(pricebox.Text);
            int qty = Convert.ToInt32(qtybox.Text);
            DateTime date_purchased = dateTimePicker1.Value;
            double total_amount;
            int game_id = Convert.ToInt32(find_gameid.Text);

            int supplier_code = Convert.ToInt32(suppliercombo.SelectedValue);

            total_amount = qty * price;

            updatestock(Convert.ToInt32(find_gameid.Text), Convert.ToInt32(qtybox.Value), date_purchased);
            addpurchase(supplier_code, game_id, qty, total_amount, date_purchased);

        }

        private void updatestock(int gameID, int newStock, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                string query = "UPDATE Games_Inventory SET Games_Stock = Games_Stock + @Stock, Date_Updated = @Date WHERE Game_ID = @GameID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Stock", newStock);
                    cmd.Parameters.AddWithValue("@GameID", gameID);
                    cmd.Parameters.AddWithValue("@Date", date);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Game ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addpurchase(int supplierid, int gameid, int qty, double amount, DateTime date)
        {

            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "INSERT INTO Game_Purchases (Supplier_ID, Game_ID, Purchase_QTY, Total_Amount_Purchases, Purchase_Date) VALUES (@supplierID, @gameID, @QTY, @Amount, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.Add("@supplierID", System.Data.SqlDbType.Int).Value = supplierid;
                        cmd.Parameters.Add("@gameID", System.Data.SqlDbType.Int).Value = gameid;
                        cmd.Parameters.Add("@QTY", System.Data.SqlDbType.Int).Value = qty;
                        cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Money).Value = amount;
                        cmd.Parameters.Add("@Date", System.Data.SqlDbType.Date).Value = date;

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void LoadComboBox()
        {
            try
            {
                string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Supplier_ID, Supplier_Name FROM Game_Suppliers"; // Adjust table and column names

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        suppliercombo.DataSource = dt;
                        suppliercombo.DisplayMember = "Supplier_Name";  // Column to display
                        suppliercombo.ValueMember = "Supplier_ID";      // Column holding actual values
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }


    }
}
