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

namespace TestCode.frm
{
    public partial class frm_CrystalReportPassing : Form
    {
        public CrystalReportViewer _crViewer; // ตัวแปรเก็บ CrystalReportViewer ที่ส่งมาจากฟอร์มอื่น    
        public frm_CrystalReportPassing(CrystalReportViewer crViewer)
        {
            InitializeComponent();
            _crViewer = crViewer;
        }

        private void frm_generic_Load(object sender, EventArgs e)
        {
            //crystalReportViewer1.ReportSource = _crViewer.ReportSource; // กำหนดแหล่งข้อมูลรายงาน  
            crystalReportViewer1.ToolPanelView = _crViewer.ToolPanelView; // ซ่อนแถบเครื่องมือด้านข้าง            
            crystalReportViewer1.ShowExportButton = _crViewer.ShowExportButton; // ซ่อนปุ่มส่งออก    
        }
    }
}
