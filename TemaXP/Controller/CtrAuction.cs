using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller
{
    public class CtrAuction
    {

        public Auction CreateAuction(DateTime date, string description, List<Art> arts) {

            Auction auction = new Auction()
            {
                Date = date,
                Description = description,
                Arts = arts
            };
            using (AuctionDBContext db = new AuctionDBContext()) {

                foreach (var art in arts) {
                    db.Arts.Attach(art);
                }

                db.Auktions.Add(auction);
                db.DebugDetectChanges();
                db.SaveChanges();
            }
            return auction;
        }

        public void DeleteAuction(Auction auction) {

            if (auction == null)
                throw new NullReferenceException("auction");

            using (AuctionDBContext db = new AuctionDBContext()) {
                
                db.Auktions.Attach(auction);
                db.Entry(auction).State = EntityState.Deleted;
                db.Auktions.Remove(auction);
                db.SaveChanges();
            }   
        }

    }
}
