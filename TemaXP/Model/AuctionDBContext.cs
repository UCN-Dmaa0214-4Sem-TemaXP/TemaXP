using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
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

        #region Debug methods
        public void DebugSaveChanges() {
            try {
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                SaveChanges();
            } catch (DbEntityValidationException e) {
                foreach (var eve in e.EntityValidationErrors) {
                    Debug.WriteLine(String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors) {
                        Debug.WriteLine(String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                throw;
            }
        }

        public void DebugDetectChanges() {
            ChangeTracker.DetectChanges();
            var list = ChangeTracker.Entries().ToList();
            Debug.WriteLine("Start of DetectChanges");
            foreach (var v in list) {
                Debug.WriteLine("c: #" + list.IndexOf(v) + " - " + v.Entity + " state: " + v.State);
            }
            Debug.WriteLine("End of DetectChanges");

        }


        public void DebugLog() {
            Database.Log = m => Debug.WriteLine(m);
        }
        #endregion
    }
}
