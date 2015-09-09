using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller
{
    public class CtrArt
    {
        public Art Insert(string name, string artist, string description, string image, decimal startingbid, decimal purchaseprice)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = new Art();
                Random r = new Random();
                aTemp.DateCreated = DateTime.Now;
                aTemp.Name = name;
                aTemp.Artist = artist;
                aTemp.Number = SetArtNumber();
                aTemp.Description = description;
                aTemp.Image = image;
                aTemp.StartingBid = startingbid;
                aTemp.PurchasePrice = purchaseprice;
                aTemp.Bids = null;

                try
                {
                    db.Arts.Add(aTemp);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }

                return aTemp;
            }
        }

        public Art Update(int id, string name, int no, string artist, string description, string image, decimal startingbid, decimal purchaseprice)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = RetrieveById(id);
                aTemp.Name = name;
                aTemp.Artist = artist;
                aTemp.Number = no;
                aTemp.Description = description;
                aTemp.Image = image;
                aTemp.StartingBid = startingbid;
                aTemp.PurchasePrice = purchaseprice;
                aTemp.Bids = null;

                try
                {
                    db.Arts.Attach(aTemp);
                    var entry = db.Entry(aTemp);
                    entry.State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }

                return RetrieveById(id);
            }
        }

        public Art UpdateToAuction(int id, Auction au)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = db.Arts.SingleOrDefault(x => x.Id == id);

                aTemp.Auction = au;

                try
                {
                    db.Arts.Attach(aTemp);
                    var entry = db.Entry(aTemp);
                    entry.State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }

                return RetrieveById(id);
            }
        }

        public Art RetrieveById(int id)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = null;
                try
                {
                    aTemp = db.Arts.Single(x => x.Id == id);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return aTemp;
            }
        }

        public Art RetrieveByNo(int no)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = null;
                try
                {
                    aTemp = db.Arts.Single(x => x.Number == no);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return aTemp;
            }
        }

        public List<Art> RetrieveAll()
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try
                {
                    return db.Arts.ToList();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public List<Art> RetrieveAll(int auID)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try
                {
                    return db.Arts.Where(x => x.AuctionId == auID).ToList();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void DeleteArt(Art art)
        {
            if (art == null)
                throw new ArgumentNullException("art");
            using (AuctionDBContext db = new AuctionDBContext())
            {
                var dbArt = db.Arts.Single(x => x.Id == art.Id);

                //db.Arts.Attach(art);
                //db.Entry(art).State = EntityState.Deleted;
                db.Arts.Remove(dbArt);
                db.DebugDetectChanges();
                db.SaveChanges();
            }
        }

        private int SetArtNumber()
        {
            int? currentNumber;
            int newNumber;
            using (AuctionDBContext db = new AuctionDBContext())
            {

                currentNumber = db.Arts.Max(x => (int?)x.Number);
                if (currentNumber == null)
                {
                    newNumber = 1000;
                }
                else
                {
                    newNumber = Convert.ToInt32(currentNumber) + 10;
                }

                return newNumber;
            }
        }
    }
}
