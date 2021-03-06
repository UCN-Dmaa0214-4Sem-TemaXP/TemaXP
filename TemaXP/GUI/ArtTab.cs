﻿using System;
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
using System.Text.RegularExpressions;

namespace TemaXP.GUI
{
    public partial class ArtTab : UserControl
    {
        CtrArt ctrArt = new CtrArt();

        public ArtTab()
        {
            InitializeComponent();
            txtNumber.Enabled = false;
            cmbSort.SelectedIndex = 0;
            loadArtPieces();
            dgvAtrList.ClearSelection();
            
        }

        private void SetHeaderText(bool clear)
        {
            grbCreate.Text = clear ? "Opret" : "Rediger";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //foreach (var txt in tableLayoutPanel2.Controls.OfType<TextBox>())
            //{
            //    txt.Clear();
            //},
            clearTxtBoxes();
            
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            using (var dialog = new ShowImageForm(txtImgUrl.Text))
            {
                dialog.ShowDialog();
            }
        }

        private void dgvAtrList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Art selectedArt = (Art)dgvAtrList.CurrentRow.DataBoundItem;
            SetTxtCheckForNull(selectedArt.Number, txtNumber);
            SetTxtCheckForNull(selectedArt.Name, txtName);
            SetTxtCheckForNull(selectedArt.Artist, txtArtist);
            SetTxtCheckForNull(selectedArt.PurchasePrice, txtPurchasePrice);
            SetTxtCheckForNull(selectedArt.StartingBid, txtStartPrice);
            SetTxtCheckForNull(selectedArt.Image, txtImgUrl);
            SetTxtCheckForNull(selectedArt.Description, txtDescription);

            txtNumber.Enabled = true;
            SetHeaderText(false);
        }

        private void SetTxtCheckForNull(object attribut, TextBox txtBox)
        {
            if (attribut == null)
            {
                txtBox.Text = "";
            }
            else
            {
                txtBox.Text = attribut.ToString();
            }
        }

        private void clearTxtBoxes()
        {
            SetTxtCheckForNull(null, txtNumber);
            SetTxtCheckForNull(null, txtName);
            SetTxtCheckForNull(null, txtArtist);
            txtPurchasePrice.Text = "0,00";
            txtStartPrice.Text = "0,00";
            SetTxtCheckForNull(null, txtImgUrl);
            SetTxtCheckForNull(null, txtDescription);
            txtNumber.Enabled = false;
            SetHeaderText(true);
            dgvAtrList.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (grbCreate.Text == "Opret")
                {
                    ctrArt.Insert(txtName.Text, txtArtist.Text, txtDescription.Text, txtImgUrl.Text, Convert.ToDecimal(txtStartPrice.Text), Convert.ToDecimal(txtPurchasePrice.Text));
                }
                else if (grbCreate.Text == "Rediger")
                {
                    Art selectedArt = (Art)dgvAtrList.CurrentRow.DataBoundItem;
                    int id = selectedArt.Id;
                    ctrArt.Update(id, txtName.Text, Convert.ToInt32(txtNumber.Text), txtArtist.Text, txtDescription.Text, txtImgUrl.Text, Convert.ToDecimal(txtStartPrice.Text), Convert.ToDecimal(txtPurchasePrice.Text));
                }
                loadArtPieces();
                clearTxtBoxes();
            }
            else
            {
                MessageBox.Show("Udfyld kunstværkets navn");
            }

        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            onlyNumbersAndCommas(txtPurchasePrice);
        }

        private void txtStartPrice_TextChanged(object sender, EventArgs e)
        {
            onlyNumbersAndCommas(txtStartPrice);
        }

        private void onlyNumbersAndCommas(TextBox txtBox)
        {
            Regex numbers = new Regex("[0-9]");
            Regex comma = new Regex("[,.]");
            foreach (char c in txtBox.Text)
            {
                if (numbers.IsMatch(c.ToString()))
                {

                }
                else if (comma.IsMatch(c.ToString()))
                {
                }
                else
                {
                    txtBox.Text = txtBox.Text.Replace(c.ToString(), "");
                    txtBox.SelectionStart = txtBox.Text.Length;
                }
            }
        }

        private void loadArtPieces()
        {
            try
            {
                dgvAtrList.DataSource = ctrArt.RetrieveAll();
            }
            catch
            {
            }
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

    }
}
