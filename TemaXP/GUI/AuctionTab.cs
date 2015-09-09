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
    public partial class AuctionTab : UserControl {

        private List<Art> aviArtList = new List<Art>(); 
        public AuctionTab() {
            InitializeComponent();
            
            getArtData();
        }

        private void getArtData()
        {
            CtrArt ctrArt = new CtrArt();
            lbxAvailableArt.DataSource = ctrArt.RetrieveAll();
            
          
        }
    }
}
