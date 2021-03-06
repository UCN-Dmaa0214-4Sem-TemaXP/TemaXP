﻿namespace TemaXP.GUI {
    partial class AuctionTab {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grbUpcoming = new System.Windows.Forms.GroupBox();
            this.lbxUpcoming = new System.Windows.Forms.ListBox();
            this.grbEnded = new System.Windows.Forms.GroupBox();
            this.lbxEnded = new System.Windows.Forms.ListBox();
            this.grbCreate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbxSelectedArt = new System.Windows.Forms.ListBox();
            this.lbxAvailableArt = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grbUpcoming.SuspendLayout();
            this.grbEnded.SuspendLayout();
            this.grbCreate.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbCreate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grbUpcoming, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.grbEnded, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(398, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 401);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // grbUpcoming
            // 
            this.grbUpcoming.Controls.Add(this.lbxUpcoming);
            this.grbUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbUpcoming.Location = new System.Drawing.Point(3, 3);
            this.grbUpcoming.Name = "grbUpcoming";
            this.grbUpcoming.Size = new System.Drawing.Size(383, 178);
            this.grbUpcoming.TabIndex = 0;
            this.grbUpcoming.TabStop = false;
            this.grbUpcoming.Text = "Kommende Auktioner";
            // 
            // lbxUpcoming
            // 
            this.lbxUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxUpcoming.FormattingEnabled = true;
            this.lbxUpcoming.Location = new System.Drawing.Point(3, 16);
            this.lbxUpcoming.Name = "lbxUpcoming";
            this.lbxUpcoming.Size = new System.Drawing.Size(377, 159);
            this.lbxUpcoming.TabIndex = 0;
            this.lbxUpcoming.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxUpcoming_MouseClick);
            this.lbxUpcoming.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxUpcoming_KeyDown);
            this.lbxUpcoming.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxUpcoming_MouseDoubleClick);
            // 
            // grbEnded
            // 
            this.grbEnded.Controls.Add(this.lbxEnded);
            this.grbEnded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbEnded.Location = new System.Drawing.Point(3, 187);
            this.grbEnded.Name = "grbEnded";
            this.grbEnded.Size = new System.Drawing.Size(383, 211);
            this.grbEnded.TabIndex = 1;
            this.grbEnded.TabStop = false;
            this.grbEnded.Text = "Afsluttede Auktioner";
            // 
            // lbxEnded
            // 
            this.lbxEnded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxEnded.FormattingEnabled = true;
            this.lbxEnded.Location = new System.Drawing.Point(3, 16);
            this.lbxEnded.Name = "lbxEnded";
            this.lbxEnded.Size = new System.Drawing.Size(377, 192);
            this.lbxEnded.TabIndex = 1;
            // 
            // grbCreate
            // 
            this.grbCreate.Controls.Add(this.tableLayoutPanel2);
            this.grbCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCreate.Location = new System.Drawing.Point(3, 3);
            this.grbCreate.Name = "grbCreate";
            this.grbCreate.Size = new System.Drawing.Size(389, 401);
            this.grbCreate.TabIndex = 4;
            this.grbCreate.TabStop = false;
            this.grbCreate.Text = "Opret";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDecs, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 382);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd-MM-yyyy hh:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(70, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(310, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskrivelse";
            // 
            // txtDecs
            // 
            this.txtDecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecs.Location = new System.Drawing.Point(70, 29);
            this.txtDecs.Multiline = true;
            this.txtDecs.Name = "txtDecs";
            this.txtDecs.Size = new System.Drawing.Size(310, 48);
            this.txtDecs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genstande";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbxSelectedArt, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbxAvailableArt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(67, 80);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(316, 241);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lbxSelectedArt
            // 
            this.lbxSelectedArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSelectedArt.FormattingEnabled = true;
            this.lbxSelectedArt.Location = new System.Drawing.Point(182, 16);
            this.lbxSelectedArt.Name = "lbxSelectedArt";
            this.lbxSelectedArt.Size = new System.Drawing.Size(131, 222);
            this.lbxSelectedArt.TabIndex = 6;
            this.lbxSelectedArt.DoubleClick += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // lbxAvailableArt
            // 
            this.lbxAvailableArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAvailableArt.FormattingEnabled = true;
            this.lbxAvailableArt.Location = new System.Drawing.Point(3, 16);
            this.lbxAvailableArt.Name = "lbxAvailableArt";
            this.lbxAvailableArt.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAvailableArt.Size = new System.Drawing.Size(130, 222);
            this.lbxAvailableArt.TabIndex = 7;
            this.lbxAvailableArt.DoubleClick += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMoveToLeft);
            this.panel1.Controls.Add(this.btnMoveToRight);
            this.panel1.Location = new System.Drawing.Point(139, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 63);
            this.panel1.TabIndex = 5;
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.Location = new System.Drawing.Point(3, 32);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(29, 23);
            this.btnMoveToLeft.TabIndex = 0;
            this.btnMoveToLeft.Text = "<-";
            this.btnMoveToLeft.UseVisualStyleBackColor = true;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.Location = new System.Drawing.Point(3, 3);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(29, 23);
            this.btnMoveToRight.TabIndex = 0;
            this.btnMoveToRight.Text = "->";
            this.btnMoveToRight.UseVisualStyleBackColor = true;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tilgængelige";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(182, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valgte";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuctionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AuctionTab";
            this.Size = new System.Drawing.Size(790, 407);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grbUpcoming.ResumeLayout(false);
            this.grbEnded.ResumeLayout(false);
            this.grbCreate.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox grbCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grbUpcoming;
        private System.Windows.Forms.ListBox lbxUpcoming;
        private System.Windows.Forms.GroupBox grbEnded;
        private System.Windows.Forms.ListBox lbxEnded;
        private System.Windows.Forms.ListBox lbxSelectedArt;
        private System.Windows.Forms.ListBox lbxAvailableArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
