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
using System.Xml.Linq;

namespace Dancemgmt
{
    public partial class frmowner : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmowner()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmowner_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from Owner", con);
            da2.Fill(dt);
            lblmob.Text = dt.Rows[0]["omob"].ToString();
            lblname.Text = dt.Rows[0]["oname"].ToString();
            txtAdd.Text = dt.Rows[0]["oadd"].ToString();
            lblemail.Text = dt.Rows[0]["oemail"].ToString();
           
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
