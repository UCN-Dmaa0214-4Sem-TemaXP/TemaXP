using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Verified = 1,
            BidConfirmed = 2,
            BidError = 3,
            Withdrawn = 4
        }

        public MemberBidState CheckEligibleBid(Member m, decimal bid)
        {
            MemberBidState bidState = MemberBidState.NotEnough;

            if (m.Point < bid)
            {
                if ((m.Point * 3) >= bid)
                {
                    bidState = MemberBidState.Verified;
                }
                else
                {
                    bidState = MemberBidState.NotEnough;
                }
            }
            else
            {
                if (m.Point >= bid)
                {
                    bidState = MemberBidState.Verified;
                }
                else
                {
                    bidState = MemberBidState.NotEnough;
                }
            }

            return bidState;
        }

        public decimal WithdrawAmount(int mID, decimal bid)
        {
            decimal owe = 0;

            using (AuctionDBContext db = new AuctionDBContext())
            {
                Member m = RetrieveSingleByID(mID);

                owe = Convert.ToDecimal(m.Point) - bid;

                if ((m.Point - bid) < 0)
                {
                    m.Point = 0;
                }
                else
                {
                    m.Point = m.Point - Convert.ToInt32(bid);
                }

                try
                {
                    db.Members.Attach(m);
                    var entry = db.Entry(m);
                    entry.State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return owe;
        }
    }
}
