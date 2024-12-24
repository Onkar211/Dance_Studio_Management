namespace Dancemgmt
{
    partial class frmload
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(91, 695);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(707, 10);
            this.ProgressBar1.TabIndex = 4;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.Color.White;
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Image1.Image = global::Dancemgmt.Properties.Resources.load;
            this.Image1.Location = new System.Drawing.Point(-57, -64);
            this.Image1.Margin = new System.Windows.Forms.Padding(4);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(1054, 733);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 9;
            this.Image1.TabStop = false;
            this.Image1.Click += new System.EventHandler(this.Image1_Click);
            // 
            // frmload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 635);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmload";
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Image1;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.ProgressBar ProgressBar1;
        public System.Windows.Forms.ToolTip ToolTip1;
    }
}