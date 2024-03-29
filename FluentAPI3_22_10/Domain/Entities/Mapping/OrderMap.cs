﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI3_22_10.Domain.Entities.Mapping
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(o => o.Id);
            this.ToTable("Orders");

            this.Property(o => o.Id).HasColumnName("Id");
            this.Property(o => o.CustomerId).HasColumnName("CustomerId");
            this.Property(o => o.OrderDate).HasColumnName("OrderDate");
            this.Property(o => o.ImagePath).HasColumnName("ImagePath");

        }
    }
}
