using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaXP.GUI;

namespace TemaXP {
    public partial class ArtForm : Form {
        public ArtForm() {
            InitializeComponent();
        }

        private void btnShowImg_Click(object sender, EventArgs e) {
            using (var dialog = new ShowImageForm(txtImgUrl.Text)) {
                dialog.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            foreach (var txt in Controls.OfType<TextBox>()) {
                txt.Clear();
            }
            
        }
    }
}
