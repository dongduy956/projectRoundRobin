namespace RoundRobin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddtg = new System.Windows.Forms.Button();
            this.lbQuarium = new System.Windows.Forms.Label();
            this.txBquarium = new System.Windows.Forms.TextBox();
            this.txtgden = new System.Windows.Forms.TextBox();
            this.txBtgxuly = new System.Windows.Forms.TextBox();
            this.txBTen = new System.Windows.Forms.TextBox();
            this.lbtgxuly = new System.Windows.Forms.Label();
            this.lbtgden = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lwinput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTSUMIT = new System.Windows.Forms.Button();
            this.btnGant = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tghttb = new System.Windows.Forms.Label();
            this.lbtgchotb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnaddtg);
            this.groupBox1.Controls.Add(this.lbQuarium);
            this.groupBox1.Controls.Add(this.txBquarium);
            this.groupBox1.Controls.Add(this.txtgden);
            this.groupBox1.Controls.Add(this.txBtgxuly);
            this.groupBox1.Controls.Add(this.txBTen);
            this.groupBox1.Controls.Add(this.lbtgxuly);
            this.groupBox1.Controls.Add(this.lbtgden);
            this.groupBox1.Controls.Add(this.lbten);
            this.groupBox1.Controls.Add(this.lwinput);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(753, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // btnaddtg
            // 
            this.btnaddtg.AllowDrop = true;
            this.btnaddtg.AutoSize = true;
            this.btnaddtg.BackColor = System.Drawing.Color.Transparent;
            this.btnaddtg.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtg.Location = new System.Drawing.Point(659, 26);
            this.btnaddtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddtg.Name = "btnaddtg";
            this.btnaddtg.Size = new System.Drawing.Size(82, 35);
            this.btnaddtg.TabIndex = 10;
            this.btnaddtg.Text = "ADDTIME";
            this.btnaddtg.UseVisualStyleBackColor = false;
            this.btnaddtg.Click += new System.EventHandler(this.btnaddtg_Click);
            // 
            // lbQuarium
            // 
            this.lbQuarium.AutoSize = true;
            this.lbQuarium.Location = new System.Drawing.Point(506, 93);
            this.lbQuarium.Name = "lbQuarium";
            this.lbQuarium.Size = new System.Drawing.Size(141, 31);
            this.lbQuarium.TabIndex = 8;
            this.lbQuarium.Text = "QuanTum:";
            // 
            // txBquarium
            // 
            this.txBquarium.AcceptsReturn = true;
            this.txBquarium.AcceptsTab = true;
            this.txBquarium.AllowDrop = true;
            this.txBquarium.Location = new System.Drawing.Point(659, 86);
            this.txBquarium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBquarium.Name = "txBquarium";
            this.txBquarium.Size = new System.Drawing.Size(89, 38);
            this.txBquarium.TabIndex = 7;
            this.txBquarium.TextChanged += new System.EventHandler(this.txBquarium_TextChanged);
            // 
            // txtgden
            // 
            this.txtgden.AcceptsReturn = true;
            this.txtgden.AcceptsTab = true;
            this.txtgden.AllowDrop = true;
            this.txtgden.Location = new System.Drawing.Point(219, 81);
            this.txtgden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgden.Name = "txtgden";
            this.txtgden.Size = new System.Drawing.Size(89, 38);
            this.txtgden.TabIndex = 5;
            this.txtgden.TextChanged += new System.EventHandler(this.txtgden_TextChanged);
            // 
            // txBtgxuly
            // 
            this.txBtgxuly.AcceptsReturn = true;
            this.txBtgxuly.AcceptsTab = true;
            this.txBtgxuly.AllowDrop = true;
            this.txBtgxuly.Location = new System.Drawing.Point(219, 126);
            this.txBtgxuly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBtgxuly.Name = "txBtgxuly";
            this.txBtgxuly.Size = new System.Drawing.Size(89, 38);
            this.txBtgxuly.TabIndex = 6;
            this.txBtgxuly.TextChanged += new System.EventHandler(this.txBtgxuly_TextChanged);
            // 
            // txBTen
            // 
            this.txBTen.AcceptsReturn = true;
            this.txBTen.AcceptsTab = true;
            this.txBTen.AllowDrop = true;
            this.txBTen.BackColor = System.Drawing.Color.White;
            this.txBTen.Location = new System.Drawing.Point(219, 34);
            this.txBTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBTen.Name = "txBTen";
            this.txBTen.Size = new System.Drawing.Size(89, 38);
            this.txBTen.TabIndex = 4;
            this.txBTen.TextChanged += new System.EventHandler(this.txBTen_TextChanged);
            // 
            // lbtgxuly
            // 
            this.lbtgxuly.AutoSize = true;
            this.lbtgxuly.Location = new System.Drawing.Point(5, 129);
            this.lbtgxuly.Name = "lbtgxuly";
            this.lbtgxuly.Size = new System.Drawing.Size(200, 31);
            this.lbtgxuly.TabIndex = 3;
            this.lbtgxuly.Text = "Thời gian xử lý:";
            // 
            // lbtgden
            // 
            this.lbtgden.AutoSize = true;
            this.lbtgden.Location = new System.Drawing.Point(5, 83);
            this.lbtgden.Name = "lbtgden";
            this.lbtgden.Size = new System.Drawing.Size(185, 31);
            this.lbtgden.TabIndex = 2;
            this.lbtgden.Text = "Thời gian đến:";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(5, 41);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(185, 31);
            this.lbten.TabIndex = 1;
            this.lbten.Text = "Tên tiến trình:";
            // 
            // lwinput
            // 
            this.lwinput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lwinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwinput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lwinput.FullRowSelect = true;
            this.lwinput.GridLines = true;
            this.lwinput.Location = new System.Drawing.Point(5, 180);
            this.lwinput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwinput.Name = "lwinput";
            this.lwinput.Size = new System.Drawing.Size(742, 322);
            this.lwinput.TabIndex = 0;
            this.lwinput.UseCompatibleStateImageBehavior = false;
            this.lwinput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên tiến trình";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian đến";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian xử lý";
            this.columnHeader3.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BTSUMIT);
            this.groupBox2.Controls.Add(this.btnGant);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(774, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(665, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOOL";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(271, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTSUMIT
            // 
            this.BTSUMIT.AllowDrop = true;
            this.BTSUMIT.AutoSize = true;
            this.BTSUMIT.BackColor = System.Drawing.Color.Transparent;
            this.BTSUMIT.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSUMIT.Location = new System.Drawing.Point(119, 39);
            this.BTSUMIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTSUMIT.Name = "BTSUMIT";
            this.BTSUMIT.Size = new System.Drawing.Size(108, 35);
            this.BTSUMIT.TabIndex = 12;
            this.BTSUMIT.Text = "ROUNDROBIN";
            this.BTSUMIT.UseVisualStyleBackColor = false;
            this.BTSUMIT.Click += new System.EventHandler(this.BTSUMIT_Click);
            // 
            // btnGant
            // 
            this.btnGant.AllowDrop = true;
            this.btnGant.AutoSize = true;
            this.btnGant.BackColor = System.Drawing.Color.Transparent;
            this.btnGant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGant.Location = new System.Drawing.Point(119, 95);
            this.btnGant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGant.Name = "btnGant";
            this.btnGant.Size = new System.Drawing.Size(144, 35);
            this.btnGant.TabIndex = 11;
            this.btnGant.Text = "SJF(độc quyền)";
            this.btnGant.UseVisualStyleBackColor = false;
            this.btnGant.Click += new System.EventHandler(this.btnGant_Click);
            // 
            // btndelete
            // 
            this.btndelete.AllowDrop = true;
            this.btndelete.AutoSize = true;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(6, 95);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(74, 35);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.AllowDrop = true;
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Enabled = false;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(5, 37);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(74, 35);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tghttb);
            this.groupBox3.Controls.Add(this.lbtgchotb);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(774, 176);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(665, 340);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OUTPUT";
            // 
            // tghttb
            // 
            this.tghttb.AutoSize = true;
            this.tghttb.Location = new System.Drawing.Point(432, 256);
            this.tghttb.Name = "tghttb";
            this.tghttb.Size = new System.Drawing.Size(0, 31);
            this.tghttb.TabIndex = 14;
            // 
            // lbtgchotb
            // 
            this.lbtgchotb.AutoSize = true;
            this.lbtgchotb.Location = new System.Drawing.Point(336, 292);
            this.lbtgchotb.Name = "lbtgchotb";
            this.lbtgchotb.Size = new System.Drawing.Size(0, 31);
            this.lbtgchotb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thời gian chờ trung bình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thời gian hoàn thành trung bình:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(653, 220);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên tiến trình";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời gian chờ";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thời gian hoàn thành";
            this.columnHeader6.Width = 210;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(16, 516);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1418, 87);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1448, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ROUNDROBIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lwinput;
        private System.Windows.Forms.Label lbtgden;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txBTen;
        private System.Windows.Forms.Label lbtgxuly;
        private System.Windows.Forms.Button btnaddtg;
        private System.Windows.Forms.Label lbQuarium;
        private System.Windows.Forms.TextBox txBquarium;
        private System.Windows.Forms.TextBox txtgden;
        private System.Windows.Forms.TextBox txBtgxuly;
        private System.Windows.Forms.Button BTSUMIT;
        private System.Windows.Forms.Button btnGant;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tghttb;
        private System.Windows.Forms.Label lbtgchotb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}

