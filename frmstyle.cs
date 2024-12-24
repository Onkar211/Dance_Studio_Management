using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Dancemgmt
{
    public partial class frmstyle : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmstyle()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbdesign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmstyle_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private void cmdImage_Click(object sender, EventArgs e)
        {
            CommonDialog1Open.ShowDialog();
            txtImg.Text = CommonDialog1Open.FileName;
            txtImg.Image = Image.FromFile(txtImg.Text);

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select max(sid)+1  from Style", con);
            lblId.Text = ((int)cmd.ExecuteScalar()).ToString();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( cmbName.Text != "" && txtImg.Text != "" && txtprice.Text != "") 
            {
                OleDbCommand cmd = new OleDbCommand("insert into style values(" + lblId.Text + ",'" + cmbName.Text + "','" + txtImg.Text + "','" + txtprice.Text + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Style Added");
                }

                
                lblId.Text = "";
               
                cmbName.Text = "";
                txtprice.Text = "";


                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter All The Fields");
            }
        }

        private void cmbdesign_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CommonDialog1Open_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void charonly(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Only Char are allowed");
                e.Handled = true;
            }
        }

        public void digitonly(KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter only digit and decimal point.", "Alert!");
                }
            }
            catch { }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }
    }
}
