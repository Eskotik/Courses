//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagmentSystem.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_payment
    {
        [Display(Name ="PaymentId")]
        public int payment_id { get; set; }
        [Display(Name = "BookingId")]
        public byte booking_id { get; set; }
        [Display(Name = "PaymentTypeId")]
        public int payment_type_id { get; set; }
        [Display(Name = "PaymentAmount")]
        public decimal payment_amount { get; set; }
        [Display(Name = "IsActive")]
        public Nullable<bool> Is_Active { get; set; }
        [Display(Name = "PaymentType")]
        public virtual tbl_payment_type tbl_payment_type { get; set; }
    }
}
