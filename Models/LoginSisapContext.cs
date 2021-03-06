﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace loginSisap.Models
{
    public partial class LoginSisapContext : DbContext
    {
        public LoginSisapContext()
        {
        }

        public LoginSisapContext(DbContextOptions<LoginSisapContext> options)
            : base(options)
        {
        }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
             {
 #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 optionsBuilder.UseSqlServer("Server=10.33.132.71,54058;Database=LoginSisap;Trusted_Connection=True;");
             }
         }
  */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
