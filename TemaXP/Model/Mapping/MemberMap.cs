using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.Model.Mapping
{
    public class MemberMap : EntityTypeConfiguration<Member> {
        
        public MemberMap() {
            this.HasKey(x => x.Id);
            this.Property(x => x.Address).HasMaxLength(300);
            this.Property(x => x.Department).HasMaxLength(100);
            this.Property(x => x.Email).HasMaxLength(100);
            this.Property(x => x.City).HasMaxLength(100);
            this.Property(x => x.Phone).HasMaxLength(100);
            this.Property(x => x.Postal).HasMaxLength(100);


        }

    }
}
