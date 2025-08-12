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
    public partial class frm_delegate : Form
    {
        public delegate void dlgSub();
        public delegate string dlgFucntion(string str); 
        public frm_delegate()
        {
            InitializeComponent();
        }

        private void btn_delegate_Click(object sender, EventArgs e)
        {
            dlgSub testSub = new dlgSub(this.ShowMessage);  
            testSub(); // เรียกใช้ซับรูทีน
        }

        private void bnt_function_Click(object sender, EventArgs e)
        {
            dlgFucntion testfunction = new dlgFucntion(this.ShowMessageWithName);
            string result = testfunction("น้องบีม");
            MessageBox.Show(result, "ฟังก์ชัน ทำงาน"); 
        }

        public void ShowMessage()
        {
            MessageBox.Show("สวัสดีครับ", "ซับรูทีน ทำงาน");
        }

        public string ShowMessageWithName(string name)
        {
            string str = $"สวัสดีครับ คุณ{name}";
            return str;
        }

        
    }
}
