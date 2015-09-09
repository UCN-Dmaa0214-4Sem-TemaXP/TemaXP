using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.Model
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual List<Art> Arts { get; set; }

        public bool IsDone { get; set; }

        public void AddArt(Art art) {
            if (art == null)
                throw new ArgumentNullException("art");
            Arts.Add(art);         
        }

        public override string ToString() {
            return Date.ToString();
        }

    }
}
