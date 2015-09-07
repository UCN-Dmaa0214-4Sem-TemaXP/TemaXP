﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.Controller;
using TemaXP.Model;

namespace TemaXP_Test
{
    [TestClass]
    public class CtrAuktionTest {

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
        public void TestCreateAndInsertAuction() {

            Art art = artCtr.RetrieveById(1);
            List<Art> artList = new List<Art>();
            artList.Add(art);
          
            Auction auction = ctrAuction.CreateAuction(DateTime.Now, "Test description", artList );

            Assert.IsNotNull(auction.Date, "Date created");
            Assert.IsTrue(0 < auction.Description.Length, "Description is set");
            Assert.IsNotNull(auction.Arts, "Art list is set");
           // ctrAuction.DeleteAuction(auction);
        }

        [TestMethod]
        public void TestUpdateAuction() {

            Auction auction = ctrAuction.RetriveById(1);
            auction.Description = "Update test description";
            auction.Date = new DateTime();
            
            ctrAuction.UpdateAuction(auction);

        }

        [TestMethod]
        public void TestRetriveById() {

            Auction auction = ctrAuction.RetriveById(1);
            Assert.IsNotNull(auction, "auction is found");
        }
    }
}
