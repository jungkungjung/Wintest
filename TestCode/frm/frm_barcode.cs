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
    public partial class frm_barcode : Form
    {
        public static DataTable dt = new DataTable();
        //DataTable dt = new DataTable(); 
        List<Invoice> inv = new List<Invoice>();
        public frm_barcode()
        {
            dt.Columns.Add("Inv_id", typeof(int));
            dt.Columns.Add("Inv_no", typeof(string));
            dt.Columns.Add("Inv_date", typeof(DateTime));
            dt.Columns.Add("Inv_amont", typeof(decimal));
            dt.Columns.Add("Inv_remain", typeof(decimal));
            InitializeComponent();
        }

        private void frm_barcode_Load(object sender, EventArgs e)
        {
            DemoShopEntities db = new DemoShopEntities();

            //var data = db.Invoices.ToList();
            inv = db.Invoices.ToList();
            //grw.DataSource = inv; // data;
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            string barcode = tb_barcode.Text;
            //for (int i = 0; i < grw.Rows.Count; i++)
            //{
            //    //Use when column names known
            //    //grw.Rows[i].Cells["columnName"].Value = 1;
            //    //Use when column index known
            //    grw.Rows[i].Cells[3].Value = 2;
            //}
            grw.Rows[1].Cells[3].Value = (decimal?)2;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;

            #region by Linq
            //DataGridViewRow row = grw.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Inv_no"].Value.ToString().Equals(tb_barcode.Text)).First();
            //rowIndex = row.Index;
            //decimal? amt = (decimal?)grw.Rows[rowIndex].Cells["Inv_amont"].Value;
            //grw.Rows[rowIndex].Cells["Inv_amont"].Value = amt - 1;
            //grw.Refresh();
            #endregion

            #region by loop
            foreach (DataGridViewRow rows in grw.Rows)
            {
                if (rows.Cells["Inv_no"].Value.ToString().Equals(tb_barcode.Text))
                {
                    rowIndex = rows.Index;
                    grw.CurrentCell = grw.Rows[rowIndex].Cells["Inv_amont"];
                    grw.Rows[grw.CurrentCell.RowIndex].Selected = true;                   
                    decimal? amt2 = (decimal?)rows.Cells["Inv_amont"].Value;
                    rows.Cells["Inv_amont"].Value = amt2 - 1;

                    if ((decimal?)rows.Cells["Inv_amont"].Value == 0)
                        //grw.Rows.RemoveAt(rowIndex);    
                        inv = inv.Where(x => x.Inv_amont != 0).ToList();
                    grw.DataSource = inv;
                    grw.Refresh();
                    break;
                }
                #endregion

            }
        }

        private void btn_dt_Click(object sender, EventArgs e)
        {
            frm_Barscanned frm = new frm_Barscanned(dt);
            frm.Show();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            grw.DataSource = inv; // data;

            foreach (var item in inv)
            {
                DataRow dr = dt.NewRow();
                dr["Inv_id"] = item.Inv_id;
                dr["Inv_no"] = item.Inv_no;
                dr["Inv_date"] = item.Inv_date;
                dr["Inv_amont"] = item.Inv_amont;
                dr["Inv_remain"] = item.Inv_amont;
                dt.Rows.Add(dr);
            }
        }

        private void lnk_dt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var test = dt;
        }

        private void btn_chkSuccess_Click(object sender, EventArgs e)
        {
            decimal total = dt.AsEnumerable().Sum(x => x.Field<decimal>("Inv_Remain"));
            if (total == 0)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show($"Value still remain : {total}");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
