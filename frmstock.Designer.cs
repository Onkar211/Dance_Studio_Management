namespace Dancemgmt
{
    partial class frmstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstock));
            this.cmbCname = new System.Windows.Forms.ComboBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label8 = new System.Windows.Forms.Label();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbName = new System.Windows.Forms.TextBox();
            this.cmbcat = new System.Windows.Forms.TextBox();
            this.cmbdesign = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.CommonDialog1Open = new System.Windows.Forms.OpenFileDialog();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCname
            // 
            this.cmbCname.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCname.FormattingEnabled = true;
            this.cmbCname.Location = new System.Drawing.Point(723, 240);
            this.cmbCname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCname.Name = "cmbCname";
            this.cmbCname.Size = new System.Drawing.Size(274, 36);
            this.cmbCname.TabIndex = 134;
            this.cmbCname.Text = "Search the product";
            this.cmbCname.SelectedIndexChanged += new System.EventHandler(this.cmbCname_SelectedIndexChanged);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.Color.White;
            this.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpdate.Enabled = false;
            this.cmdUpdate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdate.Image")));
            this.cmdUpdate.Location = new System.Drawing.Point(770, 39);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpdate.Size = new System.Drawing.Size(187, 88);
            this.cmdUpdate.TabIndex = 127;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdUpdate.UseVisualStyleBackColor = false;
            this.cmdUpdate.Visible = false;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label8.Location = new System.Drawing.Point(764, 178);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(201, 35);
            this.Label8.TabIndex = 129;
            this.Label8.Text = " Select Product  ";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.Transparent;
            this.Frame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Frame1.Controls.Add(this.button1);
            this.Frame1.Controls.Add(this.cmbName);
            this.Frame1.Controls.Add(this.cmbcat);
            this.Frame1.Controls.Add(this.cmbCname);
            this.Frame1.Controls.Add(this.cmdUpdate);
            this.Frame1.Controls.Add(this.cmbdesign);
            this.Frame1.Controls.Add(this.lblId);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.label7);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.txtqty);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Frame1.Location = new System.Drawing.Point(1, 128);
            this.Frame1.Margin = new System.Windows.Forms.Padding(4);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(1023, 461);
            this.Frame1.TabIndex = 136;
            this.Frame1.TabStop = false;
            this.Frame1.Enter += new System.EventHandler(this.Frame1_Enter_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(770, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 75);
            this.button1.TabIndex = 150;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.ForeColor = System.Drawing.Color.Black;
            this.cmbName.Location = new System.Drawing.Point(264, 141);
            this.cmbName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbName.MaxLength = 10;
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(327, 35);
            this.cmbName.TabIndex = 149;
            this.cmbName.TextChanged += new System.EventHandler(this.cmbName_TextChanged);
            this.cmbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbName_KeyPress);
            // 
            // cmbcat
            // 
            this.cmbcat.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbcat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcat.ForeColor = System.Drawing.Color.Black;
            this.cmbcat.Location = new System.Drawing.Point(264, 208);
            this.cmbcat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcat.MaxLength = 10;
            this.cmbcat.Name = "cmbcat";
            this.cmbcat.Size = new System.Drawing.Size(327, 35);
            this.cmbcat.TabIndex = 148;
            // 
            // cmbdesign
            // 
            this.cmbdesign.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbdesign.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdesign.ForeColor = System.Drawing.Color.Black;
            this.cmbdesign.Location = new System.Drawing.Point(264, 274);
            this.cmbdesign.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdesign.MaxLength = 10;
            this.cmbdesign.Name = "cmbdesign";
            this.cmbdesign.Size = new System.Drawing.Size(327, 35);
            this.cmbdesign.TabIndex = 147;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblId.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(259, 78);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 31);
            this.lblId.TabIndex = 117;
            this.lblId.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 35);
            this.label7.TabIndex = 111;
            this.label7.Text = "Price";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label6.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(51, 208);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(77, 35);
            this.Label6.TabIndex = 107;
            this.Label6.Text = "Color";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.Gainsboro;
            this.txtqty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.Black;
            this.txtqty.Location = new System.Drawing.Point(263, 335);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.MaxLength = 10;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(327, 35);
            this.txtqty.TabIndex = 104;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label5.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(51, 335);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 35);
            this.Label5.TabIndex = 101;
            this.Label5.Text = "Quantity";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label3.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(50, 138);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(183, 35);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "Product Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(51, 78);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(135, 35);
            this.Label2.TabIndex = 99;
            this.Label2.Text = "Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(212, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(637, 55);
            this.label1.TabIndex = 58;
            this.label1.Text = "Update Equipment Product";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Dancemgmt.Properties.Resources.dd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 574);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmstock";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmstock";
            this.Load += new System.EventHandler(this.frmstock_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCname;
        public System.Windows.Forms.Button cmdUpdate;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.GroupBox Frame1;
        internal System.Windows.Forms.TextBox cmbcat;
        internal System.Windows.Forms.TextBox cmbdesign;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtqty;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.OpenFileDialog CommonDialog1Open;
        internal System.Windows.Forms.TextBox cmbName;
    }
}