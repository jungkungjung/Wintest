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
    public partial class frm_Barscanned : Form
    {
        DataTable myDT = new DataTable();
        public frm_Barscanned(DataTable DT)
        {
            myDT = DT;
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            #region by loop
            foreach (DataGridViewRow rows in grw.Rows)
            {
                if (rows.Cells["Inv_no"].Value.ToString().Equals(tb_barcode.Text))
                {
                    rowIndex = rows.Index;
                    grw.CurrentCell = grw.Rows[rowIndex].Cells["Inv_remain"];
                    grw.Rows[grw.CurrentCell.RowIndex].Selected = true;
                    decimal? amt2 = (decimal?)rows.Cells["Inv_remain"].Value;
                    if (amt2 == 0)
                    {
                        return;
                    }
                    rows.Cells["Inv_remain"].Value = amt2 - 1;
                    if ((decimal?)rows.Cells["Inv_remain"].Value == 0)
                    {
                        //grw.Rows.RemoveAt(rowIndex);
                        //grw.EndEdit();
                        //grw.Rows[rowIndex].Visible = false;
                        myDT.DefaultView.RowFilter = "[Inv_remain] > 0";


                        grw.EndEdit();
                        grw.Update();   
                        grw.Refresh(); 
                        //grw.Sort(grw.Columns["Inv_remain"], ListSortDirection.Descending);    
                    }

                    //myDT = myDT.AsEnumerable().Where(x => x["Inv_remain"].ToString() != "0");
                    //myDT = myDT.AsEnumerable().Where(x => decimal.Parse(x["Inv_remain"].ToString()) != 0).CopyToDataTable();
                    //grw.DataSource = myDT;                    
                    //grw.Refresh();
                    break;
                }
                #endregion

            }
        }

        private void frm_Barscanned_Load(object sender, EventArgs e)
        {
            grw.DataSource = myDT; //.DefaultView.RowFilter = "[Inv_remain] > 0";  
            grw.Refresh();  
        }

        private void btn_dt_Click(object sender, EventArgs e)
        {
            frm_barcode.dt = myDT;
            this.Close();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            myDT.DefaultView.RowFilter = "[Inv_remain] > 0";
            grw.DataSource = myDT;
            grw.Refresh();
        }
    }
}
