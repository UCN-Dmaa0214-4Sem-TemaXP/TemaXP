using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Auction UpdateAuction(Auction auction) {

            if (auction == null)
                throw new NullReferenceException("auction");
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try {
                    db.Entry(auction).State = EntityState.Modified;
                    db.Entry(auction.Arts).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (UpdateException)
                {
                    
                }         
            }
            return auction;
        }

        public Auction RetriveById(int id) {
            Auction auction = null;
            using (AuctionDBContext db = new AuctionDBContext()) {
                
            }
            return auction;
        }

    }
}
