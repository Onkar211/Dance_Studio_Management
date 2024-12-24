namespace Dancemgmt
{
    partial class frmbill
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
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.btnAddtoBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstyle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbledate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.lbldd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbcust
            // 
            this.cmbcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(1164, 138);
            this.cmbcust.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(247, 37);
            this.cmbcust.TabIndex = 33;
            this.cmbcust.Text = "Select Customer";
            this.cmbcust.SelectedIndexChanged += new System.EventHandler(this.cmbcust_SelectedIndexChanged);
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(1164, 283);
            this.cmbBook.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(247, 37);
            this.cmbBook.TabIndex = 30;
            this.cmbBook.Text = "Select Dance Style";
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoBill.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddtoBill.Location = new System.Drawing.Point(1164, 376);
            this.btnAddtoBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.Size = new System.Drawing.Size(241, 50);
            this.btnAddtoBill.TabIndex = 31;
            this.btnAddtoBill.Text = "Add Item to Bill";
            this.btnAddtoBill.UseVisualStyleBackColor = true;
            this.btnAddtoBill.Visible = false;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1164, 461);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(241, 111);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtmob
            // 
            this.txtmob.Location = new System.Drawing.Point(1164, 90);
            this.txtmob.Margin = new System.Windows.Forms.Padding(4);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(247, 22);
            this.txtmob.TabIndex = 34;
            this.txtmob.Visible = false;
            this.txtmob.TextChanged += new System.EventHandler(this.txtmob_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblstyle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblcust);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbledate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1123, 718);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "/.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstyle
            // 
            this.lblstyle.AutoSize = true;
            this.lblstyle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstyle.Location = new System.Drawing.Point(323, 490);
            this.lblstyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstyle.Name = "lblstyle";
            this.lblstyle.Size = new System.Drawing.Size(73, 33);
            this.lblstyle.TabIndex = 50;
            this.lblstyle.Text = "style";
            this.lblstyle.Click += new System.EventHandler(this.lblstyle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 481);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "Dance Style.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImage = global::Dancemgmt.Properties.Resources.head2;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1123, 168);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblcust
            // 
            this.lblcust.AutoSize = true;
            this.lblcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust.Location = new System.Drawing.Point(107, 249);
            this.lblcust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcust.Name = "lblcust";
            this.lblcust.Size = new System.Drawing.Size(54, 25);
            this.lblcust.TabIndex = 47;
            this.lblcust.Text = "ABC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Dear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(856, 661);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Owner of Mosaic Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(855, 616);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Authorized Sign";
            // 
            // lbledate
            // 
            this.lbledate.AutoSize = true;
            this.lbledate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledate.Location = new System.Drawing.Point(393, 481);
            this.lbledate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbledate.Name = "lbledate";
            this.lbledate.Size = new System.Drawing.Size(0, 31);
            this.lbledate.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 430);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 31);
            this.label10.TabIndex = 39;
            this.label10.Text = "Towards the payment of  ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(323, 367);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 33);
            this.lblSubtotal.TabIndex = 38;
            this.lblSubtotal.Text = "00";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(219, 367);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 31);
            this.label30.TabIndex = 37;
            this.label30.Text = "Rs.";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(209, 309);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(518, 31);
            this.label29.TabIndex = 36;
            this.label29.Text = "Thanking You and Received. The  sum of ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.lbldd);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblBno);
            this.panel2.Location = new System.Drawing.Point(761, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 110);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(17, 54);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 29);
            this.label28.TabIndex = 23;
            this.label28.Text = "Date";
            // 
            // lbldd
            // 
            this.lbldd.AutoSize = true;
            this.lbldd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldd.ForeColor = System.Drawing.Color.Black;
            this.lbldd.Location = new System.Drawing.Point(159, 54);
            this.lbldd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldd.Name = "lbldd";
            this.lbldd.Size = new System.Drawing.Size(60, 29);
            this.lbldd.TabIndex = 22;
            this.lbldd.Text = "date";
            this.lbldd.Click += new System.EventHandler(this.lbldd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(17, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "Receipt No";
            // 
            // lblBno
            // 
            this.lblBno.AutoSize = true;
            this.lblBno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBno.ForeColor = System.Drawing.Color.Black;
            this.lblBno.Location = new System.Drawing.Point(159, 14);
            this.lblBno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBno.Name = "lblBno";
            this.lblBno.Size = new System.Drawing.Size(39, 29);
            this.lblBno.TabIndex = 17;
            this.lblBno.Text = "00";
            // 
            // frmbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1449, 709);
            this.Controls.Add(this.cmbcust);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.btnAddtoBill);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtmob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbill";
            this.Load += new System.EventHandler(this.frmbill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbldd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbledate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBno;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Button btnAddtoBill;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstyle;
        private System.Windows.Forms.Label label1;
    }
}