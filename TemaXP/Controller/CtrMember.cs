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

        public enum MemberBidState
        {
            NotEnough = 0,
            Verified = 1
        }

        //public MemberBidState CheckEligibleBid(Member m, int bid)
        //{
        //    MemberBidState bidState;

        //    if (m.Points < bid)
        //    {
        //        bidState = MemberBidState.NotEnough;
        //    }
        //    else (m.Points > bid)
        //    {
        //        bidState = MemberBidState.Verified;
        //    }

        //    if (m.Points > (bid * 3))
        //    {
        //        bidState = MemberBidState.NotEnough;
        //    }
        //    else
        //    {
        //        bidState = MemberBidState.Verified;
        //    }

        //    return bidState;
        //}
    }
}
