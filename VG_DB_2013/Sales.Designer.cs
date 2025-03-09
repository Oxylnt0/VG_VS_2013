namespace VG_DB_2013
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addsalesbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.sortby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.salesgrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).BeginInit();
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
            this.pictureBox1.BackgroundImage = global::VG_DB_2013.Properties.Resources.GAME_sales_3_9_2025;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-69, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 99);
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
            this.button1.Location = new System.Drawing.Point(1451, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.sortby);
            this.panel3.Controls.Add(this.applybtn);
            this.panel3.Controls.Add(this.addsalesbtn);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.salesgrid);
            this.panel3.Location = new System.Drawing.Point(162, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 630);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // addsalesbtn
            // 
            this.addsalesbtn.BackColor = System.Drawing.Color.Gold;
            this.addsalesbtn.FlatAppearance.BorderSize = 0;
            this.addsalesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addsalesbtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsalesbtn.ForeColor = System.Drawing.Color.Black;
            this.addsalesbtn.Location = new System.Drawing.Point(868, 40);
            this.addsalesbtn.Name = "addsalesbtn";
            this.addsalesbtn.Size = new System.Drawing.Size(237, 44);
            this.addsalesbtn.TabIndex = 54;
            this.addsalesbtn.Text = "Add Sales";
            this.addsalesbtn.UseVisualStyleBackColor = false;
            this.addsalesbtn.Click += new System.EventHandler(this.addsalesbtn_Click);
            // 
            // applybtn
            // 
            this.applybtn.BackColor = System.Drawing.Color.Gold;
            this.applybtn.FlatAppearance.BorderSize = 0;
            this.applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybtn.ForeColor = System.Drawing.Color.Black;
            this.applybtn.Location = new System.Drawing.Point(940, 139);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(165, 25);
            this.applybtn.TabIndex = 25;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = false;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // sortby
            // 
            this.sortby.BackColor = System.Drawing.Color.White;
            this.sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortby.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortby.FormattingEnabled = true;
            this.sortby.Items.AddRange(new object[] {
            "Sales Date - Ascending",
            "Sales Date - Descending",
            "Amount - Ascending",
            "Amount - Descending"});
            this.sortby.Location = new System.Drawing.Point(940, 108);
            this.sortby.Name = "sortby";
            this.sortby.Size = new System.Drawing.Size(165, 25);
            this.sortby.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(883, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sort:";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Gold;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(868, 582);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(237, 30);
            this.refresh.TabIndex = 40;
            this.refresh.Text = "Refresh Table";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // salesgrid
            // 
            this.salesgrid.AllowUserToAddRows = false;
            this.salesgrid.AllowUserToDeleteRows = false;
            this.salesgrid.AllowUserToResizeColumns = false;
            this.salesgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            this.salesgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.salesgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.salesgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salesgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.salesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesgrid.EnableHeadersVisualStyles = false;
            this.salesgrid.GridColor = System.Drawing.Color.White;
            this.salesgrid.Location = new System.Drawing.Point(7, 40);
            this.salesgrid.Name = "salesgrid";
            this.salesgrid.ReadOnly = true;
            this.salesgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.salesgrid.RowHeadersVisible = false;
            this.salesgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.salesgrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.salesgrid.Size = new System.Drawing.Size(855, 572);
            this.salesgrid.TabIndex = 5;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VG_DB_2013.Properties.Resources.pixel_background_nxwecdh8vgxjfe96;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 786);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView salesgrid;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.ComboBox sortby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addsalesbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}