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
    public partial class frm_structure : Form
    {
        //สร้าง struct ขึ้นมา  // เหมือนการสร้าง class สามาาถดึงไปใช้ได้เลย โดยไม่ต้องสร้าง instance
        public struct SimpleStucture
        {
            public int x;
            public int y;
        }

        public struct SimpleStuctureMethod  
        {
            public int x;
            public int y;
            public double Add()
            {
                return x + y;
            }   
        }

        public frm_structure()
        {
            InitializeComponent();
        }

        private void frm_structure_Load(object sender, EventArgs e)
        {
            SimpleStucture ss; //อ้างชื่อ struct ที่สร้างขึ้นมา ไม่ต้องประกาศ new  
            ss.x = 10;
            ss.y = 20;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            int result = 0;
            SimpleStucture yy;
            yy.x = 100;
            yy.y = 200;  
            result = yy.x * yy.y;
            MessageBox.Show($"ค่าตัวแปร result : {result}");  
        }

        private void btn_method_Click(object sender, EventArgs e)
        {
            SimpleStuctureMethod mt;
            mt.x = 800;
            mt.y = 50; 
            mt.Add();
            Console.WriteLine(mt.Add());
        }
    }
}
