using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemaXP.Model.Mapping
{
    public class ArtMap : EntityTypeConfiguration<Art> {

        public ArtMap() {

            this.HasKey(x => x.Id);
            this.Property(x => x.Description).HasMaxLength(300);
            this.Property(x => x.Artist).HasMaxLength(200);
            this.Property(x => x.Name).HasMaxLength(200);
            this.Property(x => x.Image).HasMaxLength(100);
            this.HasMany(x => x.Bids);

        }
    }
}
