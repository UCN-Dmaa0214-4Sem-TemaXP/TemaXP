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
        public AuctionForm(Auction au)
        {
            InitializeComponent();

            dgvArts.DataSource = new CtrArt().RetrieveAll(au.Id);
        }

        private void dgvArts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedArt = dgvArts.CurrentRow.DataBoundItem;


        }
    }
}
