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
    public partial class frm_Generic : Form
    {
        public frm_Generic()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DemoShopEntities db = new DemoShopEntities();
            var data = db.Invoices.ToList();
            grw.DataSource = data;

        }

        private void btn_generic1_Click(object sender, EventArgs e)
        {
            showData(10);
            showData(3.14f);
            showData("Hello World");
        }

        private void showData<T>(T x)
        {
            string result = x.ToString();
            MessageBox.Show($"Generic Method : {result}");
        }

        private void btn_listGeneric_Click(object sender, EventArgs e)
        {
            //List<T> mylist = new List<T>();
        }

        private void btn_generic2_Click(object sender, EventArgs e)
        {
            processData<int, string>(100, "Test String");
        }

        private void processData<T, U>(T data1, U data2)
        {
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }
    }

}
