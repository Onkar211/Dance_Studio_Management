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
using System.Drawing.Printing;


namespace Dancemgmt
{
    public partial class frmbill : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public frmbill()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void frmbill_Load(object sender, EventArgs e)
        {
            lbldd.Text = DateTime.Today.ToString();

            OleDbCommand cmd = new OleDbCommand("select max(bid)+1  from bill", con);
            lblBno.Text = ((int)cmd.ExecuteScalar()).ToString();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer", con);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbcust.Items.Add(dt.Rows[i]["cname"]);


            }

            DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from style", con);
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cmbBook.Items.Add(dt1.Rows[i]["sname"]);


            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            if (cmbBook.Text != "")
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into billshort values(" + lblBno.Text + ", '" + cmbBook.Text + "')", con);
                int x = cmd1.ExecuteNonQuery();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from tem_bill where cname='" + cmbcust.Text + "'", con);

            cmbBook.Items.Clear();

            da1.Fill(dt1);
            for (int z = 0; z < dt1.Rows.Count; z++)
            {
                cmbBook.Items.Add(dt1.Rows[z]["pname"]);
            }*/


            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer where cname='" + cmbcust.Text + "'", con);
            da.Fill(dt);
            lblcust.Text = dt.Rows[0]["cname"].ToString();
            txtmob.Text = dt.Rows[0]["cmob"].ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand("insert into bill values(" + lblBno.Text + ",'" + txtmob.Text + "','" + lbldd.Text + "','" + lblSubtotal.Text + "')", con);
            cmd.ExecuteNonQuery();



            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();
            PrinterSettings PrinterSetting = new PrinterSettings();
            //Pd.PrinterSettings.PrinterName = "Eltron P310 Card Printer";
            Pd.PrinterSettings.Copies = 1;
            Pd.PrinterSettings.DefaultPageSettings.Landscape = true;

            Pd.PrintPage += printDocument1_PrintPage;
            ppd.Document = Pd;
            ppd.ShowDialog();

            btnPrint.Enabled = false;
        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Style where sname='" + cmbBook.Text + "'", con);
            da.Fill(dt);
            lblstyle.Text = dt.Rows[0]["sname"].ToString();
            lblSubtotal.Text = dt.Rows[0]["sfee"].ToString();
/*            lbledate.Text = dt.Rows[0]["edate"].ToString();
*/            // lblBno.Text = dt.Rows[0]["bid"].ToString();
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void lblstyle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbldd_Click(object sender, EventArgs e)
        {

        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
