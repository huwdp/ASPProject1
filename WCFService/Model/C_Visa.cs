namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Visa")]
    public partial class C_Visa
    {
        public C_Visa()
        {
            C_Payment = new HashSet<C_Payment>();
        }

        public int id { get; set; }

        public int? CardNumber { get; set; }

        public int? CardSecurityCode { get; set; }

        public DateTime? ValidDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public virtual ICollection<C_Payment> C_Payment { get; set; }
    }
}
