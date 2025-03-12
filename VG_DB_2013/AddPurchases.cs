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
    public partial class AddPurchases : Form
    {

        private Opacity opacity;

        public AddPurchases(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            opacity.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string game_name = gamenamebox.Text;
            double price = Convert.ToDouble(pricebox.Text);
            string platform = platformcombo.Text;
            string developer = developercombo.Text;
            string genre = genrecombo.Text;
            int qty = Convert.ToInt32(qtybox.Text);
            DateTime date_purchased = dateTimePicker1.Value;
            double total_amount;
            int game_id;

            int supplier_code = Convert.ToInt32(suppliercombo.SelectedValue);

            total_amount = qty * price;

            byte[] gameImageBytes = ImageToByteArray(pictureBox1.Image);

            InsertToGames(game_name, gameImageBytes, price, platform, developer, genre);

            game_id = get_game_id();

            InsertToPurchases(supplier_code, game_id, qty, total_amount, date_purchased);

            InsertToInventory(game_id, supplier_code, qty, date_purchased);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void InsertToGames(string gameName, byte[] picture, double price, string platform, string dev, string genre)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "INSERT INTO Games (Game_Name, Picture, Price, Game_Platform, Developer, Genre) VALUES (@GameName, @Picture, @Price, @GamePlatform, @Developer, @Genre)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.Add("@GameName", System.Data.SqlDbType.VarChar).Value = gameName;
                        cmd.Parameters.Add("@Picture", System.Data.SqlDbType.VarBinary).Value = picture;
                        cmd.Parameters.Add("@Price", System.Data.SqlDbType.Money).Value = price;
                        cmd.Parameters.Add("@GamePlatform", System.Data.SqlDbType.VarChar).Value = platform;
                        cmd.Parameters.Add("@Developer", System.Data.SqlDbType.VarChar).Value = dev;
                        cmd.Parameters.Add("@Genre", System.Data.SqlDbType.VarChar).Value = genre;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Game inserted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void InsertToPurchases(int supplierid, int gameid, int qty, double amount, DateTime date)
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

        private void InsertToInventory(int gameid, int supplierid, int gamestock, DateTime date)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "INSERT INTO Games_Inventory (Game_ID, Supplier_ID, Games_Stock, Date_Updated) VALUES (@gameid, @supplierid, @stock, @date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.Add("@gameid", System.Data.SqlDbType.Int).Value = gameid;
                        cmd.Parameters.Add("@supplierid", System.Data.SqlDbType.Int).Value = supplierid;
                        cmd.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = gamestock;
                        cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date;

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int get_game_id()
        {
            string con = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

            int currentIdentity = 0;

            using (SqlConnection conn = new SqlConnection(con))
            {

                conn.Open();
                string query = "SELECT IDENT_CURRENT('Games')";
                SqlCommand cmd = new SqlCommand(query, conn);

                currentIdentity = Convert.ToInt32(cmd.ExecuteScalar());

            }

            return currentIdentity;
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void addnewplatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPlatform plat = new NewPlatform(this);

            plat.Show();
            plat.TopMost = true;
        }

        private void addnewdev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewDev dev = new NewDev(this);

            dev.Show();
            dev.TopMost = true;
        }

        private void addnewgenre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewGenre gen = new NewGenre(this);

            gen.Show();
            gen.TopMost = true;
        }

        private void AddPurchases_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadPlatforms();
            LoadDevelopers();
            LoadGenres();
        }

        private void LoadSuppliers()
        {
            try
            {
                string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Supplier_ID, Supplier_Name FROM Game_Suppliers"; 

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        suppliercombo.DataSource = dt;
                        suppliercombo.DisplayMember = "Supplier_Name";  
                        suppliercombo.ValueMember = "Supplier_ID";      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadPlatforms()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Platform_ID, Platform_Name FROM Game_Platform";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    platformcombo.DisplayMember = "Platform_Name"; 
                    platformcombo.ValueMember = "Platform_ID"; 
                    platformcombo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void LoadDevelopers()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Developer_ID, Developer_Name FROM Developer";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    developercombo.DisplayMember = "Developer_Name";
                    developercombo.ValueMember = "Developer_ID";
                    developercombo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void LoadGenres()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Genre_ID, Genre_Name FROM Genre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    genrecombo.DisplayMember = "Genre_Name";
                    genrecombo.ValueMember = "Genre_ID";
                    genrecombo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

  


    }
}
