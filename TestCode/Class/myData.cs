using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Class
{
    public class myData
    {
        public class GetInvoice
        {
            public string InvoiceID { get; set; }
            public string InvoiceNumber { get; set; }
            public decimal InvoiceAmount { get; set; }
            public List<InvoiceRow> Rows { get; set; }
        }

        public class InvoiceRow
        {
            public decimal RowQty { get; set; }
            public string RowCode { get; set; }
            public string RowDescription { get; set; }
        }

        public class BarcodeRow
        {
            public int BarcodeID { get; set; }
            public string BarcodeNumber { get; set; }
            public string BarcodeDescription { get; set; }
            public int BarQty { get; set; }
        }   
 
    }
}
