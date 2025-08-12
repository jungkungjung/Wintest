using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TestCode
{
    public partial class frm_test : Form
    {
        List<string> barcodeString = new List<string>();
        public frm_test()
        {
            InitializeComponent();
        }

        private void bt_paraOut_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test");

            int num;
            ShowNumber(out num);
            MessageBox.Show($"ค่าตัวแปร num : {num}");

        }

        private void ShowNumber(out int x)
        {
            x = 200;
        }

        private void bt_paramRef_Click(object sender, EventArgs e)
        {
            int num = 5;
            ShowNumber_Ref(ref num);
            MessageBox.Show($"ค่าตัวแปร num : {num}");

        }

        private void ShowNumber_Ref(ref int x)
        {
            x = x * 100;
        }

        private void bt_dictionary_Click(object sender, EventArgs e)
        {
            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //Add() method
            dic.Add(101, "Liverpool");
            dic.Add(102, "Arsenal");
            dic.Add(103, "Monaco");
            dic.Add(104, "Barcelona");

            string mappingKey = dic[104]; //find by key

            // Before Remove() method
            foreach (KeyValuePair<int, string> t in dic)
            {
                Console.WriteLine("{0} and {1}", t.Key, t.Value);
            }
            Console.WriteLine();

            //Remove() method 
            dic.Remove(101);

            //Clear() method
            dic.Clear();
        }

        private void bt_interface_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.StartEngine();
            cars.Move();

            Boat boat = new Boat();
            boat.StartEngine();
            boat.Move();

        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            DemoShopEntities db = new DemoShopEntities();
            List<Invoice> inv = new List<Invoice>();
            var data = db.Invoices.ToList();
            grw.DataSource = data;

            decimal total = 100;
            foreach (var item in data)
            {
                inv.Add(new Invoice
                {
                    Inv_id = item.Inv_id,
                    Inv_no = item.Inv_no,
                    Inv_date = item.Inv_date,
                    Inv_amont = item.Inv_amont - total
                });
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            DemoShopEntities db = new DemoShopEntities();
            List<Invoice> inv = new List<Invoice>();
            var data = db.Invoices.ToList();

            decimal total = 1000;
            foreach (var item in data)
            {
                inv.Add(new Invoice
                {
                    Inv_id = item.Inv_id,
                    Inv_no = item.Inv_no,
                    Inv_date = item.Inv_date,
                    Inv_amont = total > item.Inv_amont ? 0 : (item.Inv_amont - total)
                });
                //total = total > item.Inv_amont ? (total - item.Inv_amont) : 0; //ลดค่า total ลง จนเป็น 0
            }

            grw2.DataSource = inv;
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            DemoShopEntities dc = new DemoShopEntities();
            var data1 = dc.tests.Sum(x => x.amt_money);
            double runningTotal = 0;
            var data2 = (from t in dc.test3
                         select new
                         {
                             result = Math.Round((t.amt1 * t.amt2) / t.amt3, 4)                            
                         }).ToList();

            foreach (var item in data2)
            {
                runningTotal = runningTotal + (item.result);
            }   
            //var amt = data3.Sum(x => x.result);
            ///
            //ทดสอบ ทศนิยม ไม่รู้จบ
            using (DemoShopEntities db = new DemoShopEntities())
            {
                var data = db.tests.Sum(x => x.amt_money);

                var data3 = db.test3
                              .AsNoTracking()
                              .Select(t => new
                              {
                                  result = (t.amt1 * t.amt2) / t.amt3
                              })
                              .ToList()
                              .Select(t => new
                              {
                                  result = Math.Round(t.result, 6, MidpointRounding.AwayFromZero)
                              })
                              .ToList();

                var amt = Math.Round( data3.Sum(x => x.result),6, MidpointRounding.AwayFromZero);

                double Total = 0;
                foreach (var item in data3)
                {
                    Total = Total + (item.result);
                }
            }
        }

        private void tb_barcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                barcodeString.Add(tb_barcode.Text);
                e.IsInputKey = true;

                //using (StreamWriter file = File.AppendText(@"D:\Log.txt"))
                //{
                //        file.WriteLine(textBox1.Text);
                //}
                tb_barcode.Clear();
            }
        }

        private void btn_stream_Click(object sender, EventArgs e)
        {
            using (StreamWriter strm = new StreamWriter(@"D:\Log.txt"))
            {
                foreach (var item in barcodeString)
                {
                    strm.WriteLine(item);
                }
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Close();    
        }

        private void btn_datetime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string formattedDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss");    
        }
    }
}
