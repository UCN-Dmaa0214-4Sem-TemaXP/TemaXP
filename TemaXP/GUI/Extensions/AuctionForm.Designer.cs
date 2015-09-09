namespace TemaXP.GUI.Extensions
{
    partial class AuctionForm
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
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingBidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblArtID = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.btnBid = new System.Windows.Forms.Button();
            this.lblMemberNo = new System.Windows.Forms.Label();
            this.lblBidAmount = new System.Windows.Forms.Label();
            this.txtBids = new System.Windows.Forms.TextBox();
            this.bidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBidState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
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
            this.Artist,
            this.idDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.startingBidDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.auctionDataGridViewTextBoxColumn,
            this.auctionIdDataGridViewTextBoxColumn});
            this.dgvArts.DataSource = this.artBindingSource;
            this.dgvArts.Location = new System.Drawing.Point(16, 70);
            this.dgvArts.MultiSelect = false;
            this.dgvArts.Name = "dgvArts";
            this.dgvArts.ReadOnly = true;
            this.dgvArts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArts.Size = new System.Drawing.Size(344, 483);
            this.dgvArts.TabIndex = 1;
            this.dgvArts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArts_CellContentClick);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startingBidDataGridViewTextBoxColumn
            // 
            this.startingBidDataGridViewTextBoxColumn.DataPropertyName = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.HeaderText = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.Name = "startingBidDataGridViewTextBoxColumn";
            this.startingBidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auctionDataGridViewTextBoxColumn
            // 
            this.auctionDataGridViewTextBoxColumn.DataPropertyName = "Auction";
            this.auctionDataGridViewTextBoxColumn.HeaderText = "Auction";
            this.auctionDataGridViewTextBoxColumn.Name = "auctionDataGridViewTextBoxColumn";
            this.auctionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auctionIdDataGridViewTextBoxColumn
            // 
            this.auctionIdDataGridViewTextBoxColumn.DataPropertyName = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.HeaderText = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.Name = "auctionIdDataGridViewTextBoxColumn";
            this.auctionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artBindingSource
            // 
            this.artBindingSource.DataSource = typeof(TemaXP.Model.Art);
            // 
            // lblArtID
            // 
            this.lblArtID.AutoSize = true;
            this.lblArtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtID.Location = new System.Drawing.Point(303, 47);
            this.lblArtID.Name = "lblArtID";
            this.lblArtID.Size = new System.Drawing.Size(57, 20);
            this.lblArtID.TabIndex = 2;
            this.lblArtID.Text = "label1";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(789, 67);
            this.txtMember.Name = "txtMember";
            this.txtMember.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(234, 20);
            this.txtMember.TabIndex = 4;
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(789, 93);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.ReadOnly = true;
            this.txtBidAmount.Size = new System.Drawing.Size(234, 20);
            this.txtBidAmount.TabIndex = 4;
            // 
            // btnBid
            // 
            this.btnBid.Enabled = false;
            this.btnBid.Location = new System.Drawing.Point(789, 119);
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
            this.lblMemberNo.Location = new System.Drawing.Point(690, 67);
            this.lblMemberNo.Name = "lblMemberNo";
            this.lblMemberNo.Size = new System.Drawing.Size(61, 13);
            this.lblMemberNo.TabIndex = 6;
            this.lblMemberNo.Text = "Medlemsnr.";
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Location = new System.Drawing.Point(690, 96);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(26, 13);
            this.lblBidAmount.TabIndex = 6;
            this.lblBidAmount.Text = "Bud";
            // 
            // txtBids
            // 
            this.txtBids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBids.Location = new System.Drawing.Point(391, 70);
            this.txtBids.Multiline = true;
            this.txtBids.Name = "txtBids";
            this.txtBids.ReadOnly = true;
            this.txtBids.Size = new System.Drawing.Size(282, 483);
            this.txtBids.TabIndex = 7;
            // 
            // bidBindingSource
            // 
            this.bidBindingSource.DataSource = typeof(TemaXP.Model.Bid);
            // 
            // lblBidState
            // 
            this.lblBidState.AutoSize = true;
            this.lblBidState.Location = new System.Drawing.Point(786, 162);
            this.lblBidState.Name = "lblBidState";
            this.lblBidState.Size = new System.Drawing.Size(0, 13);
            this.lblBidState.TabIndex = 8;
            // 
            // AuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 565);
            this.Controls.Add(this.lblBidState);
            this.Controls.Add(this.txtBids);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.lblMemberNo);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.lblArtID);
            this.Controls.Add(this.dgvArts);
            this.Controls.Add(this.lblHeader);
            this.Name = "AuctionForm";
            this.Text = "AuctionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvArts;
        private System.Windows.Forms.BindingSource artBindingSource;
        private System.Windows.Forms.Label lblArtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.BindingSource bidBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingBidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.Label lblMemberNo;
        private System.Windows.Forms.Label lblBidAmount;
        private System.Windows.Forms.TextBox txtBids;
        private System.Windows.Forms.Label lblBidState;
    }
}