namespace TemaXP.GUI {
    partial class ArtTab {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbCreate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblPurchasePrise = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtStartPrice = new System.Windows.Forms.TextBox();
            this.lblStartPrice = new System.Windows.Forms.Label();
            this.lblImgUrl = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowImg = new System.Windows.Forms.Button();
            this.txtImgUrl = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAtrList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.artBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grbCreate.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrList)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grbCreate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 414);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbCreate
            // 
            this.grbCreate.Controls.Add(this.tableLayoutPanel2);
            this.grbCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCreate.Location = new System.Drawing.Point(4, 4);
            this.grbCreate.Margin = new System.Windows.Forms.Padding(4);
            this.grbCreate.Name = "grbCreate";
            this.grbCreate.Padding = new System.Windows.Forms.Padding(4);
            this.grbCreate.Size = new System.Drawing.Size(259, 406);
            this.grbCreate.TabIndex = 1;
            this.grbCreate.TabStop = false;
            this.grbCreate.Text = "Opret";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblArtist, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtArtist, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPurchasePrise, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPurchasePrice, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtStartPrice, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblStartPrice, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblImgUrl, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblNo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 383);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(4, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(92, 4);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(155, 22);
            this.txtNumber.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(92, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Navn";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(4, 60);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(57, 17);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Kunster";
            // 
            // txtArtist
            // 
            this.txtArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtist.Location = new System.Drawing.Point(92, 64);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(155, 22);
            this.txtArtist.TabIndex = 6;
            // 
            // lblPurchasePrise
            // 
            this.lblPurchasePrise.AutoSize = true;
            this.lblPurchasePrise.Location = new System.Drawing.Point(4, 90);
            this.lblPurchasePrise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasePrise.Name = "lblPurchasePrise";
            this.lblPurchasePrise.Size = new System.Drawing.Size(80, 17);
            this.lblPurchasePrise.TabIndex = 7;
            this.lblPurchasePrise.Text = "Indkøbspris";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.artBindingSource1, "PurchasePrice", true));
            this.txtPurchasePrice.Location = new System.Drawing.Point(92, 94);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(155, 22);
            this.txtPurchasePrice.TabIndex = 8;
            this.txtPurchasePrice.Text = "0,00";
            this.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartPrice.Location = new System.Drawing.Point(92, 124);
            this.txtStartPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.Size = new System.Drawing.Size(155, 22);
            this.txtStartPrice.TabIndex = 9;
            this.txtStartPrice.Text = "0,00";
            this.txtStartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStartPrice.TextChanged += new System.EventHandler(this.txtStartPrice_TextChanged);
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.Location = new System.Drawing.Point(4, 120);
            this.lblStartPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(65, 17);
            this.lblStartPrice.TabIndex = 10;
            this.lblStartPrice.Text = "Start pris";
            // 
            // lblImgUrl
            // 
            this.lblImgUrl.AutoSize = true;
            this.lblImgUrl.Location = new System.Drawing.Point(4, 150);
            this.lblImgUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImgUrl.Name = "lblImgUrl";
            this.lblImgUrl.Size = new System.Drawing.Size(50, 17);
            this.lblImgUrl.TabIndex = 11;
            this.lblImgUrl.Text = "Billede";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 183);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(92, 187);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(155, 77);
            this.txtDescription.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 272);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnShowImg, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtImgUrl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(88, 150);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 33);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // btnShowImg
            // 
            this.btnShowImg.Location = new System.Drawing.Point(119, 4);
            this.btnShowImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowImg.Name = "btnShowImg";
            this.btnShowImg.Size = new System.Drawing.Size(40, 25);
            this.btnShowImg.TabIndex = 3;
            this.btnShowImg.Text = "Vis";
            this.btnShowImg.UseVisualStyleBackColor = true;
            this.btnShowImg.Click += new System.EventHandler(this.btnShowImg_Click);
            // 
            // txtImgUrl
            // 
            this.txtImgUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgUrl.Location = new System.Drawing.Point(4, 4);
            this.txtImgUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtImgUrl.Name = "txtImgUrl";
            this.txtImgUrl.Size = new System.Drawing.Size(107, 22);
            this.txtImgUrl.TabIndex = 2;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(4, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(23, 17);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "Nr";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvAtrList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(271, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(530, 406);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dgvAtrList
            // 
            this.dgvAtrList.AllowUserToAddRows = false;
            this.dgvAtrList.AllowUserToDeleteRows = false;
            this.dgvAtrList.AutoGenerateColumns = false;
            this.dgvAtrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtrList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvAtrList.DataSource = this.artBindingSource1;
            this.dgvAtrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtrList.Location = new System.Drawing.Point(4, 44);
            this.dgvAtrList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAtrList.MultiSelect = false;
            this.dgvAtrList.Name = "dgvAtrList";
            this.dgvAtrList.ReadOnly = true;
            this.dgvAtrList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtrList.Size = new System.Drawing.Size(522, 358);
            this.dgvAtrList.TabIndex = 1;
            this.dgvAtrList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtrList_CellClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.cmbSort, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblSort, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(522, 32);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Alle",
            "Seneste måned",
            "Seneste ½ år",
            "Seneste 1 år"});
            this.cmbSort.Location = new System.Drawing.Point(358, 4);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(160, 24);
            this.cmbSort.TabIndex = 0;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(303, 7);
            this.lblSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(47, 17);
            this.lblSort.TabIndex = 1;
            this.lblSort.Text = "Sorter";
            // 
            // artBindingSource1
            // 
            this.artBindingSource1.DataSource = typeof(TemaXP.Model.Art);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artBindingSource
            // 
            this.artBindingSource.DataSource = typeof(TemaXP.Model.Art);
            // 
            // ArtTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArtTab";
            this.Size = new System.Drawing.Size(805, 414);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbCreate.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrList)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblPurchasePrise;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtStartPrice;
        private System.Windows.Forms.Label lblStartPrice;
        private System.Windows.Forms.Label lblImgUrl;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtImgUrl;
        private System.Windows.Forms.Button btnShowImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvAtrList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.BindingSource artBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artBindingSource1;

    }
}
