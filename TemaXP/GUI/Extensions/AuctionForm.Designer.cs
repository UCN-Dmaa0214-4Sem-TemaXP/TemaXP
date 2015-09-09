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
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingBidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(70, 25);
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
            this.dgvArts.Location = new System.Drawing.Point(21, 86);
            this.dgvArts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArts.MultiSelect = false;
            this.dgvArts.Name = "dgvArts";
            this.dgvArts.ReadOnly = true;
            this.dgvArts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArts.Size = new System.Drawing.Size(459, 594);
            this.dgvArts.TabIndex = 1;
            this.dgvArts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArts_CellContentClick);
            // 
            // artBindingSource
            // 
            this.artBindingSource.DataSource = typeof(TemaXP.Model.Art);
            // 
            // lblArtID
            // 
            this.lblArtID.AutoSize = true;
            this.lblArtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtID.Location = new System.Drawing.Point(404, 58);
            this.lblArtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtID.Name = "lblArtID";
            this.lblArtID.Size = new System.Drawing.Size(70, 25);
            this.lblArtID.TabIndex = 2;
            this.lblArtID.Text = "label1";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(1052, 82);
            this.txtMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMember.Name = "txtMember";
            this.txtMember.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(311, 22);
            this.txtMember.TabIndex = 4;
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(1052, 114);
            this.txtBidAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.ReadOnly = true;
            this.txtBidAmount.Size = new System.Drawing.Size(311, 22);
            this.txtBidAmount.TabIndex = 4;
            // 
            // btnBid
            // 
            this.btnBid.Enabled = false;
            this.btnBid.Location = new System.Drawing.Point(1052, 146);
            this.btnBid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(100, 28);
            this.btnBid.TabIndex = 5;
            this.btnBid.Text = "Byd!";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // lblMemberNo
            // 
            this.lblMemberNo.AutoSize = true;
            this.lblMemberNo.Location = new System.Drawing.Point(920, 82);
            this.lblMemberNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberNo.Name = "lblMemberNo";
            this.lblMemberNo.Size = new System.Drawing.Size(81, 17);
            this.lblMemberNo.TabIndex = 6;
            this.lblMemberNo.Text = "Medlemsnr.";
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Location = new System.Drawing.Point(920, 118);
            this.lblBidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(33, 17);
            this.lblBidAmount.TabIndex = 6;
            this.lblBidAmount.Text = "Bud";
            // 
            // txtBids
            // 
            this.txtBids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBids.Location = new System.Drawing.Point(521, 86);
            this.txtBids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBids.Multiline = true;
            this.txtBids.Name = "txtBids";
            this.txtBids.ReadOnly = true;
            this.txtBids.Size = new System.Drawing.Size(375, 594);
            this.txtBids.TabIndex = 7;
            // 
            // bidBindingSource
            // 
            this.bidBindingSource.DataSource = typeof(TemaXP.Model.Bid);
            // 
            // lblBidState
            // 
            this.lblBidState.AutoSize = true;
            this.lblBidState.Location = new System.Drawing.Point(1048, 199);
            this.lblBidState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBidState.Name = "lblBidState";
            this.lblBidState.Size = new System.Drawing.Size(0, 17);
            this.lblBidState.TabIndex = 8;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
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
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // startingBidDataGridViewTextBoxColumn
            // 
            this.startingBidDataGridViewTextBoxColumn.DataPropertyName = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.HeaderText = "StartingBid";
            this.startingBidDataGridViewTextBoxColumn.Name = "startingBidDataGridViewTextBoxColumn";
            this.startingBidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Budgivning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 695);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Budgivning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}