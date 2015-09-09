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

namespace TemaXP.Controller
{
    public class CtrAuction
    {

        public Auction CreateAuction(DateTime date, string description, List<Art> arts)
        {

            Auction auction = new Auction()
            {
                Date = date,
                Description = description,
                Arts = arts
            };
            using (AuctionDBContext db = new AuctionDBContext())
            {
                //db.Arts.Load();

                foreach (var art in arts)
                {
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

        public void DeleteAuction(Auction auction)
        {

            if (auction == null)
                throw new NullReferenceException("auction");

            using (AuctionDBContext db = new AuctionDBContext())
            {

                db.Auktions.Attach(auction);
                db.Entry(auction).State = EntityState.Deleted;
                db.Auktions.Remove(auction);
                db.SaveChanges();
            }
        }

        public Auction UpdateAuction(Auction auction)
        {

            if (auction == null)
                throw new NullReferenceException("auction");
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try
                {
                    var artsInDb = db.Arts.Where(x => x.AuctionId == auction.Id).ToList();
                    foreach (var art in artsInDb)
                    {
                        art.AuctionId = null;
                        db.Entry(art).State = EntityState.Modified;
                    }

                    var artsInDbIds = artsInDb.Select(x => x.Id);

                    foreach (var art in auction.Arts)
                    {
                        art.AuctionId = auction.Id;
                        if (!artsInDbIds.Contains(art.Id))
                        {
                            db.Entry(art).State = EntityState.Modified;
                        }
                        else
                        {
                            var tempObj = db.ChangeTracker.Entries<Art>().Single(x => x.Entity.Id == art.Id);
                            tempObj.Entity.AuctionId = auction.Id;
                        }
                    }

                    var artsList = auction.Arts;
                    auction.Arts = null;

                    db.Entry(auction).State = EntityState.Modified;

                    db.DebugDetectChanges();
                    db.SaveChanges();
                    auction.Arts = artsList;
                }
                catch (UpdateException)
                {

                }
            }
            return auction;
        }

        public Auction RetriveById(int id)
        {
            Auction auction = null;
            using (AuctionDBContext db = new AuctionDBContext())
            {
                auction = db.Auktions.Include(x => x.Arts).Single(x => x.Id == id);
            }
            return auction;
        }

        public List<Bid> RetrieveBidsByArt(Art a)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try
                {
                    return db.Bids.Where(x => x.Art.Id == a.Id).ToList();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
