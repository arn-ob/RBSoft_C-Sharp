namespace RBSoft.Forms
{
    partial class frmPrintWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintWork));
            this.ShowDataGridView = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMediaType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediaHight = new System.Windows.Forms.TextBox();
            this.txtMediaWide = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediaSft = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMediaFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MediaPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillNO = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubBillNO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusComboBx = new System.Windows.Forms.ComboBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowDataGridView
            // 
            this.ShowDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView.Location = new System.Drawing.Point(12, 57);
            this.ShowDataGridView.Name = "ShowDataGridView";
            this.ShowDataGridView.Size = new System.Drawing.Size(447, 482);
            this.ShowDataGridView.TabIndex = 0;
            this.ShowDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.btnShowData);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(563, 54);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtMediaType
            // 
            this.txtMediaType.Location = new System.Drawing.Point(563, 82);
            this.txtMediaType.Name = "txtMediaType";
            this.txtMediaType.ReadOnly = true;
            this.txtMediaType.Size = new System.Drawing.Size(187, 20);
            this.txtMediaType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Media Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Media Height :";
            // 
            // txtMediaHight
            // 
            this.txtMediaHight.Location = new System.Drawing.Point(563, 111);
            this.txtMediaHight.Name = "txtMediaHight";
            this.txtMediaHight.ReadOnly = true;
            this.txtMediaHight.Size = new System.Drawing.Size(187, 20);
            this.txtMediaHight.TabIndex = 5;
            // 
            // txtMediaWide
            // 
            this.txtMediaWide.Location = new System.Drawing.Point(563, 143);
            this.txtMediaWide.Name = "txtMediaWide";
            this.txtMediaWide.ReadOnly = true;
            this.txtMediaWide.Size = new System.Drawing.Size(187, 20);
            this.txtMediaWide.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Media Wide :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Media SFT :";
            // 
            // txtMediaSft
            // 
            this.txtMediaSft.Location = new System.Drawing.Point(563, 174);
            this.txtMediaSft.Name = "txtMediaSft";
            this.txtMediaSft.ReadOnly = true;
            this.txtMediaSft.Size = new System.Drawing.Size(187, 20);
            this.txtMediaSft.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Media FileName :";
            // 
            // txtMediaFileName
            // 
            this.txtMediaFileName.Location = new System.Drawing.Point(576, 204);
            this.txtMediaFileName.Name = "txtMediaFileName";
            this.txtMediaFileName.ReadOnly = true;
            this.txtMediaFileName.Size = new System.Drawing.Size(174, 20);
            this.txtMediaFileName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Media Picture :";
            // 
            // MediaPicture
            // 
            this.MediaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MediaPicture.Location = new System.Drawing.Point(484, 345);
            this.MediaPicture.Name = "MediaPicture";
            this.MediaPicture.Size = new System.Drawing.Size(287, 194);
            this.MediaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MediaPicture.TabIndex = 15;
            this.MediaPicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBillNO);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(777, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 258);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Option";
            // 
            // txtBillNO
            // 
            this.txtBillNO.Location = new System.Drawing.Point(6, 132);
            this.txtBillNO.Name = "txtBillNO";
            this.txtBillNO.Size = new System.Drawing.Size(126, 20);
            this.txtBillNO.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search By SubBillNO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSearchBySubBillNo);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Search By BillNO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnSearchByBill);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRefresh);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPreious);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Today Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTodayPrint);
            // 
            // txtSubBillNO
            // 
            this.txtSubBillNO.Location = new System.Drawing.Point(783, 251);
            this.txtSubBillNO.Name = "txtSubBillNO";
            this.txtSubBillNO.Size = new System.Drawing.Size(126, 20);
            this.txtSubBillNO.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Print Status : ";
            // 
            // StatusComboBx
            // 
            this.StatusComboBx.FormattingEnabled = true;
            this.StatusComboBx.Items.AddRange(new object[] {
            "Printing",
            "Done"});
            this.StatusComboBx.Location = new System.Drawing.Point(576, 243);
            this.StatusComboBx.Name = "StatusComboBx";
            this.StatusComboBx.Size = new System.Drawing.Size(174, 21);
            this.StatusComboBx.TabIndex = 18;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(484, 278);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(266, 34);
            this.btnUpdateRecord.TabIndex = 19;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(792, 498);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(125, 41);
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btn_GoBack);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Beta Version Not For Use";
            // 
            // frmPrintWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(929, 557);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.StatusComboBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubBillNO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MediaPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMediaFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediaSft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediaWide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediaHight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMediaType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ShowDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintWork";
            this.Text = "frmPrintWork";
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowDataGridView;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMediaType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMediaHight;
        private System.Windows.Forms.TextBox txtMediaWide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMediaSft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMediaFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox MediaPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBillNO;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubBillNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StatusComboBx;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label9;
    }
}