using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode.frm
{
    public partial class frm_rpt : Form
    {
        private ReportDocument rpd = new ReportDocument();

        public frm_rpt()
        {
            InitializeComponent();

        }

        public frm_rpt(ReportDocument reportDoc)
        {
            InitializeComponent();
            rpd = reportDoc;    
        }

        private void frm_rpt_Load(object sender, EventArgs e)
        {
            foreach (Control control in crystalReportViewer1.Controls)
            {
                if (control is ToolStrip)
                {
                    foreach (ToolStripItem item in ((ToolStrip)control).Items)
                    {
                        Console.WriteLine(item.AccessibleName);
                        if (item.AccessibleName == "Print Report") //"Imprimir Relatório")
                        {
                            ToolStripButton prtButton = (ToolStripButton)item;
                            prtButton.Click += new EventHandler(dostuff);
                            break;
                        }
                    }
                    break;
                }
            }

        }

        private void dostuff(object sender, EventArgs e)
        {
            // Handle the print button click event here
            MessageBox.Show("Print button clicked!");
            // You can add your custom logic for printing the report here
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                rpd.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                rpd.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
        }

        private void btn_print_MouseHover(object sender, EventArgs e)
        {
            btn_print.FlatStyle = FlatStyle.Standard;
        }

        private void btn_print_MouseLeave(object sender, EventArgs e)
        {
            btn_print.FlatStyle = FlatStyle.Flat;
        }

        private void btn_print_MouseEnter(object sender, EventArgs e)
        {
            btn_print.FlatStyle = FlatStyle.Standard;
        }

        private void btn_print_MouseClick(object sender, MouseEventArgs e)
        {
            btn_print.FlatStyle = FlatStyle.Flat;
        }

        private void btn_print_MouseDown(object sender, MouseEventArgs e)
        {
            btn_print.FlatStyle = FlatStyle.Flat;
        }
    }
}
