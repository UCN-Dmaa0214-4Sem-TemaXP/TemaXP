using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaXP.GUI {
    public partial class ShowImageForm : Form {
        
        public ShowImageForm(string url) {
            InitializeComponent();
            pictureBox1.ImageLocation = url;

           // pictureBox1.SizeMode = SizeMode.Stretch;
        }
    }
}
