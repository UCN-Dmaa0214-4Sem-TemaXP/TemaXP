using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller
{
    public class CtrArt
    {
        public Art Create(string name, string artist, string description, string image, decimal startingbid, decimal purchaseprice) {
            Art aTemp = new Art();
            Random r = new Random();
            aTemp.Id = r.Next(1, 450);
            aTemp.DateCreated = DateTime.Now;
            aTemp.Name = name;
            aTemp.Artist = artist;
            //aTemp.Number = number;
            aTemp.Description = description;
            aTemp.Image = image;
            aTemp.StartingBid = startingbid;
            aTemp.PurchasePrice = purchaseprice;
            aTemp.Bids = null;

            return aTemp;
        }
    }
}
