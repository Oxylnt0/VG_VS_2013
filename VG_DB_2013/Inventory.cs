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

        private string query = "select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Games.Game_Platform, Games.Developer, Games.Genre, Games.Picture from Games_Inventory inner join Games on Games.Game_ID = Games_Inventory.Game_ID WHERE 1=1";


        public Inventory()
        {
            InitializeComponent();
            LoadPlatforms();
            LoadDeveloper();
            LoadGenre();
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
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Platform", DataPropertyName = "Game_Platform" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Developer", DataPropertyName = "Developer" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Genre", DataPropertyName = "Genre" });
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

        private List<bool> platformCheckedStatus = new List<bool>();
        private List<bool> developerCheckedStatus = new List<bool>();
        private List<bool> genreCheckedStatus = new List<bool>();

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
                query += " AND Game_Platform IN ('" + string.Join("','", selectedPlatforms) + "')";
            }

            if (selectedDeveloper.Count > 0)
            {
                query += " AND Developer IN ('" + string.Join("','", selectedDeveloper) + "')";
            }
            
            if (selectedGenre.Count > 0)
            {
                query += " AND Genre IN ('" + string.Join("','", selectedGenre) + "')";
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

            query = "select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Games.Game_Platform, Games.Developer, Games.Genre, Games.Picture from Games_Inventory inner join Games on Games.Game_ID = Games_Inventory.Game_ID WHERE 1=1";
            
        }
        

        //----------PLATFORM----------
        public void UpdateSelectedPlatforms()
        {
            selectedPlatforms.Clear();

            for (int i = 0; i < platformbox.Items.Count; i++)
            {
                if (platformbox.GetItemChecked(i))
                {
                    selectedPlatforms.Add(platformbox.Items[i].ToString());
                }
            }
        }

        public void AddPlatform(string platform)
        {
            if (!selectedPlatforms.Contains(platform))
            {
                selectedPlatforms.Add(platform);     
                platformCheckedStatus.Add(false);  

                SavePlatforms();

                LoadPlatforms();
            }
        }

        private void SavePlatforms()
        {
            using (StreamWriter writer = new StreamWriter("platforms.txt", append: true))
            {
                int lastIndex = selectedPlatforms.Count - 1;
                writer.WriteLine(selectedPlatforms[lastIndex] + "|" + platformCheckedStatus[lastIndex]);
            }
        }

        private void LoadPlatforms()
        {
            platformbox.Items.Clear();
            selectedPlatforms.Clear();
            platformCheckedStatus.Clear();

            if (File.Exists("platforms.txt"))
            {
                using (StreamReader reader = new StreamReader("platforms.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            selectedPlatforms.Add(parts[0]);  
                            platformCheckedStatus.Add(bool.Parse(parts[1])); 
                        }
                    }
                }
            }

  
            for (int i = 0; i < selectedPlatforms.Count; i++)
            {
                platformbox.Items.Add(selectedPlatforms[i]); 
                platformbox.SetItemChecked(i, platformCheckedStatus[i]); 
            }
        }

        private void platformbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            platformCheckedStatus[e.Index] = e.NewValue == CheckState.Checked; 
            SavePlatforms();
        }
        //----------PLATFORM----------

        //----------DEVELOPER----------
        public void UpdateSelectedDeveloper()
        {
            selectedDeveloper.Clear();

            for (int i = 0; i < developerbox.Items.Count; i++)
            {
                if (developerbox.GetItemChecked(i))
                {
                    selectedDeveloper.Add(developerbox.Items[i].ToString());
                }
            }
        }

        public void AddDeveloper(string developer)
        {
            if (!selectedDeveloper.Contains(developer))
            {
                selectedDeveloper.Add(developer);
                developerCheckedStatus.Add(false);

                SaveDeveloper();

                LoadDeveloper();
            }
        }

        private void SaveDeveloper()
        {
            using (StreamWriter writer = new StreamWriter("developer.txt", append: true))
            {
                int lastIndex = selectedDeveloper.Count - 1;
                writer.WriteLine(selectedDeveloper[lastIndex] + "|" + developerCheckedStatus[lastIndex]);
            }
        }

        private void LoadDeveloper()
        {
            developerbox.Items.Clear();
            selectedDeveloper.Clear();
            developerCheckedStatus.Clear();

            if (File.Exists("developer.txt"))
            {
                using (StreamReader reader = new StreamReader("developer.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            selectedDeveloper.Add(parts[0]);
                            developerCheckedStatus.Add(bool.Parse(parts[1]));
                        }
                    }
                }
            }


            for (int i = 0; i < selectedDeveloper.Count; i++)
            {
                developerbox.Items.Add(selectedDeveloper[i]);
                developerbox.SetItemChecked(i, developerCheckedStatus[i]);
            }
        }

        private void developerbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            developerCheckedStatus[e.Index] = e.NewValue == CheckState.Checked;
            SaveDeveloper();
        }
        //----------DEVELOPER----------

        //----------GENRE----------
        public void UpdateSelectedGenre()
        {
            selectedGenre.Clear();

            for (int i = 0; i < genrebox.Items.Count; i++)
            {
                if (genrebox.GetItemChecked(i))
                {
                    selectedGenre.Add(genrebox.Items[i].ToString());
                }
            }
        }

        public void AddGenre(string genre)
        {
            if (!selectedGenre.Contains(genre))
            {
                selectedGenre.Add(genre);
                genreCheckedStatus.Add(false);

                SaveGenre();

                LoadGenre();
            }
        }

        private void SaveGenre()
        {
            using (StreamWriter writer = new StreamWriter("genre.txt", append: true))
            {
                int lastIndex = selectedGenre.Count - 1;
                writer.WriteLine(selectedGenre[lastIndex] + "|" + genreCheckedStatus[lastIndex]);
            }
        }

        private void LoadGenre()
        {
            genrebox.Items.Clear();
            selectedGenre.Clear();
            genreCheckedStatus.Clear();

            if (File.Exists("genre.txt"))
            {
                using (StreamReader reader = new StreamReader("genre.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            selectedGenre.Add(parts[0]);
                            genreCheckedStatus.Add(bool.Parse(parts[1]));
                        }
                    }
                }
            }


            for (int i = 0; i < selectedGenre.Count; i++)
            {
                genrebox.Items.Add(selectedGenre[i]);
                genrebox.SetItemChecked(i, genreCheckedStatus[i]);
            }
        }

        private void genrebox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            genreCheckedStatus[e.Index] = e.NewValue == CheckState.Checked;
            SaveGenre();
        }
        //----------GENRE----------

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            query = "select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Games.Game_Platform, Games.Developer, Games.Genre, Games.Picture from Games_Inventory inner join Games on Games.Game_ID = Games_Inventory.Game_ID where Game_Name Like '%" + search.Text + "%';";
            this.BindData();
            InventoryGrid.Update();
            InventoryGrid.Refresh();
            query = "select Games.Game_ID, Games.Game_Name, Games_Stock, Games.Price, Games.Game_Platform, Games.Developer, Games.Genre, Games.Picture from Games_Inventory inner join Games on Games.Game_ID = Games_Inventory.Game_ID WHERE 1=1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

    }
}
