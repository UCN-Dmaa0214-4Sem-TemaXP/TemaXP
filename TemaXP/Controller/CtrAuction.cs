﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Linq;
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
                    //var dbAuction = db.Auktions.Include(x => x.Arts).Single(x => x.Id == auction.Id);
                    foreach (var art in auction.Arts) {
                        art.AuctionId = auction.Id;
                    }
                    db.Auktions.Attach(auction);


                    db.Entry(auction).State = EntityState.Modified;
                    
                    foreach (var art in auction.Arts) {
                        db.Arts.Attach(art);
                        db.Entry(art).Entity.Auction = db.Entry(auction).Entity;
                        db.Entry(art).State = EntityState.Modified;
                    }


                    db.Auktions.AddOrUpdate();
                    db.Arts.AddOrUpdate();
                    
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
