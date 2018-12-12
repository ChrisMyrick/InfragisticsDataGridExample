using System;
using System.Collections.Generic;

namespace InfragisticsDataGridExample.Data
{
    public class Dto
    {
        public Dto()
        {
            SubDtos = new List<SubDto>();
        }

        public int PolicyContractID { get; set; }

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

        public string PayeeZipCode { get; set; }

        public DateTime RequestDate { get; set; }

        public string VendorNo { get; set; }

        public string VendorAddressID { get; set; }

        public int? StatusID { get; set; }

        public int? UWStatusID { get; set; }

        public int? UWRequestByID { get; set; }

        public int? UWApprovedByID { get; set; }

        public string Comment { get; set; }

        public string RefundReasonCode { get; set; }

        public int? AccountAdjustmentId { get; set; }

        public string CheckNum { get; set; }

        public DateTime? LastEdited { get; set; }

        public string LastEditedBy { get; set; }

        public string Remark { get; set; }

        public string ApprovedBy { get; set; }

        public IEnumerable<SubDto> SubDtos { get; set; }
    }
}
