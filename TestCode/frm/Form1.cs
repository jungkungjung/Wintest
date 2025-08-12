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
    public partial class Form1 : Form
    {
        public Form1() //(Form2 otherForm)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                string valueFromForm2 = form2.MyString2;
                MessageBox.Show($"Value from Form2: {valueFromForm2}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(mystring1);   
        }

        private void btn_byref_Click(object sender, EventArgs e)
        {
            string testStr = "1234";    
            Form2 form2 = new Form2(ref testStr);
            form2.Show();
        }

        private void btn_delegate_Click(object sender, EventArgs e)
        {
            UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateTextBox);
            using (Form2 form2 = new Form2(updateTextDelegate))
            {
                form2.ShowDialog();
            }
        }

        private void UpdateTextBox(string text)
        {
            // Update a TextBox or perform any other action with the text
            textBox1.Text = text;
        }

    }
}
