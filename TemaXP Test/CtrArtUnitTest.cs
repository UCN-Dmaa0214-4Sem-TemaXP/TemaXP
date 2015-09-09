using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.Controller;
using TemaXP.Model;

namespace TemaXP_Test
{
    /// <summary>
    /// Summary description for CtrArtUnitTest
    /// </summary>
    [TestClass]
    public class CtrArtUnitTest
    {
        CtrArt ctrArt;
        [TestInitialize]
        public void CtrArtTestInitialize()
        {
            Console.Out.WriteLine("CtrArtTestInitialize called");
            ctrArt = new CtrArt();
        }

        [TestCleanup]
        public void CtrArtTestCleanup()
        {
            Console.Out.WriteLine("CtrArtTestCleanup called");
            ctrArt = null;
        }

        [TestMethod]
        public void TestInsertArt()
        {
            Console.Out.WriteLine("TestCreateArt called");
            Art aTemp = ctrArt.Insert("Hej123", "Dav", "Fin kunst", "asdasads", 450, 450);
            Assert.IsNotNull(aTemp, "Is not null");

            Assert.IsNotNull(aTemp.DateCreated, "Date is set");
            Assert.IsTrue(0 < aTemp.Name.Length, "Name is set");
            Assert.IsTrue(0 < aTemp.Artist.Length, "Artist is set");
            Assert.IsTrue(0 < aTemp.Description.Length, "Description is set");
            Assert.IsNotNull(aTemp.Image, "Image is not null");
            Assert.IsTrue(0 < aTemp.StartingBid, "Starting bid is set");
            Assert.IsTrue(0 < aTemp.PurchasePrice, "Purchaseprice is set");
            Assert.IsNull(aTemp.Bids, "Bids is null");
            ctrArt.DeleteArt(aTemp);
        }

        [TestMethod]
        public void TestRetriveByIdArt()
        {
            Art aTemp = ctrArt.RetrieveById(27);
            Assert.AreEqual(1020, aTemp.Number);
            Assert.IsNotNull(aTemp, "is found");
        }

        [TestMethod]
        public void TestRetrieveByNoArt()
        {
            Console.WriteLine("TestRetrieveByNo Called");
            Art aTemp = ctrArt.RetrieveByNo(1020);
            Assert.AreEqual(1020, aTemp.Number);
            Assert.IsNotNull(aTemp, "is found");
        }

        [TestMethod]
        public void TestRetrieveAllArt()
        {
            Console.WriteLine("TestRetrieveAll called");
            List<Art> aCollection = ctrArt.RetrieveAll();

            Assert.IsNotNull(aCollection, "aCollection is null");

            Console.WriteLine(aCollection.Count);
        }

        [TestMethod]
        public void TestUpdateArt()
        {
            Console.WriteLine("TestUpdateArt called");
            Art aTemp = ctrArt.RetrieveByNo(1020);

            Assert.IsNotNull(aTemp, "aTemp is found");

            aTemp.Number = 1200;

            aTemp = ctrArt.Update(aTemp.Id, aTemp.Name, aTemp.Number, aTemp.Artist, aTemp.Description, aTemp.Image, aTemp.StartingBid, aTemp.PurchasePrice);

            Assert.AreEqual(aTemp.Number, 1200, "Number is not equal");

            aTemp = ctrArt.Update(aTemp.Id, aTemp.Name, 1020, aTemp.Artist, aTemp.Description, aTemp.Image, aTemp.StartingBid, aTemp.PurchasePrice);
        }

        [TestMethod]
        public void TestDeleteArt()
        {
            Console.WriteLine("TestDeleteArt called");

            Art aTemp = ctrArt.RetrieveByNo(1020);
            Art aInsertAgain = aTemp;

            Assert.IsNotNull(aTemp, "Art is found");

            ctrArt.DeleteArt(aTemp);

            aInsertAgain = ctrArt.Insert(aInsertAgain.Name, aInsertAgain.Artist, aInsertAgain.Description, aInsertAgain.Image, aInsertAgain.StartingBid, aInsertAgain.PurchasePrice);
            aInsertAgain = ctrArt.RetrieveByNo(aInsertAgain.Number);

            aInsertAgain = ctrArt.Update(aInsertAgain.Id, aInsertAgain.Name, 1020, aInsertAgain.Artist, aInsertAgain.Description, aInsertAgain.Image, aInsertAgain.StartingBid, aInsertAgain.PurchasePrice);
        }

        [TestMethod]
        public void TestUpdateAuctionArt()
        {
            Console.WriteLine("TestUpdateAuctionArt called");

            Auction au = new CtrAuction().RetriveById(22);

            Assert.IsNotNull(au, "is found");

            Art aTemp = ctrArt.RetrieveByNo(1020);

            aTemp = ctrArt.UpdateToAuction(aTemp.Id, au);

            Assert.IsNotNull(aTemp.Auction, "Auction is set");
        }
    }
}
