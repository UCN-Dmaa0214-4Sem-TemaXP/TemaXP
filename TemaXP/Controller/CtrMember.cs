using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.Model;

namespace TemaXP.Controller
{
    public class CtrMember
    {
        public Member RetrieveSingleByID(int id)
        {
            using (AuctionDBContext db = new AuctionDBContext())
            {
                try
                {
                    return db.Members.SingleOrDefault(x => x.Id == id);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
