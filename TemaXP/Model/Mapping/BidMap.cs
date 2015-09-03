using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.Model.Mapping
{
    public class BidMap : EntityTypeConfiguration<Bid> {
       
        public BidMap() {
            this.HasKey(x => x.Id);
        }
    }
}
