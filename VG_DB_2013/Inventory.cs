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
    public partial class Inventory : Form
    {

        private string query = @"select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Game_Platform.Platform_Name, Developer.Developer_Name, Genre.Genre_Name, Games.Picture from Games_Inventory  
                                 inner join Games on Games.Game_ID = Games_Inventory.Game_ID 
                                 inner join Game_Platform on Games.Platform_ID = Game_Platform.Platform_ID
                                 inner join Developer on Games.Developer_ID = Developer.Developer_ID
                                 inner join Genre on Games.Genre_ID = Genre.Genre_ID where 1=1";


        public Inventory()
        {
            InitializeComponent();

            platformbox.Format += new ListControlConvertEventHandler(platformbox_Format);
            LoadPlatforms();

            developerbox.Format += new ListControlConvertEventHandler(developerbox_Format);
            LoadDevelopers();

            genrebox.Format += new ListControlConvertEventHandler(genrebox_Format);
            LoadGenres();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.BindData();
        }

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
           
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("Image", typeof(Image));

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Picture"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])row["Picture"];
                        if (imageData.Length > 0)
                        {
                            row["Image"] = ByteArrayToImage(imageData, 150); 
                        }
                    }
                }

                dt.Columns.Remove("Picture");

                InventoryGrid.DataSource = dt;

                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
                {
                    HeaderText = "Game Image",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    DataPropertyName = "Image"
                };

                InventoryGrid.Columns.Clear();
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game ID", DataPropertyName = "Game_ID" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Game Name", DataPropertyName = "Game_Name" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Games_Stock" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Platform", DataPropertyName = "Platform_Name" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Developer", DataPropertyName = "Developer_Name" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Genre", DataPropertyName = "Genre_Name" });
                InventoryGrid.Columns.Add(imgColumn);

                InventoryGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                InventoryGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private Image ResizeImage(Image img, int newWidth)
        {
            int newHeight = (int)((double)img.Height / img.Width * newWidth);

            Bitmap bmp = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }
            return bmp;
        }

        private Image ByteArrayToImage(byte[] byteArrayIn, int width)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    Image originalImage = Image.FromStream(ms);
                    return ResizeImage(originalImage, width);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
                return null;
            }
        }

        List<string> selectedPlatforms = new List<string>();
        List<string> selectedDeveloper = new List<string>();
        List<string> selectedGenre = new List<string>();

        private void applybtn_Click(object sender, EventArgs e)
        {

            //platform
            UpdateSelectedPlatforms();

            //developer
            UpdateSelectedDeveloper();
        
            //genre
            UpdateSelectedGenre();

            if (selectedPlatforms.Count > 0)
            {
                query += " AND Platform_Name IN ('" + string.Join("','", selectedPlatforms) + "')";
            }

            if (selectedDeveloper.Count > 0)
            {
                query += " AND Developer_Name IN ('" + string.Join("','", selectedDeveloper) + "')";
            }
            
            if (selectedGenre.Count > 0)
            {
                query += " AND Genre_Name IN ('" + string.Join("','", selectedGenre) + "')";
            }

            //sortby
            if (sortby.SelectedItem == null)
            {
                sortby.SelectedValue = null;
            }

            else if (sortby.SelectedItem.ToString() == "Name - Descending")
            {
                query += " order by Game_Name desc";
            }

            else if (sortby.SelectedItem.ToString() == "Name - Ascending")
            {
                query += " order by Game_Name asc";

            }

            else if (sortby.SelectedItem.ToString() == "Price - Ascending")
            {
                query += " order by Price asc";

            }

            else if (sortby.SelectedItem.ToString() == "Price - Descending")
            {
                query += " order by Price desc";

            }

            else if (sortby.SelectedItem.ToString() == "Game ID - Ascending")
            {
                query += " order by Game_ID asc";

            }

            else if (sortby.SelectedItem.ToString() == "Game ID - Descending")
            {
                query += " order by Game_ID desc";

            }

            this.BindData();
            InventoryGrid.Update();
            InventoryGrid.Refresh();

            query = @"select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Game_Platform.Platform_Name, Developer.Developer_Name, Genre.Genre_Name, Games.Picture from Games_Inventory  
                                 inner join Games on Games.Game_ID = Games_Inventory.Game_ID 
                                 inner join Game_Platform on Games.Platform_ID = Game_Platform.Platform_ID
                                 inner join Developer on Games.Developer_ID = Developer.Developer_ID
                                 inner join Genre on Games.Genre_ID = Genre.Genre_ID where 1=1";
            
        }
        

        //----------PLATFORM----------
        private void UpdateSelectedPlatforms()
        {
            selectedPlatforms.Clear();

            foreach (var item in platformbox.CheckedItems)
            {
                KeyValuePair<int, string> kvp = (KeyValuePair<int, string>)item;
                selectedPlatforms.Add(kvp.Value);
            }

        }

        private void LoadPlatforms()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Platform_ID, Platform_Name FROM Game_Platform";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    platformbox.Items.Clear();

                    while (reader.Read())
                    {
                        platformbox.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)
                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void platformbox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((KeyValuePair<int, string>)e.ListItem).Value;
        }

        //----------PLATFORM----------

        //----------DEVELOPER----------
        private void UpdateSelectedDeveloper()
        {
            selectedDeveloper.Clear();

            foreach (var item in developerbox.CheckedItems)
            {
                KeyValuePair<int, string> kvp = (KeyValuePair<int, string>)item;
                selectedDeveloper.Add(kvp.Value);
            }
        }

        private void LoadDevelopers()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Developer_ID, Developer_Name FROM Developer";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    developerbox.Items.Clear();

                    while (reader.Read())
                    {
                        developerbox.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)
                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void developerbox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((KeyValuePair<int, string>)e.ListItem).Value;
        }
        //----------DEVELOPER----------

        //----------GENRE----------
        private void UpdateSelectedGenre()
        {
            selectedGenre.Clear();

            foreach (var item in genrebox.CheckedItems)
            {
                KeyValuePair<int, string> kvp = (KeyValuePair<int, string>)item;
                selectedGenre.Add(kvp.Value);
            }
        }

        private void LoadGenres()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Genre_ID, Genre_Name FROM Genre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    genrebox.Items.Clear();

                    while (reader.Read())
                    {
                        genrebox.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)
                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void genrebox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((KeyValuePair<int, string>)e.ListItem).Value;
        }
        //----------GENRE----------

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            query = @"select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Game_Platform.Platform_Name, Developer.Developer_Name, Genre.Genre_Name, Games.Picture from Games_Inventory  
                                 inner join Games on Games.Game_ID = Games_Inventory.Game_ID 
                                 inner join Game_Platform on Games.Platform_ID = Game_Platform.Platform_ID
                                 inner join Developer on Games.Developer_ID = Developer.Developer_ID
                                 inner join Genre on Games.Genre_ID = Genre.Genre_ID where Game_Name Like '%" + search.Text + "%';";
            this.BindData();
            InventoryGrid.Update();
            InventoryGrid.Refresh();
            query = @"select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Game_Platform.Platform_Name, Developer.Developer_Name, Genre.Genre_Name, Games.Picture from Games_Inventory  
                                 inner join Games on Games.Game_ID = Games_Inventory.Game_ID 
                                 inner join Game_Platform on Games.Platform_ID = Game_Platform.Platform_ID
                                 inner join Developer on Games.Developer_ID = Developer.Developer_ID
                                 inner join Genre on Games.Genre_ID = Genre.Genre_ID where 1=1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

    }
}
