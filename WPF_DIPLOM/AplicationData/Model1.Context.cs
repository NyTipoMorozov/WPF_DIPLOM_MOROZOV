﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class diplomEntities : DbContext
    {
        private static diplomEntities _context;
        public diplomEntities()
            : base("name=diplomEntities")
        {

        }
        public static diplomEntities GetContext()
        {
            if (_context == null)
                _context = new diplomEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
