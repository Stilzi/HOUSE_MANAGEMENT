//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace house_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        public int IdApartment { get; set; }
        public int HouseId { get; set; }
        public int QuantityLodgers { get; set; }
        public int Square { get; set; }
        public int PaymentId { get; set; }
    
        public virtual House House { get; set; }
        public virtual Payment Payment { get; set; }
    }
}