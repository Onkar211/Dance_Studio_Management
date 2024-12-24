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
    public partial class frmequ : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmequ()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select max(pid)+1  from Product", con);
            lblId.Text = ((int)cmd.ExecuteScalar()).ToString();
        }

        private void frmequ_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbcat.Text != "" && cmbdesign.Text != "" && cmbName.Text != "" && txtqty.Text != "" && txtImg.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("insert into Product values(" + lblId.Text + ",'" + cmbName.Text + "','" + cmbcat.Text + "','" + cmbdesign.Text + "'," + txtqty.Text + ",'" + txtImg.Text + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Product Added");
                }

                txtqty.Clear();
                lblId.Text = "";
                cmbcat.Text = "";
                cmbdesign.Text = "";
                cmbName.Text = "";
                


                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter All The Fields");
            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdesign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdImage_Click(object sender, EventArgs e)
        {
            CommonDialog1Open.ShowDialog();
            txtImg.Text = CommonDialog1Open.FileName;
            txtImg.Image = Image.FromFile(txtImg.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void cmbdesign_TextChanged(object sender, EventArgs e)
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

        private void cmbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }

        private void cmbcat_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }

        private void cmbdesign_KeyPress(object sender, KeyPressEventArgs e)
        {
                   digitonly(e);

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }
    }
}
