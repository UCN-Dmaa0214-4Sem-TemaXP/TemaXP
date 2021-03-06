﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
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
            this.Property(x => x.Image).HasMaxLength(500);
            this.HasMany(x => x.Bids);
            this.Property(x => x.Number).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("Number"){ IsUnique = true}));

        }
    }
}
