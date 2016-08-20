namespace RBSoft.Forms
{
    partial class frmEdit_frmEditAccountData
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
            this.ShowBuyData = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPreAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreDue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrvSft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTodayDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNewPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBuyData)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowBuyData
            // 
            this.ShowBuyData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ShowBuyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowBuyData.GridColor = System.Drawing.SystemColors.Control;
            this.ShowBuyData.Location = new System.Drawing.Point(12, 300);
            this.ShowBuyData.Name = "ShowBuyData";
            this.ShowBuyData.Size = new System.Drawing.Size(777, 194);
            this.ShowBuyData.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(178, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(204, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(178, 151);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.ReadOnly = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phone Number : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 109);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name : ";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(38, 52);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(217, 20);
            this.txtSearchKey.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 30);
            this.button3.TabIndex = 28;
            this.button3.Text = "Search Data By BillNo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Search_By_BillNo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack_EditMenu);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Update Account Data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "UPDATE DATA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_updateAccountData);
            // 
            // txtPreAmount
            // 
            this.txtPreAmount.Location = new System.Drawing.Point(554, 109);
            this.txtPreAmount.Name = "txtPreAmount";
            this.txtPreAmount.ReadOnly = true;
            this.txtPreAmount.Size = new System.Drawing.Size(204, 20);
            this.txtPreAmount.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Amount :";
            // 
            // txtPerPay
            // 
            this.txtPerPay.Location = new System.Drawing.Point(554, 146);
            this.txtPerPay.Name = "txtPerPay";
            this.txtPerPay.ReadOnly = true;
            this.txtPerPay.Size = new System.Drawing.Size(204, 20);
            this.txtPerPay.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Payment :";
            // 
            // txtPreDue
            // 
            this.txtPreDue.Location = new System.Drawing.Point(554, 184);
            this.txtPreDue.Name = "txtPreDue";
            this.txtPreDue.ReadOnly = true;
            this.txtPreDue.Size = new System.Drawing.Size(204, 20);
            this.txtPreDue.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Due :";
            // 
            // txtPrvSft
            // 
            this.txtPrvSft.Location = new System.Drawing.Point(554, 220);
            this.txtPrvSft.Name = "txtPrvSft";
            this.txtPrvSft.ReadOnly = true;
            this.txtPrvSft.Size = new System.Drawing.Size(204, 20);
            this.txtPrvSft.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Per Sft Price :";
            // 
            // txtTodayDate
            // 
            this.txtTodayDate.Location = new System.Drawing.Point(177, 225);
            this.txtTodayDate.Name = "txtTodayDate";
            this.txtTodayDate.ReadOnly = true;
            this.txtTodayDate.Size = new System.Drawing.Size(204, 20);
            this.txtTodayDate.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Today Date :";
            // 
            // TxtNewPay
            // 
            this.TxtNewPay.Location = new System.Drawing.Point(554, 256);
            this.TxtNewPay.Name = "TxtNewPay";
            this.TxtNewPay.Size = new System.Drawing.Size(204, 20);
            this.TxtNewPay.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Today Pay :";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Location = new System.Drawing.Point(177, 257);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.ReadOnly = true;
            this.txtLastUpdate.Size = new System.Drawing.Size(204, 20);
            this.txtLastUpdate.TabIndex = 43;
            this.txtLastUpdate.Text = "No Previous Update";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Last Update";
            // 
            // frmEdit_frmEditAccountData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 550);
            this.Controls.Add(this.txtLastUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtNewPay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTodayDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrvSft);
            this.Controls.Add(this.txtPreDue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPerPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPreAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowBuyData);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Name = "frmEdit_frmEditAccountData";
            this.Text = "frmEdit_frmEditAccountData";
            ((System.ComponentModel.ISupportInitialize)(this.ShowBuyData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowBuyData;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPreAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrvSft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTodayDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNewPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label label11;
    }
}