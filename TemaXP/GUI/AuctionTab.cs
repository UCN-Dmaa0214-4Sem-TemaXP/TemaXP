using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaXP.Controller;
using TemaXP.GUI.Extensions;
using TemaXP.Model;

namespace TemaXP.GUI {
    public partial class AuctionTab : UserControl {

        private Auction auction;
      

        public AuctionTab() {
            InitializeComponent();
            getArtData();
            getUpcomingAuctions();
            getEndedAuction();
        }

        private void getArtData() {
            CtrArt ctrArt = new CtrArt();
            lbxAvailableArt.DataSource = ctrArt.RetrieveAll().Where(x => x.AuctionId == null).ToList();

        }

        private void getUpcomingAuctions() {
            CtrAuction ctrAuction = new CtrAuction();
            lbxUpcoming.DataSource = ctrAuction.GetAll(false);
            lbxUpcoming.SelectedIndex = -1;
        }

        private void getEndedAuction() {
            CtrAuction ctrAuction = new CtrAuction();
            lbxEnded.DataSource = ctrAuction.GetAll(true);
            lbxEnded.SelectedIndex = -1;
        }

        private void btnMoveToRight_Click(object sender, EventArgs e) {

            var selectedList = lbxAvailableArt.SelectedItems.OfType<Art>().ToList();
            var endList = lbxSelectedArt.Items.OfType<Art>().ToList();

            endList.AddRange(selectedList);
            lbxSelectedArt.DataSource = endList;

            var aviList = lbxAvailableArt.Items.OfType<Art>().ToList();
            foreach (var art in selectedList) {
                aviList.Remove(art);
            }

            lbxAvailableArt.DataSource = aviList;
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e) {

            var selectedList = lbxSelectedArt.SelectedItems.OfType<Art>().ToList();
            var endList = lbxAvailableArt.Items.OfType<Art>().ToList();

            endList.AddRange(selectedList);
            lbxAvailableArt.DataSource = endList;

            var aviList = lbxSelectedArt.Items.OfType<Art>().ToList();
            foreach (var art in selectedList) {
                aviList.Remove(art);
            }

            lbxSelectedArt.DataSource = aviList;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            CtrAuction ctrAuction = new CtrAuction();

            DateTime dateCreated = dtpDate.Value;

            string description = txtDecs.Text;
            List<Art> artList = lbxSelectedArt.Items.OfType<Art>().ToList();
            if (dateCreated < DateTime.Now) {
                MessageBox.Show("Vælg en kommende dato", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (artList.Count == 0) {
                MessageBox.Show("Der skal vælges kunstgenstande", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (auction == null) {
                    ctrAuction.CreateAuction(dateCreated, description, artList);
                    MessageBox.Show("Auktionen er oprettet", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else {
                    auction.Date = dtpDate.Value;
                    auction.Description = txtDecs.Text;
                    auction.Arts = artList;
                    ctrAuction.UpdateAuction(auction);
                    MessageBox.Show("Auktionen er nu redigeret", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancel_Click(null,null);
            }

        }


        private void lbxUpcoming_MouseClick(object sender, MouseEventArgs e) {
            auction = lbxUpcoming.SelectedItem as Auction;
            dtpDate.Value = auction.Date;
            txtDecs.Text = auction.Description;
            lbxSelectedArt.DataSource = auction.Arts;
            grbCreate.Text = "Rediger";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            getArtData();
            getUpcomingAuctions();
            getEndedAuction();
            grbCreate.Text = "Opret";
            dtpDate.Value = DateTime.Now;
            txtDecs.Text = "";
            lbxSelectedArt.DataSource = null;
            auction = null;
        }

        private void lbxUpcoming_KeyDown(object sender, KeyEventArgs e) {

            if (auction == null)
                return;
            if (e.KeyCode == Keys.Delete) {
                DialogResult result = MessageBox.Show("Er du sikker på at du vel slette auktionen",
                    "Slet auktion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    CtrAuction ctrAuction = new CtrAuction();
                    ctrAuction.DeleteAuction(auction);
                    MessageBox.Show("Auktionen er slettet",
                    "Slet auktion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(null, null);
                }
            }

        }

        private void lbxUpcoming_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (auction == null) return;
            AuctionForm form = new AuctionForm(auction);
            form.ShowDialog(this);
        }


    }
}
