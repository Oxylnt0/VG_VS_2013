using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VG_DB_2013
{
    public partial class NewGenre : Form
    {
        public NewGenre()
        {
            InitializeComponent();
        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addgenbox_Click(object sender, EventArgs e)
        {
            string newGenre = newgenrebox.Text.Trim();

            if (!string.IsNullOrEmpty(newGenre))
            {
                Inventory inventory = new Inventory();
                if (inventory != null)
                {
                    inventory.AddGenre(newGenre);
                    newgenrebox.Clear();
                    MessageBox.Show("Genre added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Genre name.");
            }
        }

    }
}
