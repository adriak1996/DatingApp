using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatingApp.API.Data
{

    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}