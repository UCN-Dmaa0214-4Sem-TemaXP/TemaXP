using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP.Model
{
    public class Bid
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Member Member { get; set; }
        public decimal BidAmount { get; set; }
        public Art Art { get; set; }
    }
}
