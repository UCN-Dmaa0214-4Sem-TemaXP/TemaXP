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
using TemaXP.Model;

namespace TemaXP.GUI {
    public partial class ArtTab : UserControl {
        public ArtTab() {
            InitializeComponent();
            cmbSort.SelectedIndex = 0;
            CtrArt ctrArt = new CtrArt();
            List<Art> artList = ctrArt.RetrieveAll();
            dgvAtrList.DataSource = artList;
        }

        private void SetHeaderText(bool clear) {
            grbCreate.Text = clear ? "Opret" : "Ret";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            foreach (var txt in Controls.OfType<TextBox>()) {
                txt.Clear();
            }
            SetHeaderText(true);
        }

        private void btnShowImg_Click(object sender, EventArgs e) {
            using (var dialog = new ShowImageForm(txtImgUrl.Text)) {
                dialog.ShowDialog();
            }
        }

        private void dgvAtrList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Art selectedArt = (Art)dgvAtrList.CurrentRow.DataBoundItem;
        }

    }
}
