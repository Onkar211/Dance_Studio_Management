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
    public partial class frmstafflist : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmstafflist()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:/c#project/Dance_studio/Dances.mdb";
            con.Open();
        }

        private void frmstafflist_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Staff", con);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
