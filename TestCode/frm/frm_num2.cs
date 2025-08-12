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
    public partial class frm_num2 : Form
    {
        public frm_num1 frm1; // Assuming you want to reference frm_num1  : ใช้วิธีอ้างด้วย form type  

        private TextBox _textbox; // Assuming you want to reference a TextBox in frm_num1 : อาศัย constructure แบบ ref   
        List<myData.BarcodeRow> _barcodeList = new List<myData.BarcodeRow>();
        internal string SetlblDestination // Property to set the label text from another form : วิธีอ้างด้วย properties
        {
            set { label1.Text = value; }
        }   
        public frm_num2()
        {
            InitializeComponent();
        }

        public frm_num2(string str) //อาศัย constructure
        {
            InitializeComponent();
            label1.Text = str;
        }

        public frm_num2(ref TextBox tb) //อาศัย constructure แบบ ref
        {
            InitializeComponent();
            _textbox = tb; 
        }

        public frm_num2(ref List<myData.BarcodeRow> barlist) //อาศัย constructure แบบ ref
        {
            InitializeComponent();
            _barcodeList = barlist;
        }

        private void frm_num2_Load(object sender, EventArgs e)
        {
            //label1.Text = frm1.tb_formtype.Text; // Assuming you want to set the label text to the TextBox text from frm_num1
        }

        public void ReceivedData(TextBox txt) //ใช้วิธี delegate
        {
            label1.Text = txt.Text; // Assuming you want to set the label text to the TextBox text
        }

        private void tb_send_TextChanged(object sender, EventArgs e) //อาศัยวิธี constructure ref
        {
            //_textbox.Text = tb_send.Text; // Assuming you want to set the label text to the TextBox text    
        }

        private void tb_execute_Click(object sender, EventArgs e)
        {
            _textbox.Text = tb_test.Text; // Assuming you want to set the label text to the TextBox text    
        }

        private void bt_showList_Click(object sender, EventArgs e)
        {
           grw.DataSource = _barcodeList;  
        }

        private void btn_returnList_Click(object sender, EventArgs e)
        {
              List<myData.BarcodeRow> myList1 = new List<myData.BarcodeRow>
            {
                new myData.BarcodeRow { BarcodeID = 5, BarcodeNumber = "555555", BarcodeDescription = "Barcode5", BarQty = 1 },
                new myData.BarcodeRow { BarcodeID = 6, BarcodeNumber = "666666", BarcodeDescription = "Barcode6", BarQty = 1 },
                new myData.BarcodeRow { BarcodeID = 7, BarcodeNumber = "777777", BarcodeDescription = "Barcode7", BarQty = 1 }
            };
            _barcodeList.AddRange(myList1);
        }

        private void btn_returnOnly_Click(object sender, EventArgs e)
        {
            List<myData.BarcodeRow> myList1 = new List<myData.BarcodeRow>
            {
                new myData.BarcodeRow { BarcodeID = 10, BarcodeNumber = "ABCD10", BarcodeDescription = "Barcode10", BarQty = 1 },
                new myData.BarcodeRow { BarcodeID = 11, BarcodeNumber = "ABCD11", BarcodeDescription = "Barcode11", BarQty = 1 },
                new myData.BarcodeRow { BarcodeID = 12, BarcodeNumber = "ABCD11", BarcodeDescription = "Barcode12", BarQty = 1 }
            };
            _barcodeList.AddRange(myList1);
        }
    }
}
