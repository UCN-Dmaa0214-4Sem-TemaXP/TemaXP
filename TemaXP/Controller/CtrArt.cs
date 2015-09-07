using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller
{
    public class CtrArt
    {
        public Art CreateAndInsert(string name, string artist, string description, string image, decimal startingbid, decimal purchaseprice)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                Art aTemp = new Art();
                Random r = new Random();
                aTemp.DateCreated = DateTime.Now;
                aTemp.Name = name;
                aTemp.Artist = artist;
                aTemp.Number = r.Next(1, 450);
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
                    db.SaveChanges();
                }
                catch(Exception e)
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
            return null;
        }

        public void DeleteArt(Art art) {
            
            if(art == null)
                throw new ArgumentNullException("art");
            using (AuctionDBContext db = new AuctionDBContext()) {
                db.Arts.Remove(art);
                db.SaveChanges();
            }
        }
    }
}
