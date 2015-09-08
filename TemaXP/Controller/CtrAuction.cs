using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller {
    public class CtrAuction {

        public Auction CreateAuction(DateTime date, string description, List<Art> arts) {

            Auction auction = new Auction() {
                Date = date,
                Description = description,
                Arts = arts
            };
            using (AuctionDBContext db = new AuctionDBContext()) {
                //db.Arts.Load();

                foreach (var art in arts) {
                    db.Arts.Attach(art);
                    db.Entry(art).Entity.Auction = auction;
                    db.Entry(art).State = EntityState.Modified;
                    //
                    //db.Entry(art).State = EntityState.Modified;;
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
            using (AuctionDBContext db = new AuctionDBContext()) {
                try {
                    var artsInDb = db.Arts.Where(x => x.AuctionId == auction.Id).ToList();

                    foreach (var artId in auction.Arts.Select(x => x.Id)) {
                        var tempObj = artsInDb.SingleOrDefault(x => x.Id == artId);
                        if (tempObj != null) {
                            artsInDb.Remove(tempObj);
                        }
                    }

                    foreach (var art in artsInDb) {
                        db.Entry(art).Entity.AuctionId = null;
                        db.Entry(art).State = EntityState.Modified;
                    }

                    foreach (var art in auction.Arts) {
                        //art.AuctionId = auction.Id;
                        //db.Arts.Attach(art);
                        //db.Entry(art).State = EntityState.Modified;
                    }
                    //db.Auktions.Attach(auction);

                    //db.Entry(auction).State = EntityState.Modified;
                    foreach (var art in auction.Arts) {
                        //db.Entry(art).State = EntityState.Modified;
                    }
                    foreach (var art in db.ChangeTracker.Entries<Art>()) {
                        art.Entity.AuctionId = auction.Id;
                        art.State = EntityState.Modified;
                    }


                    db.DebugDetectChanges();
                    db.SaveChanges();
                } catch (UpdateException) {

                }
            }
            return auction;
        }

        public Auction RetriveById(int id) {
            Auction auction = null;
            using (AuctionDBContext db = new AuctionDBContext()) {
                auction = db.Auktions.Include(x => x.Arts).Single(x => x.Id == id);
            }
            return auction;
        }

    }
}
