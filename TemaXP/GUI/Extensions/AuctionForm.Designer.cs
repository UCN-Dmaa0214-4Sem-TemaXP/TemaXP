namespace TemaXP.GUI.Extensions
{
    partial class Budgivning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvArts = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingBidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblArtBid = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.btnBid = new System.Windows.Forms.Button();
            this.lblMemberNo = new System.Windows.Forms.Label();
            this.lblBidAmount = new System.Windows.Forms.Label();
            this.txtBids = new System.Windows.Forms.TextBox();
            this.lblBidState = new System.Windows.Forms.Label();
            this.bidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(57, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            // 
            // dgvArts
            // 
            this.dgvArts.AllowUserToAddRows = false;
            this.dgvArts.AllowUserToDeleteRows = false;
            this.dgvArts.AutoGenerateColumns = false;
            this.dgvArts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.nameDataGridViewTextBoxColumn,
            this.Artist,
            this.startingBidDataGridViewTextBoxColumn});
            this.dgvArts.DataSource = this.artBindingSource;
            this.dgvArts.Location = new System.Drawing.Point(16, 70);
            this.dgvArts.MultiSelect = false;
            this.dgvArts.Name = "dgvArts";
            this.dgvArts.ReadOnly = true;
            this.dgvArts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArts.Size = new System.Drawing.Size(428, 483);
            this.dgvArts.TabIndex = 1;
            this.dgvArts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArts_CellClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 69;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // startingBidDataGridViewTextBoxColumn
            // 
            this.startingBidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.startingBidDataGridViewTextBoxColumn.DataPropertyName = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.HeaderText = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.Name = "startingBidDataGridViewTextBoxColumn";
            this.startingBidDataGridViewTextBoxColumn.ReadOnly = true;
            this.startingBidDataGridViewTextBoxColumn.Width = 83;
            // 
            // artBindingSource
            // 
            this.artBindingSource.DataSource = typeof(TemaXP.Model.Art);
            // 
            // lblArtBid
            // 
            this.lblArtBid.AutoSize = true;
            this.lblArtBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtBid.Location = new System.Drawing.Point(472, 39);
            this.lblArtBid.Name = "lblArtBid";
            this.lblArtBid.Size = new System.Drawing.Size(102, 20);
            this.lblArtBid.TabIndex = 2;
            this.lblArtBid.Text = "Budgivning:";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(859, 67);
            this.txtMember.Name = "txtMember";
            this.txtMember.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(164, 20);
            this.txtMember.TabIndex = 4;
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(859, 93);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.ReadOnly = true;
            this.txtBidAmount.Size = new System.Drawing.Size(164, 20);
            this.txtBidAmount.TabIndex = 4;
            // 
            // btnBid
            // 
            this.btnBid.Enabled = false;
            this.btnBid.Location = new System.Drawing.Point(859, 117);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(75, 23);
            this.btnBid.TabIndex = 5;
            this.btnBid.Text = "Byd!";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // lblMemberNo
            // 
            this.lblMemberNo.AutoSize = true;
            this.lblMemberNo.Location = new System.Drawing.Point(792, 67);
            this.lblMemberNo.Name = "lblMemberNo";
            this.lblMemberNo.Size = new System.Drawing.Size(61, 13);
            this.lblMemberNo.TabIndex = 6;
            this.lblMemberNo.Text = "Medlemsnr.";
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Location = new System.Drawing.Point(792, 93);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(26, 13);
            this.lblBidAmount.TabIndex = 6;
            this.lblBidAmount.Text = "Bud";
            // 
            // txtBids
            // 
            this.txtBids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBids.Location = new System.Drawing.Point(476, 70);
            this.txtBids.Multiline = true;
            this.txtBids.Name = "txtBids";
            this.txtBids.ReadOnly = true;
            this.txtBids.Size = new System.Drawing.Size(282, 483);
            this.txtBids.TabIndex = 7;
            // 
            // lblBidState
            // 
            this.lblBidState.AutoSize = true;
            this.lblBidState.Location = new System.Drawing.Point(786, 162);
            this.lblBidState.Name = "lblBidState";
            this.lblBidState.Size = new System.Drawing.Size(0, 13);
            this.lblBidState.TabIndex = 8;
            // 
            // bidBindingSource
            // 
            this.bidBindingSource.DataSource = typeof(TemaXP.Model.Bid);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(763, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Budgivning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBidState);
            this.Controls.Add(this.txtBids);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.lblMemberNo);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.lblArtBid);
            this.Controls.Add(this.dgvArts);
            this.Controls.Add(this.lblHeader);
            this.Name = "Budgivning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuctionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvArts;
        private System.Windows.Forms.BindingSource artBindingSource;
        private System.Windows.Forms.Label lblArtBid;
        private System.Windows.Forms.BindingSource bidBindingSource;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.Label lblMemberNo;
        private System.Windows.Forms.Label lblBidAmount;
        private System.Windows.Forms.TextBox txtBids;
        private System.Windows.Forms.Label lblBidState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingBidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}