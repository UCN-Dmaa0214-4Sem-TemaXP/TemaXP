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
        public void TestCreateAndInsertArt()
        {
            Console.Out.WriteLine("TestCreateArt called");
            Art aTemp = ctrArt.CreateAndInsert("Hej", "Dav", "Fin kunst", "asdasads", 450, 450);
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
        public void TestRetriveById() {

            Art aTemp = ctrArt.RetrieveById(1);
            Assert.AreEqual(1020, aTemp.Number);
            Assert.IsNotNull(aTemp, "is found");

        }

            
        [TestMethod]
        public void TestUpdateArt() {
            Console.WriteLine("TestUpdateArt called");

        }
    }
}
