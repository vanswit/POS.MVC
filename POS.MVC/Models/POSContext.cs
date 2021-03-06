﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POS.BL;
using System.Collections;
using System.Linq.Expressions;

namespace POS.MVC
{
    public class POSContext : DbContext, IDisposable
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseLine> PurchaseLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
