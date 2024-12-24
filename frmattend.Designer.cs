namespace Dancemgmt
{
    partial class frmattend
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
            this.components = new System.ComponentModel.Container();
            this.cmbCname = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.CommonDialog1Open = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cmbmob = new System.Windows.Forms.TextBox();
            this.attend = new System.Windows.Forms.ComboBox();
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCname
            // 
            this.cmbCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCname.FormattingEnabled = true;
            this.cmbCname.Location = new System.Drawing.Point(325, 253);
            this.cmbCname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCname.Name = "cmbCname";
            this.cmbCname.Size = new System.Drawing.Size(203, 33);
            this.cmbCname.TabIndex = 140;
            this.cmbCname.Text = "Search Date";
            this.cmbCname.Visible = false;
            this.cmbCname.SelectedIndexChanged += new System.EventHandler(this.cmbCname_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dancemgmt.Properties.Resources.head2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1121, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 292);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Violet;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(292, 402);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSave.Size = new System.Drawing.Size(204, 58);
            this.cmdSave.TabIndex = 126;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Label12.Location = new System.Drawing.Point(45, 254);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(210, 28);
            this.Label12.TabIndex = 129;
            this.Label12.Text = "Date wise  Searching";
            this.Label12.Visible = false;
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.Color.Violet;
            this.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdUpdate.Location = new System.Drawing.Point(43, 402);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpdate.Size = new System.Drawing.Size(183, 58);
            this.cmdUpdate.TabIndex = 141;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = false;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 346);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(537, 483);
            this.dataGridView1.TabIndex = 138;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.Transparent;
            this.Frame1.Controls.Add(this.cmbmob);
            this.Frame1.Controls.Add(this.attend);
            this.Frame1.Controls.Add(this.cmbcust);
            this.Frame1.Controls.Add(this.cmdSave);
            this.Frame1.Controls.Add(this.dateTimePicker1);
            this.Frame1.Controls.Add(this.cmdUpdate);
            this.Frame1.Controls.Add(this.Label10);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Frame1.Location = new System.Drawing.Point(563, 322);
            this.Frame1.Margin = new System.Windows.Forms.Padding(4);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(536, 507);
            this.Frame1.TabIndex = 128;
            this.Frame1.TabStop = false;
            this.Frame1.Enter += new System.EventHandler(this.Frame1_Enter);
            // 
            // cmbmob
            // 
            this.cmbmob.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmob.Location = new System.Drawing.Point(222, 143);
            this.cmbmob.Name = "cmbmob";
            this.cmbmob.Size = new System.Drawing.Size(247, 28);
            this.cmbmob.TabIndex = 142;
            this.cmbmob.TextChanged += new System.EventHandler(this.cmbmob_TextChanged);
            // 
            // attend
            // 
            this.attend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attend.FormattingEnabled = true;
            this.attend.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.attend.Location = new System.Drawing.Point(222, 219);
            this.attend.Margin = new System.Windows.Forms.Padding(4);
            this.attend.Name = "attend";
            this.attend.Size = new System.Drawing.Size(247, 37);
            this.attend.TabIndex = 60;
            this.attend.Text = "Select ";
            this.attend.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbcust
            // 
            this.cmbcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(222, 60);
            this.cmbcust.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(247, 37);
            this.cmbcust.TabIndex = 58;
            this.cmbcust.Text = "Select Customer";
            this.cmbcust.SelectedIndexChanged += new System.EventHandler(this.cmbcust_SelectedIndexChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(59, 297);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(58, 28);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Date";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(59, 143);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(80, 28);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Mobile";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(59, 60);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(69, 28);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Name";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(59, 228);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(121, 28);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Attendance";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(699, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(298, 55);
            this.label1.TabIndex = 142;
            this.label1.Text = "Attendance ";
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(50, 310);
            this.Button6.Margin = new System.Windows.Forms.Padding(4);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(438, 28);
            this.Button6.TabIndex = 143;
            this.Button6.Text = "Display All Suppliers";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // frmattend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1112, 860);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Frame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmattend";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmattend";
            this.Load += new System.EventHandler(this.frmattend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCname;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button cmdSave;
        public System.Windows.Forms.Label Label12;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button cmdUpdate;
        public System.Windows.Forms.OpenFileDialog CommonDialog1Open;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.Label Label10;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox attend;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcust;
        internal System.Windows.Forms.Button Button6;
        private System.Windows.Forms.TextBox cmbmob;
    }
}