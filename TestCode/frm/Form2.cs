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
    public delegate void UpdateTextDelegate(string text);
    public partial class Form2 : Form
    {
        //public delegate void UpdateTextDelegate(string text);
        public string MyString2 { get; private set; } = "";

        private readonly UpdateTextDelegate _updateTextDelegate;
        public Form2(UpdateTextDelegate updateTextDelegate)
        {
            _updateTextDelegate = updateTextDelegate;
            InitializeComponent();
        }

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ref string test)
        {
            test = "Hello";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MyString2 = textBox1.Text;

            _updateTextDelegate?.Invoke(textBox1.Text);
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
