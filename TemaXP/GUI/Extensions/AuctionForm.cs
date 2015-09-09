using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaXP.Controller;
using TemaXP.Model;

namespace TemaXP.GUI.Extensions
{
    public partial class AuctionForm : Form
    {
        private Auction currentAuction;
        private CtrArt ctrArt;

        public AuctionForm(Auction au)
        {
            InitializeComponent();

            lblHeader.Text = "Auction nr " + au.Id;

            currentAuction = au;

            ctrArt = new CtrArt();

            dgvArts.DataSource = ctrArt.RetrieveAll(au.Id);
        }

        private void dgvArts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedArt = (Art)dgvArts.CurrentRow.DataBoundItem;

            lblArtID.Text = selectedArt.Id.ToString();
        }

        private void populatedgvbids()
        {

        }
    }
}
