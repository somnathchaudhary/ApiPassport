using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PasportDetails.Models
{
    public class PDetailsContex:DbContext
    {
        public PDetailsContex([NotNullAttribute] DbContextOptions options) : base(options)
        { }

        public DbSet<PDetails> PDetails { get; set; }
    }
}
