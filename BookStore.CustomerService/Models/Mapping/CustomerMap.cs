﻿/**
 * Copyright (C) 2018 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/k4m4r82/demo-ocelot-microservice
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.CustomerService.Models.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.ToTable("customer");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedNever();

            entity.Property(e => e.Address).HasColumnName("address");

            entity.Property(e => e.City).HasColumnName("city");

            entity.Property(e => e.Name).HasColumnName("name");

            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
        }
    }
}
