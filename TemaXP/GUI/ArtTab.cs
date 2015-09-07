using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaXP.GUI {
    public partial class ArtTab : UserControl {
        public ArtTab() {
            InitializeComponent();
            cmbSort.SelectedIndex = 0;
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

    }
}
