using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaXP.Controller;
using TemaXP.GUI;
using TemaXP.GUI.Extensions;
using TemaXP.Model;

namespace TemaXP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            ///Uncomment to start auctionform
            //Auction au = new CtrAuction().RetriveById(27);
            //Application.Run(new AuctionForm(au));

            //using (AuctionDBContext db = new AuctionDBContext())
            //{
            //    db.Members.Add(new Member()
            //    {
            //        FirstName = "John",
            //        LastName = "Doe",
            //        Address = "Hobrovej 12",
            //        Department = "HR",
            //        Postal = "9000",
            //        Phone = "121212",
            //        Email = "john@d.dk"
            //    });
            //    db.SaveChanges();
        }
    }

}
