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

        public void CreateAuction(Auction auction) {

            if (auction == null)
                throw new NullReferenceException("auction");

            using (AuctionDBContext db = new AuctionDBContext()) {

                db.Auktions.Add(auction);
                db.DebugDetectChanges();
                db.SaveChanges();
            }   
           
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
