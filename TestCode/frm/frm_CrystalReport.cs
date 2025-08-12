using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TestCode.frm
{
    public partial class frm_CrystalReport : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public frm_CrystalReport()
        {
            InitializeComponent();
        }

        private void frm_CrystalReport_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("SLMN_ID", typeof(int));
            dt.Columns.Add("SLMN_CODE", typeof(string));
            dt.Columns.Add("SLMN_NAME", typeof(string));
            dt.Columns.Add("SLMN_TEL", typeof(string));
            dt.Columns.Add("SLMN_MAIL", typeof(string));
            dt.Columns.Add("SLMN_REMARK", typeof(string));

            dt.Rows.Add(1, "SL1001", "Peter Corpdirandon", "061-3440348", "peter@hotmail.com","test");
            dt.Rows.Add(2, "SL1002", "Jame Medison", "083-6518430", "jememedi@gmail.com","test");
            dt.Rows.Add(3, "SL1003", "Robert Downing", "064-6789330", "roberatdown@hotmail.com", "test"  );

            dt2.Columns.Add("CustomerID", typeof(string));
            dt2.Columns.Add("CompanyName", typeof(string));
            dt2.Columns.Add("ContactName", typeof(string));
            dt2.Columns.Add("ContactTitle", typeof(string));
            dt2.Rows.Add("CS1001", "Peter Corpdirandon", "peter@hotmail.com", "test");
            dt2.Rows.Add("CS1002", "Jame Medison",  "jememedi@gmail.com", "test");
            dt2.Rows.Add("CS1003", "Robert Downing", "roberatdown@hotmail.com", "test");
        }

        private void btn_printdialog_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Assuming you have a method to print the report
                //PrintReport(printDialog.PrinterSettings);
                //frm_CrystalReport3 reportForm = new frm_CrystalReport3();

                //var a = printDialog.PrinterSettings.PrinterName;
                //var b = printDialog.PrinterSettings.DefaultPageSettings;  
                //var c = printDialog.PrinterSettings.DefaultPageSettings.PrinterSettings;
                //var d = printDialog.PrinterSettings.PaperSizes;    

                ReportDocument rpd = new ReportDocument();
                //rpd.Load("path_to_your_report.rpt");
                //rpd.Load("");
                rpd.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                rpd.PrintToPrinter(printDialog.PrinterSettings.Copies, false, 0, 0);


            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_rpt frm = new frm_rpt();
            ReportDocument rpd = new ReportDocument();
            string rptfile = Path.Combine(Application.StartupPath, "Report.rpt");
            rpd.Load(rptfile);
            rpd.SetDataSource(dt);
            rpd.SetParameterValue("ThaicompanyName", "Asus ThaiLand united");
            rpd.SetParameterValue("head_text", "Saleman List");
            frm.crystalReportViewer1.ReportSource = rpd;
            frm.Show();

        }

        private void btn_printEmpty_Click(object sender, EventArgs e)
        {
            frm_rpt frm = new frm_rpt();
            ReportDocument rpd = new ReportDocument();
            string rptfile = Path.Combine(Application.StartupPath, "Report1.rpt");
            rpd.Load(rptfile);
            //rpd.SetDataSource(dt);
            rpd.SetParameterValue("ThaicompanyName", "Asus ThaiLand united");
            rpd.SetParameterValue("head_text", "Saleman List");
            frm.crystalReportViewer1.ReportSource = rpd;
            frm.ShowDialog();
        }

        private void btn_printXsd_Click(object sender, EventArgs e)
        {
            frm_rpt frm = new frm_rpt();
            ReportDocument rpd = new ReportDocument();
            string rptfile = Path.Combine(Application.StartupPath, "Report2.rpt");
            rpd.Load(rptfile);
            rpd.SetDataSource(dt2);
            //rpd.SetParameterValue("ThaicompanyName", "Asus ThaiLand united");
            //rpd.SetParameterValue("head_text", "Saleman List");
            frm.crystalReportViewer1.ReportSource = rpd;
            frm.Show();
        }

        private void btn_passingReportDocument_Click(object sender, EventArgs e)
        {            
            ReportDocument rpd = new ReportDocument();
            string rptfile = Path.Combine(Application.StartupPath, "Report2.rpt");
            rpd.Load(rptfile);
            rpd.SetDataSource(dt2);
            frm_rpt frm = new frm_rpt(rpd);
            frm.crystalReportViewer1.ReportSource = rpd;
            frm.ShowDialog();
        }
    }
}
