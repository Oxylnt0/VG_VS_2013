namespace VG_DB_2013
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.editcustbtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortby = new System.Windows.Forms.ComboBox();
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 93);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VG_DB_2013.Properties.Resources.GAME_Customers_3_9_2025;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 99);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
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
            this.button1.Location = new System.Drawing.Point(1403, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.customergrid);
            this.panel3.Location = new System.Drawing.Point(99, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 630);
            this.panel3.TabIndex = 8;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Gold;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(979, 579);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(248, 30);
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
            this.searchbtn.Location = new System.Drawing.Point(253, 9);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(76, 25);
            this.searchbtn.TabIndex = 25;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // applybtn
            // 
            this.applybtn.BackColor = System.Drawing.Color.Gold;
            this.applybtn.FlatAppearance.BorderSize = 0;
            this.applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybtn.ForeColor = System.Drawing.Color.Black;
            this.applybtn.Location = new System.Drawing.Point(64, 46);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(170, 25);
            this.applybtn.TabIndex = 25;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = false;
            // 
            // editcustbtn
            // 
            this.editcustbtn.BackColor = System.Drawing.Color.Gold;
            this.editcustbtn.FlatAppearance.BorderSize = 0;
            this.editcustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editcustbtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcustbtn.ForeColor = System.Drawing.Color.Black;
            this.editcustbtn.Location = new System.Drawing.Point(12, 14);
            this.editcustbtn.Name = "editcustbtn";
            this.editcustbtn.Size = new System.Drawing.Size(222, 44);
            this.editcustbtn.TabIndex = 55;
            this.editcustbtn.Text = "Edit Customers";
            this.editcustbtn.UseVisualStyleBackColor = false;
            this.editcustbtn.Click += new System.EventHandler(this.editcustbtn_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(13, 9);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(234, 25);
            this.search.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(7, 15);
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
            "Last Name - Ascending",
            "Last Name - Descending"});
            this.sortby.Location = new System.Drawing.Point(64, 15);
            this.sortby.Name = "sortby";
            this.sortby.Size = new System.Drawing.Size(170, 25);
            this.sortby.TabIndex = 15;
            // 
            // customergrid
            // 
            this.customergrid.AllowUserToAddRows = false;
            this.customergrid.AllowUserToDeleteRows = false;
            this.customergrid.AllowUserToResizeColumns = false;
            this.customergrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.customergrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customergrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customergrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customergrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customergrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customergrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customergrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customergrid.EnableHeadersVisualStyles = false;
            this.customergrid.GridColor = System.Drawing.Color.White;
            this.customergrid.Location = new System.Drawing.Point(13, 40);
            this.customergrid.Name = "customergrid";
            this.customergrid.ReadOnly = true;
            this.customergrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customergrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customergrid.RowHeadersVisible = false;
            this.customergrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.customergrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customergrid.Size = new System.Drawing.Size(960, 569);
            this.customergrid.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Controls.Add(this.editcustbtn);
            this.panel4.Location = new System.Drawing.Point(979, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 74);
            this.panel4.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sortby);
            this.panel2.Controls.Add(this.applybtn);
            this.panel2.Location = new System.Drawing.Point(979, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 90);
            this.panel2.TabIndex = 59;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VG_DB_2013.Properties.Resources.pixel_background_nxwecdh8vgxjfe96;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 786);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortby;
        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.Button editcustbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}