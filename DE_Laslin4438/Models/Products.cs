//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DE_Laslin4438.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int id { get; set; }
        public string product_name { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set; }
        public int cost { get; set; }
        public Nullable<int> sale { get; set; }
        public byte[] picture { get; set; }
        public string article { get; set; }
        public int current_count { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> max_sale { get; set; }
        public string deliverer { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
