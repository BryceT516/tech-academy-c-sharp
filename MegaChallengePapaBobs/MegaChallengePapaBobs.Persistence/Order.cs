//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaChallengePapaBobs.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public System.Guid OrderId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public decimal TotalCost { get; set; }
        public string PaymentType { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Completed { get; set; }
    }
}
