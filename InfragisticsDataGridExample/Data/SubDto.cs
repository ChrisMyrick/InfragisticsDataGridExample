using System;

namespace InfragisticsDataGridExample.Data
{
    public class SubDto
    {
        public int AccountAdjustmentAddressId { get; set; }

        public int AccountAdjustmentId { get; set; }

        public bool? CurrentChk { get; set; }

        public string VendorNo { get; set; }

        public string VendorName { get; set; }

        public string AddressID { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public string ZipCode { get; set; }

        public string AccountNo { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
