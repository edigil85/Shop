namespace Shoo.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shoo.Web.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class DataContext: DbContext
    {
        public DbSet <Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
