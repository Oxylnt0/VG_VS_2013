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

        private string query = "SELECT Game_ID ,Price ,Game_Name, Game_Platform, Developer, Picture FROM Games WHERE 1=1";


        public Inventory()
        {
            InitializeComponent();
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
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Platform", DataPropertyName = "Game_Platform" });
                InventoryGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Developer", DataPropertyName = "Developer" });
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

        private void applybtn_Click(object sender, EventArgs e)
        {

            List<string> selectedPlatforms = new List<string>();
            List<string> selectedDevelopers = new List<string>();

            //platform
            if (platformbox.GetItemChecked(0) == true)
            {
                selectedPlatforms.Add("PS4");
            }
            if (platformbox.GetItemChecked(1) == true)
            {
                selectedPlatforms.Add("PS5");
            }
            if (platformbox.GetItemChecked(2) == true)
            {
                selectedPlatforms.Add("Nintendo Switch");
            }
            if (platformbox.GetItemChecked(3) == true)
            {
                selectedPlatforms.Add("Xbox One");
            }

            //developer
            if (developerbox.GetItemChecked(0) == true)
            {
                selectedDevelopers.Add("Aerosoft");
            }
            if (developerbox.GetItemChecked(1) == true)
            {
                selectedDevelopers.Add("Aniplex");
            }
            if (developerbox.GetItemChecked(2) == true)
            {
                selectedDevelopers.Add("Atlus");
            }
            if (developerbox.GetItemChecked(3) == true)
            {
                selectedDevelopers.Add("Bandai Namco Games");
            }
            if (developerbox.GetItemChecked(4) == true)
            {
                selectedDevelopers.Add("Capcom");
            }
            if (developerbox.GetItemChecked(5) == true)
            {
                selectedDevelopers.Add("Dotemu");
            }
            if (developerbox.GetItemChecked(6) == true)
            {
                selectedDevelopers.Add("Electronic Arts");
            }
            if (developerbox.GetItemChecked(7) == true)
            {
                selectedDevelopers.Add("Falcom");
            }
            if (developerbox.GetItemChecked(8) == true)
            {
                selectedDevelopers.Add("FromSoftware");
            }
            if (developerbox.GetItemChecked(9) == true)
            {
                selectedDevelopers.Add("Natsume");
            }
            if (developerbox.GetItemChecked(10) == true)
            {
                selectedDevelopers.Add("Nintendo");
            }
            if (developerbox.GetItemChecked(11) == true)
            {
                selectedDevelopers.Add("Rockstar Games");
            }
            if (developerbox.GetItemChecked(12) == true)
            {
                selectedDevelopers.Add("Sony Interactive Entertainment");
            }
            if (developerbox.GetItemChecked(13) == true)
            {
                selectedDevelopers.Add("Supergiant Games");
            }
            if (developerbox.GetItemChecked(14) == true)
            {
                selectedDevelopers.Add("Unknown Worlds");
            }
            if (developerbox.GetItemChecked(15) == true)
            {
                selectedDevelopers.Add("Warner Bros.");
            }

            if (selectedPlatforms.Count > 0)
            {
                query += " AND Game_Platform IN ('" + string.Join("','", selectedPlatforms) + "')";
            }

            if (selectedDevelopers.Count > 0)
            {
                query += " AND Developer IN ('" + string.Join("','", selectedDevelopers) + "')";
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

            query = "SELECT Game_ID ,Price ,Game_Name, Game_Platform, Developer, Picture FROM Games WHERE 1=1";
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            query = "SELECT Game_ID ,Price ,Game_Name, Game_Platform, Developer, Picture FROM Games where Game_Name Like '%" + search.Text + "%';";
            this.BindData();
            InventoryGrid.Update();
            InventoryGrid.Refresh();
            query = "SELECT Game_ID ,Price ,Game_Name, Game_Platform, Developer, Picture FROM Games WHERE 1=1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    

       

   



    }
}
