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

        private Opacity opacity;

        public Purchases()
        {
            InitializeComponent();

            supplierbox.Format += new ListControlConvertEventHandler(supplierbox_Format);
            LoadSuppliers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.purchasegrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.purchasegrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.purchasegrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.purchasegrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.purchasegrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.purchasegrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
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

                var totalColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Total Amount",
                    DataPropertyName = "Total_Amount_Purchases",
                    DefaultCellStyle = { Format = "C2", FormatProvider = new System.Globalization.CultureInfo("en-PH") }
                };
                purchasegrid.Columns.Add(totalColumn);

                purchasegrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Purchases Date", DataPropertyName = "Purchase_Date" });

                purchasegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                purchasegrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        List<string> selectedSuppliers = new List<string>();

        private void applybtn_Click(object sender, EventArgs e)
        {


            //suppliers
            UpdateSelectedSupplier();

            if (selectedSuppliers.Count > 0)
            {
                query += " AND Supplier_Name IN ('" + string.Join("','", selectedSuppliers) + "')";
            }

            if (sortby.SelectedItem == null)
            {
                sortby.SelectedValue = null;
            }

            else if (sortby.SelectedItem.ToString() == "Date - Newest")
            {
                query += " order by Purchase_Date desc";
            }

            else if (sortby.SelectedItem.ToString() == "Date - Oldest")
            {
                query += " order by Purchase_Date asc";
            }

            else if (sortby.SelectedItem.ToString() == "Amount - Highest")
            {
                query += " order by Total_Amount_Purchases desc";
            }

            else if (sortby.SelectedItem.ToString() == "Amount - Lowest")
            {
                query += " order by Total_Amount_Purchases asc";
            }

            this.BindData();
            purchasegrid.Update();
            purchasegrid.Refresh();

            query = "select Purchase_ID, Game_Suppliers.Supplier_Name, Games.Game_Name, Purchase_QTY, Total_Amount_Purchases, Purchase_Date from Game_Purchases inner join Games on Game_Purchases.Game_ID=Games.Game_ID inner join Game_Suppliers on Game_Purchases.Supplier_ID=Game_Suppliers.Supplier_ID where 1=1";

        }

        private void UpdateSelectedSupplier()
        {
            selectedSuppliers.Clear();

            foreach (var item in supplierbox.CheckedItems)
            {
                KeyValuePair<int, string> kvp = (KeyValuePair<int, string>)item;
                selectedSuppliers.Add(kvp.Value);
            }

        }

        private void supplierbox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((KeyValuePair<int, string>)e.ListItem).Value;
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

        private void addpurchasebtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            AddPurchases purchase = new AddPurchases(opacity);
            purchase.Show();
            purchase.TopMost = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < supplierbox.Items.Count; i++)
            {
                supplierbox.SetItemChecked(i, false);
            }
        }

        private void updategamestock_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            UpdateGameStock update = new UpdateGameStock(opacity);
            update.Show();
            update.TopMost = true;
        }

        private void LoadSuppliers()
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string query = "SELECT Supplier_ID, Supplier_Name FROM Game_Suppliers";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    supplierbox.Items.Clear();

                    while (reader.Read())
                    {
                        supplierbox.Items.Add(new KeyValuePair<int, string>(
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

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mainForm = Application.OpenForms["Menu"] as Menu;
            if (mainForm != null)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }
    }

    public class ListItem
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public ListItem(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name; 
        }
    }

}
