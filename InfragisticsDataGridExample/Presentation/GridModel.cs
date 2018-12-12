using System.Collections.Generic;
using InfragisticsDataGridExample.Data;

namespace InfragisticsDataGridExample.Presentation
{
    public class GridModel
    {
        public string AccountName { get; set; }

        public string AccountNo { get; set; }

        public string GroupNo { get; set; }

        public string GroupName { get; set; }

        public string GroupSortName { get; set; }

        public string AccountSortName { get; set; }

        public decimal TotalARBalance { get; set; }

        public decimal RefundAmt { get; set; }

        public string Payee { get; set; }

        public string PayeeAddress1 { get; set; }

        public string PayeeAddress2 { get; set; }

        public string PayeeAddress3 { get; set; }

        public string PayeeCity { get; set; }

        public string PayeeStateCode { get; set; }

        public string VendorNo { get; set; }

        public IEnumerable<SubDto> SubDtos { get; set; }
    }
}
