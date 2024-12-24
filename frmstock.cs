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
    public partial class frmstock : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmstock()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            if (cmbName.Text != "" &&  cmbdesign.Text != "" && cmbcat.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("update Product set  pname='" + cmbName.Text + "', price='" + cmbdesign.Text + "', pcolor='" + cmbcat.Text + "', pqty='" + txtqty.Text + "'where pname='" + cmbName.Text + "'", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("Product Updated");
                }
                else
                {
                    MessageBox.Show("Error in Updation");
                }
            }
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmbdesign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbwt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cmbCname_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Product where pname='" + cmbCname.Text + "'", con);
            da.Fill(dt);
            cmbCname.Text = dt.Rows[0]["pname"].ToString();
            lblId.Text = dt.Rows[0]["pid"].ToString();
            cmbName.Text = dt.Rows[0]["pname"].ToString();
           
            cmbdesign.Text = dt.Rows[0]["price"].ToString();
            cmbcat.Text = dt.Rows[0]["pcolor"].ToString();
            txtqty.Text = dt.Rows[0]["pqty"].ToString();
        }

        private void frmstock_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from Product", con);
            da2.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbCname.Items.Add(dt.Rows[i]["pname"].ToString());
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Frame1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cmbName_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            if (cmbName.Text != "" && cmbdesign.Text != "" && cmbcat.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("update Product set  pname='" + cmbName.Text + "', price='" + cmbdesign.Text + "', pcolor='" + cmbcat.Text + "', pqty='" + txtqty.Text + "'where pname='" + cmbName.Text + "'", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("Product Updated");
                }
                else
                {
                    MessageBox.Show("Error in Updation");
                }
            }
        }

        private void cmbName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
