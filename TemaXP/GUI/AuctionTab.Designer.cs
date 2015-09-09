namespace TemaXP.GUI {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.lbxAvailableArt = new System.Windows.Forms.ListBox();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grbUpcoming, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.grbEnded, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(530, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(519, 493);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // grbUpcoming
            // 
            this.grbUpcoming.Controls.Add(this.lbxUpcoming);
            this.grbUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbUpcoming.Location = new System.Drawing.Point(4, 4);
            this.grbUpcoming.Margin = new System.Windows.Forms.Padding(4);
            this.grbUpcoming.Name = "grbUpcoming";
            this.grbUpcoming.Padding = new System.Windows.Forms.Padding(4);
            this.grbUpcoming.Size = new System.Drawing.Size(511, 218);
            this.grbUpcoming.TabIndex = 0;
            this.grbUpcoming.TabStop = false;
            this.grbUpcoming.Text = "Kommende Auktioner";
            // 
            // lbxUpcoming
            // 
            this.lbxUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxUpcoming.FormattingEnabled = true;
            this.lbxUpcoming.ItemHeight = 16;
            this.lbxUpcoming.Location = new System.Drawing.Point(4, 19);
            this.lbxUpcoming.Margin = new System.Windows.Forms.Padding(4);
            this.lbxUpcoming.Name = "lbxUpcoming";
            this.lbxUpcoming.Size = new System.Drawing.Size(503, 195);
            this.lbxUpcoming.TabIndex = 0;
            this.lbxUpcoming.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxUpcoming_MouseClick);
            this.lbxUpcoming.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxUpcoming_KeyDown);
            // 
            // grbEnded
            // 
            this.grbEnded.Controls.Add(this.lbxEnded);
            this.grbEnded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbEnded.Location = new System.Drawing.Point(4, 230);
            this.grbEnded.Margin = new System.Windows.Forms.Padding(4);
            this.grbEnded.Name = "grbEnded";
            this.grbEnded.Padding = new System.Windows.Forms.Padding(4);
            this.grbEnded.Size = new System.Drawing.Size(511, 259);
            this.grbEnded.TabIndex = 1;
            this.grbEnded.TabStop = false;
            this.grbEnded.Text = "Afsluttede Auktioner";
            // 
            // lbxEnded
            // 
            this.lbxEnded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxEnded.FormattingEnabled = true;
            this.lbxEnded.ItemHeight = 16;
            this.lbxEnded.Location = new System.Drawing.Point(4, 19);
            this.lbxEnded.Margin = new System.Windows.Forms.Padding(4);
            this.lbxEnded.Name = "lbxEnded";
            this.lbxEnded.Size = new System.Drawing.Size(503, 236);
            this.lbxEnded.TabIndex = 1;
            // 
            // grbCreate
            // 
            this.grbCreate.Controls.Add(this.tableLayoutPanel2);
            this.grbCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCreate.Location = new System.Drawing.Point(4, 4);
            this.grbCreate.Margin = new System.Windows.Forms.Padding(4);
            this.grbCreate.Name = "grbCreate";
            this.grbCreate.Padding = new System.Windows.Forms.Padding(4);
            this.grbCreate.Size = new System.Drawing.Size(518, 493);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 470);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 399);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(4, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
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
            this.dtpDate.Location = new System.Drawing.Point(92, 4);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(414, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskrivelse";
            // 
            // txtDecs
            // 
            this.txtDecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecs.Location = new System.Drawing.Point(92, 34);
            this.txtDecs.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecs.Multiline = true;
            this.txtDecs.Name = "txtDecs";
            this.txtDecs.Size = new System.Drawing.Size(414, 58);
            this.txtDecs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genstande";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbxSelectedArt, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbxAvailableArt, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(88, 96);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(422, 299);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lbxSelectedArt
            // 
            this.lbxSelectedArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSelectedArt.FormattingEnabled = true;
            this.lbxSelectedArt.ItemHeight = 16;
            this.lbxSelectedArt.Location = new System.Drawing.Point(243, 4);
            this.lbxSelectedArt.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSelectedArt.Name = "lbxSelectedArt";
            this.lbxSelectedArt.Size = new System.Drawing.Size(175, 291);
            this.lbxSelectedArt.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMoveToLeft);
            this.panel1.Controls.Add(this.btnMoveToRight);
            this.panel1.Location = new System.Drawing.Point(186, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.Location = new System.Drawing.Point(4, 39);
            this.btnMoveToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(39, 28);
            this.btnMoveToLeft.TabIndex = 0;
            this.btnMoveToLeft.Text = "<-";
            this.btnMoveToLeft.UseVisualStyleBackColor = true;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.Location = new System.Drawing.Point(4, 4);
            this.btnMoveToRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(39, 28);
            this.btnMoveToRight.TabIndex = 0;
            this.btnMoveToRight.Text = "->";
            this.btnMoveToRight.UseVisualStyleBackColor = true;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // lbxAvailableArt
            // 
            this.lbxAvailableArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAvailableArt.FormattingEnabled = true;
            this.lbxAvailableArt.ItemHeight = 16;
            this.lbxAvailableArt.Location = new System.Drawing.Point(4, 4);
            this.lbxAvailableArt.Margin = new System.Windows.Forms.Padding(4);
            this.lbxAvailableArt.Name = "lbxAvailableArt";
            this.lbxAvailableArt.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAvailableArt.Size = new System.Drawing.Size(174, 291);
            this.lbxAvailableArt.TabIndex = 1;
            // 
            // AuctionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuctionTab";
            this.Size = new System.Drawing.Size(1053, 501);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grbUpcoming.ResumeLayout(false);
            this.grbEnded.ResumeLayout(false);
            this.grbCreate.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbxSelectedArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.ListBox lbxAvailableArt;
        private System.Windows.Forms.GroupBox grbUpcoming;
        private System.Windows.Forms.ListBox lbxUpcoming;
        private System.Windows.Forms.GroupBox grbEnded;
        private System.Windows.Forms.ListBox lbxEnded;
    }
}
