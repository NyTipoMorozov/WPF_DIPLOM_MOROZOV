//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_DIPLOM.AplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int ClientID { get; set; }
        public int CarID { get; set; }
        public Nullable<int> ItemsID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string Comment { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Items Items { get; set; }
        public virtual Users Users { get; set; }
    }
}
