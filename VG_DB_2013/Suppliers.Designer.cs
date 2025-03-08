namespace VG_DB_2013
{
    partial class Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortby = new System.Windows.Forms.ComboBox();
            this.suppliergrid = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.editsupplierbtn = new System.Windows.Forms.Button();
            this.addsupplierbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliergrid)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 93);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::VG_DB_2013.Properties.Resources.icons8_close_301;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1403, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 34);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1451, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Suppliers";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.applybtn);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.sortby);
            this.panel3.Controls.Add(this.suppliergrid);
            this.panel3.Location = new System.Drawing.Point(304, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 630);
            this.panel3.TabIndex = 8;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Gold;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(12, 587);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(139, 30);
            this.refresh.TabIndex = 39;
            this.refresh.Text = "Refresh Table";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Gold;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.Location = new System.Drawing.Point(189, 10);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(76, 25);
            this.searchbtn.TabIndex = 25;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // applybtn
            // 
            this.applybtn.BackColor = System.Drawing.Color.Gold;
            this.applybtn.FlatAppearance.BorderSize = 0;
            this.applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybtn.ForeColor = System.Drawing.Color.Black;
            this.applybtn.Location = new System.Drawing.Point(567, 10);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(76, 25);
            this.applybtn.TabIndex = 25;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = false;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(3, 9);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 25);
            this.search.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(346, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sort:";
            // 
            // sortby
            // 
            this.sortby.BackColor = System.Drawing.Color.White;
            this.sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortby.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortby.FormattingEnabled = true;
            this.sortby.Items.AddRange(new object[] {
            "Supplier Name - Ascending",
            "Supplier Name - Descending"});
            this.sortby.Location = new System.Drawing.Point(403, 10);
            this.sortby.Name = "sortby";
            this.sortby.Size = new System.Drawing.Size(158, 25);
            this.sortby.TabIndex = 15;
            // 
            // suppliergrid
            // 
            this.suppliergrid.AllowUserToAddRows = false;
            this.suppliergrid.AllowUserToDeleteRows = false;
            this.suppliergrid.AllowUserToResizeColumns = false;
            this.suppliergrid.AllowUserToResizeRows = false;
            this.suppliergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliergrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.suppliergrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.suppliergrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.suppliergrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.suppliergrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliergrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliergrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.suppliergrid.EnableHeadersVisualStyles = false;
            this.suppliergrid.GridColor = System.Drawing.Color.White;
            this.suppliergrid.Location = new System.Drawing.Point(3, 40);
            this.suppliergrid.Name = "suppliergrid";
            this.suppliergrid.ReadOnly = true;
            this.suppliergrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliergrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.suppliergrid.RowHeadersVisible = false;
            this.suppliergrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.suppliergrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.suppliergrid.Size = new System.Drawing.Size(651, 541);
            this.suppliergrid.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.editsupplierbtn);
            this.panel6.Controls.Add(this.addsupplierbtn);
            this.panel6.Location = new System.Drawing.Point(967, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 132);
            this.panel6.TabIndex = 57;
            // 
            // editsupplierbtn
            // 
            this.editsupplierbtn.BackColor = System.Drawing.Color.Gold;
            this.editsupplierbtn.FlatAppearance.BorderSize = 0;
            this.editsupplierbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editsupplierbtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsupplierbtn.ForeColor = System.Drawing.Color.Black;
            this.editsupplierbtn.Location = new System.Drawing.Point(16, 73);
            this.editsupplierbtn.Name = "editsupplierbtn";
            this.editsupplierbtn.Size = new System.Drawing.Size(248, 44);
            this.editsupplierbtn.TabIndex = 55;
            this.editsupplierbtn.Text = "Edit Suppliers";
            this.editsupplierbtn.UseVisualStyleBackColor = false;
            this.editsupplierbtn.Click += new System.EventHandler(this.editsupplierbtn_Click);
            // 
            // addsupplierbtn
            // 
            this.addsupplierbtn.BackColor = System.Drawing.Color.Gold;
            this.addsupplierbtn.FlatAppearance.BorderSize = 0;
            this.addsupplierbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addsupplierbtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsupplierbtn.ForeColor = System.Drawing.Color.Black;
            this.addsupplierbtn.Location = new System.Drawing.Point(17, 13);
            this.addsupplierbtn.Name = "addsupplierbtn";
            this.addsupplierbtn.Size = new System.Drawing.Size(248, 44);
            this.addsupplierbtn.TabIndex = 54;
            this.addsupplierbtn.Text = "Add Suppliers";
            this.addsupplierbtn.UseVisualStyleBackColor = false;
            this.addsupplierbtn.Click += new System.EventHandler(this.addsupplierbtn_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::VG_DB_2013.Properties.Resources.pixel_background_nxwecdh8vgxjfe96;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 778);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliergrid)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortby;
        private System.Windows.Forms.DataGridView suppliergrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button editsupplierbtn;
        private System.Windows.Forms.Button addsupplierbtn;
    }
}