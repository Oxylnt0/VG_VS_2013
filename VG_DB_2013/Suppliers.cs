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

namespace VG_DB_2013
{
    public partial class Suppliers : Form
    {

        private Opacity opacity;

        public Suppliers()
        {
            InitializeComponent();
        }

        private string query = "select Supplier_ID, Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address from Game_Suppliers where 1=1";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                suppliergrid.DataSource = dt;

                suppliergrid.Columns.Clear();

                suppliergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Supplier ID", DataPropertyName = "Supplier_ID" });
                suppliergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Supplier", DataPropertyName = "Supplier_Name" });
                suppliergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Supplier_Email" });
                suppliergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone No.", DataPropertyName = "Supplier_Phone_Number" });
                suppliergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Supplier_Address" });

                suppliergrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                suppliergrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.suppliergrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.suppliergrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.suppliergrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.suppliergrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.suppliergrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            query = "select Supplier_ID, Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address from Game_Suppliers where Supplier_Name Like '%" + search.Text + "%';";
            this.BindData();
            suppliergrid.Update();
            suppliergrid.Refresh();
            query = "select Supplier_ID, Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address from Game_Suppliers where 1=1";
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (sortby.SelectedItem.ToString() == "Supplier Name - Ascending")
            {
                query += " order by Supplier_Name asc";
            }

            else if (sortby.SelectedItem.ToString() == "Supplier Name - Descending")
            {
                query += " order by Supplier_Name desc";

            }

            this.BindData();
            suppliergrid.Update();
            suppliergrid.Refresh();

            query = "select Supplier_ID, Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address from Game_Suppliers where 1=1";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.BindData();
            suppliergrid.Update();
            suppliergrid.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
        }

        private void editmode_Click(object sender, EventArgs e)
        {

            
        }

        private void find_Click(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void addsupplierbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            AddSupplier asupplier = new AddSupplier(opacity);
            asupplier.Show();
            asupplier.TopMost = true;
        }

        private void editsupplierbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            EditSupplier supplier = new EditSupplier(opacity);
            supplier.Show();
            supplier.TopMost = true;
        }

      

    }
}
