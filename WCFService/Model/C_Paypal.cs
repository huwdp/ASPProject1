namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Paypal")]
    public partial class C_Paypal
    {
        public C_Paypal()
        {
            C_Payment = new HashSet<C_Payment>();
        }

        public int id { get; set; }

        public virtual ICollection<C_Payment> C_Payment { get; set; }
    }
}
