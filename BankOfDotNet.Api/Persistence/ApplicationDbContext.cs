using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BankOfDotNet.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BankOfDotNet.Api.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        :base(options){}

        public DbSet<Customer> Customers { get; set; }
    }
}
