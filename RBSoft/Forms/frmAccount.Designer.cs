namespace RBSoft.Forms
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
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
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPriceValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.ShowTheOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ShowTheOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowTheOrder.ColumnHeadersVisible = false;
            this.ShowTheOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowTheOrder.Location = new System.Drawing.Point(6, 165);
            this.ShowTheOrder.Name = "ShowTheOrder";
            this.ShowTheOrder.ReadOnly = true;
            this.ShowTheOrder.Size = new System.Drawing.Size(389, 195);
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
            this.grpAccount.Controls.Add(this.textBox1);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Controls.Add(this.button1);
            this.grpAccount.Controls.Add(this.label14);
            this.grpAccount.Controls.Add(this.txtPriceValue);
            this.grpAccount.Controls.Add(this.label13);
            this.grpAccount.Controls.Add(this.textBox12);
            this.grpAccount.Controls.Add(this.label12);
            this.grpAccount.Controls.Add(this.txtDue);
            this.grpAccount.Controls.Add(this.label10);
            this.grpAccount.Controls.Add(this.txtAmount);
            this.grpAccount.Controls.Add(this.label9);
            this.grpAccount.Controls.Add(this.txtAdvance);
            this.grpAccount.Controls.Add(this.label8);
            this.grpAccount.Controls.Add(this.txtPay);
            this.grpAccount.Location = new System.Drawing.Point(422, 188);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(386, 340);
            this.grpAccount.TabIndex = 8;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total";
            // 
            // textBox12
            // 
            this.textBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox12.Location = new System.Drawing.Point(136, 226);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(229, 20);
            this.textBox12.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Due : ";
            // 
            // txtDue
            // 
            this.txtDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDue.Location = new System.Drawing.Point(136, 189);
            this.txtDue.Name = "txtDue";
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Advance : ";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdvance.Location = new System.Drawing.Point(136, 111);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(229, 20);
            this.txtAdvance.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Payment : ";
            // 
            // txtPay
            // 
            this.txtPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPay.Location = new System.Drawing.Point(136, 152);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(229, 20);
            this.txtPay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date ";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(136, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 24;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 589);
            this.ControlBox = false;
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.ClientDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccount";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPriceValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}