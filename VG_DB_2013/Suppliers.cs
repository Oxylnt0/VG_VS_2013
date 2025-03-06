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
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into Game_Suppliers values (@Supplier_Name, @Supplier_Email, @Supplier_Phone_Number, @Supplier_Address)", sqlcon);
            cmd.Parameters.AddWithValue("@Supplier_Name", (suppliernamebox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Email", (emailbox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Phone_Number", (numberbox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Address", (addressbox.Text));
            cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Supplier Added", "Game Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            suppliernamebox.Text = "";
            emailbox.Text = "";
            numberbox.Text = "";
            addressbox.Text = "";
        }

        private void editmode_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Deleting a Supplier turns Supplier in Purchases Null, Proceed?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("delete Game_Suppliers where Supplier_ID=" + Convert.ToInt32(admin_id.Text), sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Delete Successful", "Game Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin_id.Text = "";
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            int supplierid = int.Parse(find_supplier_id.Text);

            string query = "SELECT Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address FROM Game_Suppliers WHERE Supplier_ID = @SupplierID";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierid);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nameedit.Text = reader["Supplier_Name"].ToString();
                    emailedit.Text = reader["Supplier_Email"].ToString();
                    numberedit.Text = reader["Supplier_Phone_Number"].ToString();
                    addressedit.Text = reader["Supplier_Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Supplier ID not found.");
                }

                reader.Close();
            }
        }
    }
}
