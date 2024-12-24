namespace Dancemgmt
{
    partial class frmstyle
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.CommonDialog1Open = new System.Windows.Forms.OpenFileDialog();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdImage = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1501, 339);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(281, 503);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(296, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(314, 55);
            this.label1.TabIndex = 58;
            this.label1.Text = " Dance Style";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // CommonDialog1Open
            // 
            this.CommonDialog1Open.FileOk += new System.ComponentModel.CancelEventHandler(this.CommonDialog1Open_FileOk);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Window;
            this.Frame1.BackgroundImage = global::Dancemgmt.Properties.Resources.backin1;
            this.Frame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Frame1.Controls.Add(this.cmbName);
            this.Frame1.Controls.Add(this.txtprice);
            this.Frame1.Controls.Add(this.label7);
            this.Frame1.Controls.Add(this.label4);
            this.Frame1.Controls.Add(this.cmdImage);
            this.Frame1.Controls.Add(this.txtImg);
            this.Frame1.Controls.Add(this.lblId);
            this.Frame1.Controls.Add(this.btnSave);
            this.Frame1.Controls.Add(this.btnAdd);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Frame1.Location = new System.Drawing.Point(-6, 113);
            this.Frame1.Margin = new System.Windows.Forms.Padding(4);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(919, 507);
            this.Frame1.TabIndex = 50;
            this.Frame1.TabStop = false;
            this.Frame1.Enter += new System.EventHandler(this.Frame1_Enter);
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.Color.White;
            this.cmbName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.ForeColor = System.Drawing.Color.Black;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Items.AddRange(new object[] {
            "Ballet",
            "Hip hop ",
            "Tap ",
            "Jazz ",
            "Salsa ",
            "modern "});
            this.cmbName.Location = new System.Drawing.Point(290, 155);
            this.cmbName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(326, 36);
            this.cmbName.TabIndex = 151;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.Gainsboro;
            this.txtprice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(289, 222);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.MaxLength = 10;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(327, 35);
            this.txtprice.TabIndex = 149;
            this.txtprice.TextChanged += new System.EventHandler(this.cmbdesign_TextChanged);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 35);
            this.label7.TabIndex = 148;
            this.label7.Text = "Fees";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 35);
            this.label4.TabIndex = 146;
            this.label4.Text = "Image";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmdImage
            // 
            this.cmdImage.BackColor = System.Drawing.Color.White;
            this.cmdImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdImage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdImage.Location = new System.Drawing.Point(289, 311);
            this.cmdImage.Margin = new System.Windows.Forms.Padding(4);
            this.cmdImage.Name = "cmdImage";
            this.cmdImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImage.Size = new System.Drawing.Size(123, 55);
            this.cmdImage.TabIndex = 144;
            this.cmdImage.Text = "Browse Image...";
            this.cmdImage.UseVisualStyleBackColor = false;
            this.cmdImage.Click += new System.EventHandler(this.cmdImage_Click);
            // 
            // txtImg
            // 
            this.txtImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImg.Image = global::Dancemgmt.Properties.Resources.images;
            this.txtImg.Location = new System.Drawing.Point(457, 289);
            this.txtImg.Margin = new System.Windows.Forms.Padding(4);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(119, 95);
            this.txtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtImg.TabIndex = 145;
            this.txtImg.TabStop = false;
            this.txtImg.Click += new System.EventHandler(this.Image1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblId.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(285, 94);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 29);
            this.lblId.TabIndex = 117;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(684, 98);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 87);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(684, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 87);
            this.btnAdd.TabIndex = 109;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label3.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(76, 154);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(148, 35);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "Style Name";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(77, 94);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 35);
            this.Label2.TabIndex = 99;
            this.Label2.Text = "Style Id";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // frmstyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmstyle";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmstyle";
            this.Load += new System.EventHandler(this.frmstyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.GroupBox Frame1;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button cmdImage;
        public System.Windows.Forms.PictureBox txtImg;
        internal System.Windows.Forms.Label label4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.OpenFileDialog CommonDialog1Open;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbName;
    }
}