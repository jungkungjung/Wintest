using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Class;
using static TestCode.Class.firstInterface;

namespace TestCode.frm
{    
    public partial class frm_interface : Form
    {
        // สร้าง interface ขึ้นมาเพื่อให้ class อื่นๆ นำไปใช้ได้  
        public frm_interface()
        {
            InitializeComponent();
        }

        private void btn_interface_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Walk();
            p.Run();

            Cat c = new Cat();
            c.Walk();
            c.Run();
        }
    }
}
