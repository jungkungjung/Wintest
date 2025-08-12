using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.frm;

namespace TestCode
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }    

        private void ts_test_Click(object sender, EventArgs e)
        {
            frm_test frm = new frm_test();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;  
            frm.Show();
        }

        private void ts_barcode_Click(object sender, EventArgs e)
        {
            frm_barcode frm = new frm_barcode();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void ts_list_Click(object sender, EventArgs e)
        {
            frm_List frm = new frm_List();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mn_structure_Click(object sender, EventArgs e)
        {
            frm_structure frm = new frm_structure();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mn_interface_Click(object sender, EventArgs e)
        {
            frm_interface frm = new frm_interface();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mn_delegate_Click(object sender, EventArgs e)
        {
            frm_delegate frm = new frm_delegate();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mn_passingform_Click(object sender, EventArgs e)
        {
            frm_num1 frm = new frm_num1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frm_CrystalReport();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_CrystalConstructure_Click(object sender, EventArgs e)
        {
            var crViewer = new CrystalReportViewer(); // สร้าง CrystalReportViewer ใหม่   
            crViewer.ShowExportButton = false;
            crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            var frm = new frm_CrystalReportPassing(crViewer); // สร้าง frm_generic และส่ง CrystalReportViewer ที่สร้างขึ้นใหม่ไปยังฟอร์มนี้  

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_generic_Click(object sender, EventArgs e)
        {
            var frm = new frm_Generic();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
