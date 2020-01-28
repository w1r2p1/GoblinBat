﻿using System;
using System.Data.Entity;
using ShareInvest.Models;

namespace ShareInvest.GoblinBatContext
{
    public class GoblinBatDbContext : DbContext
    {
        public GoblinBatDbContext() : base(new Secret().ConnectionString)
        {

        }
        public GoblinBatDbContext(float secondary) : base(new Secret().ConnectionDenney)
        {
            Console.Write(secondary);
        }
        public GoblinBatDbContext(int secondary) : base(new Secret().ConnectionShare)
        {
            Console.Write(secondary);
        }
        public GoblinBatDbContext(bool secondary) : base(new Secret().ConnectionDenneyString)
        {
            Console.Write(secondary);
        }
        public GoblinBatDbContext(string secondary) : base(new Secret().ConnectionExternalDenney)
        {
            Console.Write(secondary);
        }
        public GoblinBatDbContext(char secondary) : base(new Secret().ConnectionExternalShareInvest)
        {
            Console.Write(secondary);
        }
        public override int SaveChanges()
        {
            return this.BatchSaveChanges();
        }
        public DbSet<Codes> Codes
        {
            get; set;
        }
        public DbSet<Futures> Futures
        {
            get; set;
        }
        public DbSet<Options> Options
        {
            get; set;
        }
        public DbSet<Stocks> Stocks
        {
            get; set;
        }
        public DbSet<Days> Days
        {
            get; set;
        }
        public DbSet<Logs> Logs
        {
            get; set;
        }
    }
}