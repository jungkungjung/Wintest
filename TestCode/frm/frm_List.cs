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
using TestCode.Models;

namespace TestCode.frm
{
    public partial class frm_List : Form
    {
        List<myData.BarcodeRow> barcodeList = new List<myData.BarcodeRow>();
        List<string> strList = new List<string>();

        List<InvoiceModel.InvoiceLine> InvData;
        List<InvoiceModel.BatchRow> BatchData;
        public frm_List()
        {
            InitializeComponent();
        }

        private void btn_addList1_Click(object sender, EventArgs e)
        {
            barcodeList.Add(new myData.BarcodeRow { BarcodeID = 1, BarcodeNumber = "123456", BarcodeDescription = "Barcode1", BarQty = 1 });
            barcodeList.Add(new myData.BarcodeRow { BarcodeID = 2, BarcodeNumber = "222222", BarcodeDescription = "Barcode2", BarQty = 1 });
            barcodeList.Add(new myData.BarcodeRow
            {
                BarcodeID = 3,
                BarcodeNumber = "333333",
                BarcodeDescription = "Barcode3",
                BarQty = 2
            });
        }

        private void btn_addList2_Click(object sender, EventArgs e)
        {
            List<myData.BarcodeRow> myList1 = new List<myData.BarcodeRow>
            {
                new myData.BarcodeRow { BarcodeID = 4, BarcodeNumber = "444444", BarcodeDescription = "Barcode4", BarQty = 1},
                new myData.BarcodeRow { BarcodeID = 5, BarcodeNumber = "555555", BarcodeDescription = "Barcode5", BarQty = 1 },
                new myData.BarcodeRow { BarcodeID = 6, BarcodeNumber = "666666", BarcodeDescription = "Barcode6", BarQty = 1 }
            };
            barcodeList.AddRange(myList1); 

        }

        private void btn_addRang_Click_1(object sender, EventArgs e)
        {
            var newBarcodeList = new List<myData.BarcodeRow>();
            newBarcodeList.AddRange(barcodeList);

        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            var BarcodeAssign = new List<myData.BarcodeRow>();
            BarcodeAssign = barcodeList;    
        }

        private void btn_listString_Click(object sender, EventArgs e)
        {
            strList.Add("String1");
            strList.Add("String2");
            strList.Add("String3"); 
            strList.Add("String4");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void getData()
        {
            List<InvoiceModel.InvoiceLine> oINV = new List<InvoiceModel.InvoiceLine>()
            {
                new InvoiceModel.InvoiceLine { ItemCode = "item101", Quantity = 2 },
                new InvoiceModel.InvoiceLine { ItemCode = "item102", Quantity = 6 }
            };
            InvData = oINV; 

            List<InvoiceModel.BatchRow> oBatch = new List<InvoiceModel.BatchRow>()
            {
                new InvoiceModel.BatchRow { ItemCode = "item101",BatchNumber = "BT5001", BatchQty = 2 },
                new InvoiceModel.BatchRow { ItemCode = "item102",BatchNumber = "BT6001", BatchQty = 1 },
                new InvoiceModel.BatchRow { ItemCode = "item102",BatchNumber = "BT6002", BatchQty = 5 }
            };
            BatchData = oBatch; 
        }

        private void btn_nestedList_Click(object sender, EventArgs e)
        {
            getData();

            #region แบบที่ 1
            foreach (var inv in InvData)
            {
                var batchItems = BatchData.Where(b => b.ItemCode == inv.ItemCode).ToList(); //querying batch items for the current invoice line 
                foreach (var batch in batchItems)
                {
                    Console.WriteLine($"  Batch Number: {batch.BatchNumber}, Batch Qty: {batch.BatchQty}");
                }                
                inv.BatchItem = batchItems; // Assigning the batch items to the invoice line    
            }
            var invHead = new InvoiceModel.InvoiceHead
            {
                DocEntry = 1,
                DocNum = "INV001",
                DocDate = DateTime.Now,
                DocumentLines = InvData
            };
            #endregion


            #region แบบที่ 2  
            var InvLine = new List<InvoiceModel.InvoiceLine>();
            foreach (var inv in InvData)
            {
                var batchItems = BatchData.Where(b => b.ItemCode == inv.ItemCode).ToList(); //querying batch items for the current invoice line 
                var invoiceLine = new InvoiceModel.InvoiceLine
                {
                    ItemCode = inv.ItemCode,
                    Quantity = inv.Quantity,
                    BatchItem = batchItems // Assigning the batch items to the invoice line
                };
                InvLine.Add(invoiceLine); // Adding the invoice line to the list
            }

            var invHead2 = new InvoiceModel.InvoiceHead
            {
                DocEntry = 1,
                DocNum = "INV001",
                DocDate = DateTime.Now,
                DocumentLines = InvLine
            };
            #endregion

        }

    }
}
