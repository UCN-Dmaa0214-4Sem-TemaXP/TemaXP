using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.Controller;
using TemaXP.Model;

namespace TemaXP_Test
{
    [TestClass]
    public class CtrMemberUnitTest
    {
        CtrMember ctrMem;
        [TestInitialize]
        public void CtrMemberTestInitialize()
        {
            Console.Out.WriteLine("CtrMemberTestInitialize called");
            ctrMem = new CtrMember();
        }

        [TestCleanup]
        public void CtrMemberTestCleanup()
        {
            Console.Out.WriteLine("CtrMemberTestCleanup called");
            ctrMem = null;
        }

        [TestMethod]
        public void TestMemberRetrieveSingleByID()
        {
            Console.Out.WriteLine("TestMemberRetrieveSingleByID called");

            Member mTemp = ctrMem.RetrieveSingleByID(1);

            Assert.IsNotNull(mTemp, "Is not null");
        }

        [TestMethod]
        public void TestMemberEligibleBid()
        {
            Console.Out.WriteLine("TestMemberEligibleBid called");

            Member mTemp = ctrMem.RetrieveSingleByID(1);

            CtrMember.MemberBidState bidState = ctrMem.CheckEligibleBid(mTemp, 9001);

            Console.Out.WriteLine(bidState);
        }
    }
}
