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
            int supplier_code = 0;
            double total_amount;
            int game_id;

            if (suppliercombo.SelectedItem.ToString() == "TechWare")
            {
                supplier_code = 1;
            }

            else if (suppliercombo.SelectedItem.ToString() == "Pixel Games")
            {
                supplier_code = 2;
            }

            else if (suppliercombo.SelectedItem.ToString() == "GameLab Supplies")
            {
                supplier_code = 3;
            }

            else if (suppliercombo.SelectedItem.ToString() == "GameXpert")
            {
                supplier_code = 4;
            }

            else if (suppliercombo.SelectedItem.ToString() == "PlayCraft Supplies")
            {
                supplier_code = 5;
            }

            total_amount = qty * price;

            byte[] gameImageBytes = ImageToByteArray(pictureBox1.Image);

            InsertToGames(game_name, gameImageBytes, price, platform, developer, genre);

            game_id = get_game_id();

            InsertToPurchases(supplier_code, game_id, qty, total_amount, date_purchased);
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
            NewPlatform plat = new NewPlatform();

            plat.Show();
            plat.TopMost = true;
        }

        private void addnewdev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewDev dev = new NewDev();

            dev.Show();
            dev.TopMost = true;
        }

        private void addnewgenre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewGenre gen = new NewGenre();

            gen.Show();
            gen.TopMost = true;
        }

  

  


    }
}
