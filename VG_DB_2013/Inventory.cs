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
            string query = "SELECT Game_ID, Game_Name, Game_Platform, Developer, Picture FROM Games";

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

    }
}
