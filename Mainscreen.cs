using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dancemgmt
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmteacher ob = new Frmteacher();
            ob.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmowner ob = new frmowner();
            ob.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void searchAndUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstaff ob = new frmstaff();
            ob.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frmCustomer ob = new frmCustomer();
            ob.ShowDialog();*/
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprogram ob = new frmprogram();
            ob.ShowDialog();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstafflist ob = new frmstafflist();
            ob.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmbill ob = new frmbill();
            ob.ShowDialog();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmequ ob = new frmequ();
            ob.ShowDialog();
        }

        private void stockUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstock ob = new frmstock();
            ob.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstocklist ob = new frmstocklist();
            ob.ShowDialog();
        }

        private void addStylesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstyle ob = new frmstyle();
            ob.ShowDialog();
        }

        private void studentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer ob = new frmCustomer();
            ob.ShowDialog();
        }

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmattend ob = new frmattend();
            ob.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stylesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmterm ob = new frmterm();
            ob.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustupdate ob = new frmcustupdate();
            ob.ShowDialog();
        }

        private void programListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrepcust ob = new frmrepcust();
            ob.ShowDialog();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreportStudent ob = new frmreportStudent();
            ob.ShowDialog();
        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmreporttrainer ob = new frmreporttrainer();
            ob.ShowDialog();
        }

        private void supplierReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmreportProgram ob = new frmreportProgram();
            ob.ShowDialog();
        }

        private void equipmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEqptreport ob = new frmEqptreport();
            ob.ShowDialog();
        }

        private void helpingStaffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHstaffreport ob = new frmHstaffreport();
            ob.ShowDialog();
        }
    }
}
