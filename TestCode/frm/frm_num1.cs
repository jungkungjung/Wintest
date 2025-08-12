using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Class;

namespace TestCode.frm
{
    public partial class frm_num1 : Form
    {
        List<myData.BarcodeRow> barcodeList = new List<myData.BarcodeRow>();
        List<myData.BarcodeRow> barcodeFrm2_only = new List<myData.BarcodeRow>();
        public frm_num1()
        {
            InitializeComponent();
        }

        private void frm_num1_Load(object sender, EventArgs e)
        {
            barcodeList.Add(new myData.BarcodeRow { BarcodeID = 1, BarcodeNumber = "123456", BarcodeDescription = "Barcode1", BarQty = 1 });
            barcodeList.Add(new myData.BarcodeRow { BarcodeID = 2, BarcodeNumber = "222222", BarcodeDescription = "Barcode2", BarQty = 1 });
            barcodeList.Add(new myData.BarcodeRow
            {
                BarcodeID = 3,
                BarcodeNumber = "333333",
                BarcodeDescription = "Barcode3",
                BarQty = 2
            });
            barcodeList.Add(new myData.BarcodeRow
            {
                BarcodeID = 4,
                BarcodeNumber = "444444",
                BarcodeDescription = "Barcode4",
                BarQty = 1
            });
        }

        private void btn_openFrm2_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(); 
            frm.SetlblDestination = textBox1.Text;  
            frm.Show(); // ShowDialog() will block the current thread until the form is closed

        }

        public delegate void dlgSendData(TextBox textBox);
        private void btn_delegate_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2();
            dlgSendData dlg = new dlgSendData(frm.ReceivedData);   
            dlg.Invoke(this.tb_delegate); // Assuming tb_delegate is a TextBox in frm_num1  
            frm.Show(); // 
        }

        private void btn_formtype_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(); // Assuming you want to reference frm_num1 : //วิธีอ้างด้วย form type  
            frm.frm1 = this; 
            frm.Show(); 
        }

        private void btn_constructure_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(tb_constructure.Text); //อาศัยวิธี constructure
            frm.Show();
        }

        private void btn_construct_ref_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(ref tb_construct_ref); //อาศัยวิธี constructure ref
            frm.Show();
        }

        private void btn_cont2_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(ref tb_constructure_ref2); //อาศัยวิธี constructure ref
            frm.Show();
        }

        private void btn_showlist_Click(object sender, EventArgs e)
        {      
                      grw.DataSource = null; // Clear the existing data source
            if (barcodeFrm2_only.Any()) //เช็ค ว่ามีการ return list มาจาก form2 หรือไม่
            {
                barcodeList.AddRange(barcodeFrm2_only); //addrang list จาก form2
            }   
            grw.DataSource = barcodeList;
        }

        private void btn_list_openForm_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(ref barcodeList); //อาศัยวิธี constructure ref
            frm.Show();
        }

        private void btn_ListNull_Click(object sender, EventArgs e)
        {
            frm_num2 frm = new frm_num2(ref barcodeFrm2_only); //ส่ง ref List เป็นค่า null ไป เพื่อรับกลับมา แล้วใช้วิธี List.addrang จาก list เดิม
            frm.Show();
        }
    }
}
