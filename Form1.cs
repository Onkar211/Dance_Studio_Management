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
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {



                OleDbCommand cmd = new OleDbCommand("select count(*) from Admin where uname='" + txtUserName.Text + "'and upass='" + txtPassword.Text + "'", con);
                int x = (int)cmd.ExecuteScalar();

                if (x > 0)
                {
                    frmload ob = new frmload();
                    ob.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClosePicturebox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
