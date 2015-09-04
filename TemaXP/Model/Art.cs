using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.Model
{
    public class Art
    {
       
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal StartingBid { get; set; }
        public decimal PurchasePrice { get; set; }
        public virtual List<Bid> Bids { get; set; } 


    }
}
