namespace RBSoft.Forms
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientPhnNo = new System.Windows.Forms.TextBox();
            this.billno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientDetails = new System.Windows.Forms.GroupBox();
            this.ShowTheOrder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.GetData = new System.Windows.Forms.Button();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetAmountCal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPriceValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRecordAndPrint = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.btnPrintOnly = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTheOrder)).BeginInit();
            this.grpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone No : ";
            // 
            // txtClientPhnNo
            // 
            this.txtClientPhnNo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtClientPhnNo.Location = new System.Drawing.Point(128, 78);
            this.txtClientPhnNo.Name = "txtClientPhnNo";
            this.txtClientPhnNo.ReadOnly = true;
            this.txtClientPhnNo.Size = new System.Drawing.Size(229, 20);
            this.txtClientPhnNo.TabIndex = 4;
            this.txtClientPhnNo.Text = "No Data";
            // 
            // billno
            // 
            this.billno.Location = new System.Drawing.Point(92, 142);
            this.billno.Name = "billno";
            this.billno.Size = new System.Drawing.Size(245, 20);
            this.billno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill No :";
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Cursor = System.Windows.Forms.Cursors.No;
            this.txtClientAddress.Location = new System.Drawing.Point(128, 119);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.ReadOnly = true;
            this.txtClientAddress.Size = new System.Drawing.Size(229, 20);
            this.txtClientAddress.TabIndex = 4;
            this.txtClientAddress.Text = "No Data";
            // 
            // txtClientName
            // 
            this.txtClientName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtClientName.Location = new System.Drawing.Point(128, 42);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(229, 20);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.Text = "No Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name :";
            // 
            // ClientDetails
            // 
            this.ClientDetails.Controls.Add(this.ShowTheOrder);
            this.ClientDetails.Controls.Add(this.label4);
            this.ClientDetails.Controls.Add(this.label3);
            this.ClientDetails.Controls.Add(this.label1);
            this.ClientDetails.Controls.Add(this.txtClientName);
            this.ClientDetails.Controls.Add(this.txtClientAddress);
            this.ClientDetails.Controls.Add(this.txtClientPhnNo);
            this.ClientDetails.Location = new System.Drawing.Point(8, 188);
            this.ClientDetails.Name = "ClientDetails";
            this.ClientDetails.Size = new System.Drawing.Size(401, 389);
            this.ClientDetails.TabIndex = 6;
            this.ClientDetails.TabStop = false;
            this.ClientDetails.Text = "Client Details";
            // 
            // ShowTheOrder
            // 
            this.ShowTheOrder.AllowUserToAddRows = false;
            this.ShowTheOrder.AllowUserToDeleteRows = false;
            this.ShowTheOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowTheOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowTheOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ShowTheOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowTheOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowTheOrder.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowTheOrder.Location = new System.Drawing.Point(6, 165);
            this.ShowTheOrder.Name = "ShowTheOrder";
            this.ShowTheOrder.ReadOnly = true;
            this.ShowTheOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ShowTheOrder.RowHeadersVisible = false;
            this.ShowTheOrder.Size = new System.Drawing.Size(389, 224);
            this.ShowTheOrder.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address : ";
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(362, 137);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(80, 28);
            this.GetData.TabIndex = 7;
            this.GetData.Text = "Proceed ";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.btn_Proceed);
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.txtDate);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Controls.Add(this.btnGetAmountCal);
            this.grpAccount.Controls.Add(this.label14);
            this.grpAccount.Controls.Add(this.txtPriceValue);
            this.grpAccount.Controls.Add(this.label12);
            this.grpAccount.Controls.Add(this.txtDue);
            this.grpAccount.Controls.Add(this.label10);
            this.grpAccount.Controls.Add(this.txtAmount);
            this.grpAccount.Controls.Add(this.label8);
            this.grpAccount.Controls.Add(this.txtPay);
            this.grpAccount.Location = new System.Drawing.Point(422, 188);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(386, 225);
            this.grpAccount.TabIndex = 8;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account";
            this.grpAccount.Enter += new System.EventHandler(this.grpAccount_Enter);
            // 
            // txtDate
            // 
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.Location = new System.Drawing.Point(136, 185);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(229, 20);
            this.txtDate.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date ";
            // 
            // btnGetAmountCal
            // 
            this.btnGetAmountCal.Location = new System.Drawing.Point(230, 28);
            this.btnGetAmountCal.Name = "btnGetAmountCal";
            this.btnGetAmountCal.Size = new System.Drawing.Size(135, 28);
            this.btnGetAmountCal.TabIndex = 22;
            this.btnGetAmountCal.Text = "Calculate";
            this.btnGetAmountCal.UseVisualStyleBackColor = true;
            this.btnGetAmountCal.Click += new System.EventHandler(this.btnGetAmount);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Per SFT Price : ";
            // 
            // txtPriceValue
            // 
            this.txtPriceValue.Location = new System.Drawing.Point(140, 32);
            this.txtPriceValue.Name = "txtPriceValue";
            this.txtPriceValue.Size = new System.Drawing.Size(80, 20);
            this.txtPriceValue.TabIndex = 20;
            this.txtPriceValue.Text = "20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Due : ";
            // 
            // txtDue
            // 
            this.txtDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDue.Location = new System.Drawing.Point(136, 147);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(229, 20);
            this.txtDue.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Amount : ";
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Location = new System.Drawing.Point(136, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(229, 20);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.Text = "Click Calculate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Payment : ";
            // 
            // txtPay
            // 
            this.txtPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPay.Location = new System.Drawing.Point(136, 110);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(229, 20);
            this.txtPay.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(422, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(386, 32);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Get Calculated ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRecordAndPrint
            // 
            this.btnRecordAndPrint.Location = new System.Drawing.Point(422, 464);
            this.btnRecordAndPrint.Name = "btnRecordAndPrint";
            this.btnRecordAndPrint.Size = new System.Drawing.Size(190, 63);
            this.btnRecordAndPrint.TabIndex = 10;
            this.btnRecordAndPrint.Text = "Record Data And Print";
            this.btnRecordAndPrint.UseVisualStyleBackColor = true;
            this.btnRecordAndPrint.Click += new System.EventHandler(this.btnRecordDataAndPrint);
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(422, 538);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(386, 31);
            this.btnGoback.TabIndex = 11;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // btnPrintOnly
            // 
            this.btnPrintOnly.Location = new System.Drawing.Point(618, 462);
            this.btnPrintOnly.Name = "btnPrintOnly";
            this.btnPrintOnly.Size = new System.Drawing.Size(190, 64);
            this.btnPrintOnly.TabIndex = 12;
            this.btnPrintOnly.Text = "Only Print Invoice";
            this.btnPrintOnly.UseVisualStyleBackColor = true;
            this.btnPrintOnly.Click += new System.EventHandler(this.btnOnlyInvoice);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReset);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Beta Version Not For Use";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 589);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrintOnly);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.btnRecordAndPrint);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.ClientDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccounts";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ClientDetails.ResumeLayout(false);
            this.ClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTheOrder)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientPhnNo;
        private System.Windows.Forms.TextBox billno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ClientDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ShowTheOrder;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Button btnGetAmountCal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPriceValue;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnRecordAndPrint;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnPrintOnly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}