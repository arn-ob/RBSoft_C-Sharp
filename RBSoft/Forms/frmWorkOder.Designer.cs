namespace RBSoft.Forms
{
    partial class frmWorkOder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialIDLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MediaComBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.txtWide = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSft = new System.Windows.Forms.TextBox();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StatusComBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Media = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.particular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.DataShow = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BrowseImage = new System.Windows.Forms.Button();
            this.samplePic = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProceedToPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 198);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 235);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 61);
            this.txtAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(121, 316);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(229, 20);
            this.txtMobile.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mobile :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bill No :";
            // 
            // serialIDLable
            // 
            this.serialIDLable.AutoSize = true;
            this.serialIDLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialIDLable.Location = new System.Drawing.Point(92, 143);
            this.serialIDLable.Name = "serialIDLable";
            this.serialIDLable.Size = new System.Drawing.Size(301, 20);
            this.serialIDLable.TabIndex = 8;
            this.serialIDLable.Text = "ID Not Generated Check Lan Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Media : ";
            // 
            // MediaComBox
            // 
            this.MediaComBox.FormattingEnabled = true;
            this.MediaComBox.Items.AddRange(new object[] {
            "PVC",
            "Pana",
            "Stiker",
            "Other"});
            this.MediaComBox.Location = new System.Drawing.Point(97, 424);
            this.MediaComBox.Name = "MediaComBox";
            this.MediaComBox.Size = new System.Drawing.Size(180, 21);
            this.MediaComBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height";
            // 
            // txtHight
            // 
            this.txtHight.Location = new System.Drawing.Point(95, 468);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(77, 20);
            this.txtHight.TabIndex = 12;
            // 
            // txtWide
            // 
            this.txtWide.Location = new System.Drawing.Point(241, 470);
            this.txtWide.Name = "txtWide";
            this.txtWide.Size = new System.Drawing.Size(77, 20);
            this.txtWide.TabIndex = 12;
            this.txtWide.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Wide";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "SFT";
            // 
            // txtSft
            // 
            this.txtSft.Location = new System.Drawing.Point(246, 516);
            this.txtSft.Name = "txtSft";
            this.txtSft.Size = new System.Drawing.Size(77, 20);
            this.txtSft.TabIndex = 14;
            this.txtSft.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtQnt
            // 
            this.txtQnt.Location = new System.Drawing.Point(105, 515);
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(77, 20);
            this.txtQnt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity :";
            // 
            // StatusComBox
            // 
            this.StatusComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusComBox.FormattingEnabled = true;
            this.StatusComBox.Items.AddRange(new object[] {
            "Ready",
            "Not Ready ",
            "Working",
            "Design In Progress"});
            this.StatusComBox.Location = new System.Drawing.Point(135, 581);
            this.StatusComBox.Name = "StatusComBox";
            this.StatusComBox.Size = new System.Drawing.Size(188, 28);
            this.StatusComBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Status :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 238);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Details";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.billNo,
            this.name,
            this.Media,
            this.size,
            this.qnt,
            this.particular,
            this.status});
            this.listView1.Location = new System.Drawing.Point(370, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 203);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // billNo
            // 
            this.billNo.Text = "Bill No";
            this.billNo.Width = 80;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // Media
            // 
            this.Media.Text = "Print Media";
            this.Media.Width = 70;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 40;
            // 
            // qnt
            // 
            this.qnt.Text = "Quantity";
            // 
            // particular
            // 
            this.particular.Text = "Particular";
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(484, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Date :";
            // 
            // DataShow
            // 
            this.DataShow.AutoSize = true;
            this.DataShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow.Location = new System.Drawing.Point(542, 143);
            this.DataShow.Name = "DataShow";
            this.DataShow.Size = new System.Drawing.Size(92, 20);
            this.DataShow.TabIndex = 21;
            this.DataShow.Text = "Show Date ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(366, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Print Summary";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(370, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Print Image Picture :";
            // 
            // BrowseImage
            // 
            this.BrowseImage.Location = new System.Drawing.Point(523, 440);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Size = new System.Drawing.Size(71, 27);
            this.BrowseImage.TabIndex = 24;
            this.BrowseImage.Text = "Browse";
            this.BrowseImage.UseVisualStyleBackColor = true;
            // 
            // samplePic
            // 
            this.samplePic.Location = new System.Drawing.Point(370, 474);
            this.samplePic.Name = "samplePic";
            this.samplePic.Size = new System.Drawing.Size(435, 149);
            this.samplePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.samplePic.TabIndex = 25;
            this.samplePic.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 27;
            this.button3.Text = "Add To Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 640);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 28;
            this.button4.Text = "Clear Print List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProceedToPrint
            // 
            this.ProceedToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedToPrint.Location = new System.Drawing.Point(667, 640);
            this.ProceedToPrint.Name = "ProceedToPrint";
            this.ProceedToPrint.Size = new System.Drawing.Size(138, 46);
            this.ProceedToPrint.TabIndex = 29;
            this.ProceedToPrint.Text = "Proceed To Print";
            this.ProceedToPrint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear Everything";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearEveryThing);
            // 
            // frmWorkOder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 698);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProceedToPrint);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.samplePic);
            this.Controls.Add(this.BrowseImage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.StatusComBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWide);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.MediaComBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serialIDLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWorkOder";
            this.Text = "Work Oder";
            this.Load += new System.EventHandler(this.frmWorkOder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label serialIDLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MediaComBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.TextBox txtWide;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSft;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox StatusComBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader billNo;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DataShow;
        private System.Windows.Forms.ColumnHeader Media;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader qnt;
        private System.Windows.Forms.ColumnHeader particular;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BrowseImage;
        private System.Windows.Forms.PictureBox samplePic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ProceedToPrint;
        private System.Windows.Forms.Button button1;
    }
}