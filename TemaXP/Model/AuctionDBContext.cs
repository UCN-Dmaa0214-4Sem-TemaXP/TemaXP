using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model.Mapping;

namespace TemaXP.Model
{
    public class AuctionDBContext : DbContext
    {
        public AuctionDBContext() : base() {
            
        }

        public virtual DbSet<Art> Arts { get; set; }
        public virtual DbSet<Auction> Auktions { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new ArtMap());
            modelBuilder.Configurations.Add(new AuctionMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new BidMap());

         
            base.OnModelCreating(modelBuilder);
        }
    }
}
