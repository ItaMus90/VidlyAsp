using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Vidly.Models;

namespace Vidly.EntityFramework
{
    public class CustomerConfiguration:EntityTypeConfiguration<Customer> 
    {
        public CustomerConfiguration()
        {
                 HasKey(c => c.Id);    

                 Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}