namespace AlphaRangers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SiteContext : DbContext
    {
        public SiteContext()
            : base("name=SiteContext")
        {
        }

        public virtual DbSet<Baja> Baja { get; set; }
        
    }
}
