using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.Controller;
using TemaXP.Model;

namespace TemaXP_Test
{
    [TestClass]
    public class CtrAuktionTest
    {

        private CtrAuction ctrAuction;
        private CtrArt artCtr;

        [TestInitialize]
        public void CtrArtTestInitialize()
        {
            Console.Out.WriteLine("CtrArtTestInitialize called");
            ctrAuction = new CtrAuction();
            artCtr = new CtrArt();

        }

        [TestCleanup]
        public void CtrArtTestCleanup()
        {
            Console.Out.WriteLine("CtrArtTestCleanup called");
            ctrAuction = null;
            artCtr = null;
        }

        [TestMethod]
        public void TestCreateAndInsertAuction()
        {

            Art art = artCtr.RetrieveById(27);
            List<Art> artList = new List<Art>();
            artList.Add(art);

            Auction auction = ctrAuction.CreateAuction(DateTime.Now, "Test description", artList);

            Assert.IsNotNull(auction.Date, "Date created");
            Assert.IsTrue(0 < auction.Description.Length, "Description is set");
            Assert.IsNotNull(auction.Arts, "Art list is set");
            ctrAuction.DeleteAuction(auction);
        }

        [TestMethod]
        public void TestUpdateAuction()
        {

            Auction auction = ctrAuction.RetriveById(27);

            Assert.IsNotNull(auction, "Auction is null");

            auction.Description = "Update test description";
            auction.Date = DateTime.Now;
            var art = artCtr.Insert("Papir", "UCN", "Et fint papir", "", 10, 10);

            auction.Arts.Add(art);

            //var art2 = auction.Arts.Single(x => x.Id == 81);

            //auction.Arts.Remove(art2);


            ctrAuction.UpdateAuction(auction);
            //artCtr.DeleteArt(art);
        }

        [TestMethod]
        public void TestRetriveById()
        {

            Auction auction = ctrAuction.RetriveById(1);
            Assert.IsNotNull(auction, "auction is found");
        }

        [TestMethod]
        public void TestRetrieveBidsByArt()
        {
            Console.Out.WriteLine("TestRetrieveBidsByArt called");

            CtrArt ctrArt = new CtrArt();
            Art a = ctrArt.RetrieveByNo(1020);
            List<Bid> bCollection = ctrAuction.RetrieveBidsByArt(a);

            Assert.IsNotNull(bCollection);

            foreach (var item in bCollection)
            {
                Console.Out.WriteLine();
                Console.Out.Write("Art Name {0}, Member Name {1}", item.Art.Name, item.Member.FirstName);
                Console.Out.WriteLine();
            }
        }

        [TestMethod]
        public void TestInsertBid()
        {
            CtrMember ctrMem = new CtrMember();
            CtrArt ctrArt = new CtrArt();


            Art a = ctrArt.RetrieveByNo(1410);
            Member m = ctrMem.RetrieveSingleByID(1);

            CtrMember.MemberBidState state = ctrAuction.InsertBid(m.Id, 9000, a.Id);

            if (state == CtrMember.MemberBidState.BidConfirmed)
            {
                Console.WriteLine(ctrMem.WithdrawAmount(m.Id, 9000));
            }

            Console.WriteLine(state);
        }
    }
}
