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
    public partial class Budgivning : Form
    {
        private Auction currentAuction;
        private CtrArt ctrArt;
        private CtrAuction ctrAuc;
        private Art currentArt;

        // Highest bidder
        private decimal previousBid = 0;
        private Member previosBidder = null;

        public Budgivning(Auction au)
        {
            InitializeComponent();

            lblHeader.Text = "Auktion den " + au.Date;

            currentAuction = au;

            ctrArt = new CtrArt();
            ctrAuc = new CtrAuction();

            dgvArts.DataSource = ctrArt.RetrieveAll(au.Id);
        }

        private void dgvArts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentArt = (Art)dgvArts.CurrentRow.DataBoundItem;

            lblArtBid.Text = "Budgivning: Kunstværk nr. " + currentArt.Number.ToString();

            populatebids(currentArt.Number);
        }

        private void populatebids(int no)
        {
            txtBids.Text = "";
            var art = ctrArt.RetrieveByNo(no);
            List<Bid> bCollection = ctrAuc.RetrieveBidsByArt(art);

            pictureBox1.ImageLocation = art.Image;

            txtBidAmount.ReadOnly = false;
            txtMember.ReadOnly = false;
            btnBid.Enabled = true;

            foreach (var item in bCollection)
            {
                txtBids.Text = txtBids.Text + "Medlemnr. " + item.Member.Id + " har budt " + item.BidAmount + Environment.NewLine;
            }
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            CtrMember ctrMem = new CtrMember();

            Member m = ctrMem.RetrieveSingleByID(Convert.ToInt32(txtMember.Text));
            Art a = ctrArt.RetrieveByNo(currentArt.Number);

            if (previosBidder != null)
            {
                if (previosBidder.Id == m.Id)
                {
                    lblBidState.Text = "Medlem har allerede højeste bud!";
                }
                else
                {
                    if (currentArt.StartingBid > Convert.ToDecimal(txtBidAmount.Text))
                    {
                        lblBidState.Text = "Buddet er mindre end startsprisen!";
                    }
                    else if (previousBid >= Convert.ToDecimal(txtBidAmount.Text))
                    {
                        lblBidState.Text = "Buddet skal være højere end det forrige!";
                    }
                    else
                    {
                        CtrMember.MemberBidState state = ctrAuc.InsertBid(m.Id, Convert.ToDecimal(txtBidAmount.Text), a.Id);

                        if (state == CtrMember.MemberBidState.BidConfirmed)
                        {
                            lblBidState.Text = "Bud accepteret!";
                            previosBidder = m;
                            previousBid = Convert.ToDecimal(txtBidAmount.Text);
                            populatebids(a.Number);
                        }
                        if (state == CtrMember.MemberBidState.BidError)
                        {
                            lblBidState.Text = "Bud blev ikke accepteret!";
                        }
                        if (state == CtrMember.MemberBidState.NotEnough)
                        {
                            lblBidState.Text = "Medlem har ikke nok point!";
                        }
                    }
                }
            }

            else
            {
                if (currentArt.StartingBid > Convert.ToDecimal(txtBidAmount.Text))
                {
                    lblBidState.Text = "Buddet er mindre end startsprisen!";

                }
                else if (previousBid >= Convert.ToDecimal(txtBidAmount.Text))
                {
                    lblBidState.Text = "Buddet skal være højere end det forrige!";
                }
                else
                {
                    CtrMember.MemberBidState state = ctrAuc.InsertBid(m.Id, Convert.ToDecimal(txtBidAmount.Text), a.Id);

                    if (state == CtrMember.MemberBidState.BidConfirmed)
                    {
                        lblBidState.Text = "Bud accepteret!";
                        previosBidder = m;
                        previousBid = Convert.ToDecimal(txtBidAmount.Text);
                        populatebids(a.Number);
                    }
                    if (state == CtrMember.MemberBidState.BidError)
                    {
                        lblBidState.Text = "Bud blev ikke accepteret!";
                    }
                    if (state == CtrMember.MemberBidState.NotEnough)
                    {
                        lblBidState.Text = "Medlem har ikke nok point!";
                    }
                }

            }

        }
    }
}
