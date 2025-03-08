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

        }

    }
}
