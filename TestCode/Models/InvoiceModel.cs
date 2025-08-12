using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Models
{
    public class InvoiceModel
    {
        public class InvoiceHead
        {
            public int DocEntry { get; set; }
            public string DocNum { get; set; }
            public DateTime DocDate { get; set; }
            public List<InvoiceLine> DocumentLines { get; set; }
        }

        public class InvoiceLine
        {
            public int DocEntry { get; set; }
            public string ItemCode { get; set; }
            public double Quantity { get; set; }
            public List<BatchRow> BatchItem { get; set; }
        }

        public class BatchRow
        {
            public string ItemCode { get; set; }
            public string BatchNumber { get; set; }
            public double BatchQty { get; set; }
        }   

    }
}
