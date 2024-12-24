using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using System.Xml.Linq;


namespace Dancemgmt
{
    public partial class programcard : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public programcard()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void programcard_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
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
    }
}
