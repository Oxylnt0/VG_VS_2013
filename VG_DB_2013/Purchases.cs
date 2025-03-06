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

        private string query = "select Purchase_ID, Game_Suppliers.Supplier_Name, Games.Game_Name, Purchase_QTY, Total_Amount_Purchases, Purchase_Date from Game_Purchases inner join Games on Game_Purchases.Game_ID=Games.Game_ID inner join Game_Suppliers on Game_Purchases.Supplier_ID=Game_Suppliers.Supplier_ID where 1=1";

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
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Purchase ID", DataPropertyName = "Purchase_ID" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Supplier", DataPropertyName = "Supplier_Name" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game Title", DataPropertyName = "Game_Name" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Purchase Quantity", DataPropertyName = "Purchase_QTY" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Amount", DataPropertyName = "Total_Amount_Purchases" });
                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Purchases Date", DataPropertyName = "Purchase_Date" });

                purchasegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                purchasegrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            List<string> selectedSuppliers = new List<string>();

            //suppliers
            if (supplierbox.GetItemChecked(0) == true)
            {
                selectedSuppliers.Add("GameLab Supplies");
            }
            if (supplierbox.GetItemChecked(1) == true)
            {
                selectedSuppliers.Add("GameXpert");
            }
            if (supplierbox.GetItemChecked(2) == true)
            {
                selectedSuppliers.Add("Pixel Games");
            }
            if (supplierbox.GetItemChecked(3) == true)
            {
                selectedSuppliers.Add("Playcraft Supplies");
            }
            if (supplierbox.GetItemChecked(4) == true)
            {
                selectedSuppliers.Add("Techware");
            }

            if (selectedSuppliers.Count > 0)
            {
                query += " AND Supplier_Name IN ('" + string.Join("','", selectedSuppliers) + "')";
            }
            
            if (sortby.SelectedItem == null)
            {
                sortby.SelectedValue = null;
            }

            else if (sortby.SelectedItem.ToString() == "Newest")
            {
                query += " order by Purchase_Date desc";
            }

            else if (sortby.SelectedItem.ToString() == "Oldest")
            {
                query += " order by Purchase_Date asc";

            }

            this.BindData();
            purchasegrid.Update();
            purchasegrid.Refresh();

            query = "select Purchase_ID, Game_Suppliers.Supplier_Name, Games.Game_Name, Purchase_QTY, Total_Amount_Purchases, Purchase_Date from Game_Purchases inner join Games on Game_Purchases.Game_ID=Games.Game_ID inner join Game_Suppliers on Game_Purchases.Supplier_ID=Game_Suppliers.Supplier_ID where 1=1";

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

        private void add_Click(object sender, EventArgs e)
        {
            string game_name = gamenamebox.Text;
            double price = Convert.ToDouble(pricebox.Text);
            string platform = platformbox.Text;
            string developer = developerbox.Text;
            string genre = genrebox.Text;
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

        private void refresh_Click(object sender, EventArgs e)
        {
            this.BindData();
            purchasegrid.Update();
            purchasegrid.Refresh();
        }




    }
}
