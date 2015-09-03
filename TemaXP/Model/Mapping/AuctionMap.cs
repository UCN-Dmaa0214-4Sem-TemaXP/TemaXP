using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemaXP.Model.Mapping
{
    public class AuctionMap : EntityTypeConfiguration<Auction> {

        public AuctionMap() {

            this.HasKey(x => x.Id);
            this.Property(x => x.Description).HasMaxLength(300);
            this.HasMany(x => x.Arts);
        }
    }
}
