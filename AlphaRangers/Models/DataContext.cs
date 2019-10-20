using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AlphaRangers.Models;

namespace AlphaRangers.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DataContext")
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}