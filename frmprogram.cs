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
    public partial class frmprogram : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmprogram()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSrchname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CommonDialog1Open_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
            OleDbCommand cmd = new OleDbCommand("update Danceprogram set pname='" + txtname.Text + "',pstyle='" + txtstyle.Text + "',pdetails='" + txtdetail.Text + "',pfees='" + txtfee.Text + "',pdate='" + dateTimePicker1 + "' where pname='" + txtSrchname.Text + "'", con);
            int x = cmd.ExecuteNonQuery();



            if (x > 0)
            {
                MessageBox.Show("Program Details Updated");
/*                lblId.Text = "";
*/                txtdetail.Text = "";
                txtname.Text = "";
                txtfee.Text = "";
                txtstyle.Text = "";
               
                dateTimePicker1.Text = "";
                //dateTimePicker2.Text = "";

            }

            else
            {
                MessageBox.Show("Error in Updation");

            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrintID_Click(object sender, EventArgs e)
        {
            programcard ob = new programcard();
            ob.ShowDialog();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtstyle.Text != "" && txtdetail.Text != "" && txtfee.Text != "") 
            {
                //MessageBox.Show("insert into Employee values(" + lblId.Text + ",'" + txtname.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtmob.Text + "','" + dateTimePicker1.Value + "','" + txtSal.Text + "','" + dateTimePicker2.Value + "','" + txtImg.Text + "')");

                OleDbCommand cmd = new OleDbCommand("insert into Danceprogram values(" + lblId.Text + ",'" + txtname.Text + "','" + txtstyle.Text + "','" + txtdetail.Text + "'," + txtfee.Text + ",'" + dateTimePicker1.Value + "')", con);

                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Dance program Added Successfully");
                    cmdSave.Enabled = false;

                    cmdAdd.Enabled = true;
                    /*lblId.Text = "";*/
                    txtdetail.Text = "";
                    txtname.Text = "";
                    txtfee.Text = "";
                    txtstyle.Text = "";
                   
                   /* dateTimePicker1.Text = "";*/
                   

                }
            }
            else
            {
                MessageBox.Show("Enter All the Details");
            }


            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Danceprogram", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select max(pid)+1  from Danceprogram", con);
            lblId.Text = ((int)cmd.ExecuteScalar()).ToString();


           /* lblId.Text = "";*/
            txtdetail.Text = "";
            txtname.Text = "";
            txtfee.Text = "";
            txtstyle.Text = "";

            dateTimePicker1.Text = "";
            cmdSave.Enabled = true;
        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Danceprogram where pname='" + txtSrchname.Text + "'", con);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                DataRow dr;
                dr = dt.Rows[0];
                lblId.Text = dr["pid"].ToString();
                txtname.Text = dr["pname"].ToString();
                txtstyle.Text = dr["pstyle"].ToString();
                txtdetail.Text = dr["pdatails"].ToString();
                dateTimePicker1.Text = dr["pdate"].ToString();
                txtfee.Text = dr["pfees"].ToString();

            }
        }

        private void frmprogram_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Danceprogram", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            charonly(e);
        }

        private void txtfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtstyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
