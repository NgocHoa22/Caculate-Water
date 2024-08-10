namespace ASM_1_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.lblthis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhienthi = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lvname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtyper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvthis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvsum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btreset = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btesc = new System.Windows.Forms.Button();
            this.btcacu = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btprint = new System.Windows.Forms.Button();
            this.cbbtyper = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtthis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(356, 70);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(174, 27);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Customer Name:";
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Location = new System.Drawing.Point(356, 176);
            this.lbllast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(228, 27);
            this.lbllast.TabIndex = 2;
            this.lbllast.Text = "Last Month\'s Reading:";
            // 
            // lblthis
            // 
            this.lblthis.AutoSize = true;
            this.lblthis.Location = new System.Drawing.Point(356, 241);
            this.lblthis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthis.Name = "lblthis";
            this.lblthis.Size = new System.Drawing.Size(227, 27);
            this.lblthis.TabIndex = 3;
            this.lblthis.Text = "This Month\'s Reading:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Typer:";
            // 
            // lblhienthi
            // 
            this.lblhienthi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblhienthi.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhienthi.Location = new System.Drawing.Point(-3, 391);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(1797, 279);
            this.lblhienthi.TabIndex = 4;
            this.lblhienthi.Text = "Unit price and payment method";
            this.lblhienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblhienthi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvname,
            this.lvphone,
            this.lvtyper,
            this.lvlast,
            this.lvthis,
            this.lvsum,
            this.lvmoney});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(2, 673);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1792, 293);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvname
            // 
            this.lvname.Text = "Name";
            this.lvname.Width = 203;
            // 
            // lvphone
            // 
            this.lvphone.Text = "Phone";
            this.lvphone.Width = 211;
            // 
            // lvtyper
            // 
            this.lvtyper.Text = "Typer";
            this.lvtyper.Width = 236;
            // 
            // lvlast
            // 
            this.lvlast.Text = "Water volume last month";
            this.lvlast.Width = 324;
            // 
            // lvthis
            // 
            this.lvthis.Text = "Water volume this month";
            this.lvthis.Width = 270;
            // 
            // lvsum
            // 
            this.lvsum.Text = "Amount of Water Used";
            this.lvsum.Width = 277;
            // 
            // lvmoney
            // 
            this.lvmoney.Text = "Total Money";
            this.lvmoney.Width = 264;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(387, 34);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(173, 52);
            this.btreset.TabIndex = 4;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(6, 92);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(173, 52);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "Delete";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btesc
            // 
            this.btesc.Location = new System.Drawing.Point(387, 92);
            this.btesc.Name = "btesc";
            this.btesc.Size = new System.Drawing.Size(173, 52);
            this.btesc.TabIndex = 5;
            this.btesc.Text = "Esc";
            this.btesc.UseVisualStyleBackColor = true;
            this.btesc.Click += new System.EventHandler(this.btesc_Click);
            // 
            // btcacu
            // 
            this.btcacu.Location = new System.Drawing.Point(6, 34);
            this.btcacu.Name = "btcacu";
            this.btcacu.Size = new System.Drawing.Size(173, 52);
            this.btcacu.TabIndex = 0;
            this.btcacu.Text = "Caculate";
            this.btcacu.UseVisualStyleBackColor = true;
            this.btcacu.Click += new System.EventHandler(this.btcacu_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(194, 34);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(173, 52);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(194, 92);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(173, 52);
            this.btprint.TabIndex = 3;
            this.btprint.Text = "Print Bill";
            this.btprint.UseVisualStyleBackColor = true;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // cbbtyper
            // 
            this.cbbtyper.FormattingEnabled = true;
            this.cbbtyper.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cbbtyper.Location = new System.Drawing.Point(601, 298);
            this.cbbtyper.Name = "cbbtyper";
            this.cbbtyper.Size = new System.Drawing.Size(264, 35);
            this.cbbtyper.TabIndex = 4;
            this.cbbtyper.SelectedIndexChanged += new System.EventHandler(this.cbbtyper_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(601, 62);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(264, 35);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(601, 168);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(264, 35);
            this.txtlast.TabIndex = 2;
            // 
            // txtthis
            // 
            this.txtthis.Location = new System.Drawing.Point(601, 233);
            this.txtthis.Name = "txtthis";
            this.txtthis.Size = new System.Drawing.Size(264, 35);
            this.txtthis.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btesc);
            this.groupBox1.Controls.Add(this.btcacu);
            this.groupBox1.Controls.Add(this.btreset);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btprint);
            this.groupBox1.Controls.Add(this.btedit);
            this.groupBox1.Location = new System.Drawing.Point(964, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(601, 117);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(264, 35);
            this.txtphone.TabIndex = 1;
            this.txtphone.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(356, 117);
            this.lblphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(79, 27);
            this.lblphone.TabIndex = 1;
            this.lblphone.Text = "Phone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 962);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtthis);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbbtyper);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.lblthis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cacule Water";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label lblthis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhienthi;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btesc;
        private System.Windows.Forms.Button btcacu;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.ComboBox cbbtyper;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtthis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader lvname;
        private System.Windows.Forms.ColumnHeader lvphone;
        private System.Windows.Forms.ColumnHeader lvtyper;
        private System.Windows.Forms.ColumnHeader lvlast;
        private System.Windows.Forms.ColumnHeader lvthis;
        private System.Windows.Forms.ColumnHeader lvsum;
        private System.Windows.Forms.ColumnHeader lvmoney;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
    }
}

