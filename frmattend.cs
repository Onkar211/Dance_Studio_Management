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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Dancemgmt
{
    public partial class frmattend : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmattend()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void frmattend_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer", con);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbcust.Items.Add(dt.Rows[i]["cname"]);
            }



            DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from Attendance", con);
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cmbCname.Items.Add(dt1.Rows[i]["date"]);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCname.Text != "")
            {
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Attendance where date=" + cmbCname.Text + "", con);
                DataTable dt = new DataTable();
                da.Fill(ds);
                da.Fill(dt);
                if (ds.Tables[0].Rows.Count > 0)
                {


                    dataGridView1.DataSource = ds.Tables[0];


                    /*cmbmob.Text = dt.Rows[0]["cmob"].ToString();
                    dateTimePicker1.Text = dt.Rows[0]["date"].ToString();
                    attend.Text = dt.Rows[0]["report"].ToString();*/
                    
                    cmdUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Product Id You Entered Is Incorrect");
                    cmbmob.Clear();
                    attend.Text ="";
                    dateTimePicker1.Text="";

                    cmbCname.Select();
                }
            }
            else
            {
                MessageBox.Show("select Date");
            }
        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer where cname='" + cmbcust.Text + "'", con);
            da.Fill(dt);
            cmbmob.Text = dt.Rows[0]["cmob"].ToString();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
           /* MessageBox.Show("OK");
            if (cmbmob.Text != "" && attend.Text != "" && dateTimePicker1.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("update Attendance set  report='" + attend.Text + "', date='" + dateTimePicker1.Text + "'where cmob='" + cmbmob.Text + "'", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("Attendance Updated");
                }
                else
                {
                    MessageBox.Show("Error in Updation");
                }
            }*/
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cmbmob.Text != "" && attend.Text != "" && dateTimePicker1.Text != "" )
            {
                OleDbCommand cmd = new OleDbCommand("insert into Attendance values(" + cmbmob.Text + ",'" + dateTimePicker1.Text + "','" + attend.Text + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Attendance Added");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Attendance Add Error!!!");
                }


            }
            else
            {
                MessageBox.Show("Enter All Fields");
            }
        }

        private void cmbcust_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Attendance", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cmbmob_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

