using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Dancemgmt
{
    
    public partial class Frmteacher : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Frmteacher()
        {
            InitializeComponent();
             con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void Frmteacher_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
            
           
           
            
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtmob.Text != "" && txtname.Text != "" && cmbtype.Text != "" && txtAdd.Text != "" && txtEmail.Text != "" && txtsalary.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("insert into Trainer values(" + lblId.Text + ",'" + txtmob.Text + "','" + txtname.Text + "','" + cmbtype.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtsalary.Text + "','" + dateTimePicker2.Value + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("New Trainer Added successfully");
                    cmdSave.Enabled = false;

                    cmdNew.Enabled = true;
                    txtmob.Text = "";
                    txtname.Text = "";
                    cmbtype.Text = "";
                    txtAdd.Text = "";
                    txtEmail.Text = "";
                    txtsalary.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Enter all the fields");

            }
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

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdnew_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select max(tid)+1  from Trainer", con);
            lblId.Text = ((int)cmd.ExecuteScalar()).ToString();
            txtmob.Text = "";
            txtname.Text = "";
            cmbtype.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtsalary.Text = "";

            cmdSave.Enabled = true;
        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }
    }
}
