namespace RBSoft.Forms
{
    partial class frmSearchData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchData));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllDataShowGridView = new System.Windows.Forms.DataGridView();
            this.OnlyBillNoShowGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllDataShowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlyBillNoShowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Data";
            // 
            // SearchTypeComboBox
            // 
            this.SearchTypeComboBox.FormattingEnabled = true;
            this.SearchTypeComboBox.Items.AddRange(new object[] {
            "All Data Search",
            "Bill Only"});
            this.SearchTypeComboBox.Location = new System.Drawing.Point(215, 193);
            this.SearchTypeComboBox.Name = "SearchTypeComboBox";
            this.SearchTypeComboBox.Size = new System.Drawing.Size(440, 21);
            this.SearchTypeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select What you Search : ";
            // 
            // AllDataShowGridView
            // 
            this.AllDataShowGridView.AllowUserToAddRows = false;
            this.AllDataShowGridView.AllowUserToDeleteRows = false;
            this.AllDataShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDataShowGridView.Location = new System.Drawing.Point(12, 245);
            this.AllDataShowGridView.Name = "AllDataShowGridView";
            this.AllDataShowGridView.ReadOnly = true;
            this.AllDataShowGridView.Size = new System.Drawing.Size(915, 332);
            this.AllDataShowGridView.TabIndex = 3;
            // 
            // OnlyBillNoShowGrid
            // 
            this.OnlyBillNoShowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OnlyBillNoShowGrid.Location = new System.Drawing.Point(12, 245);
            this.OnlyBillNoShowGrid.Name = "OnlyBillNoShowGrid";
            this.OnlyBillNoShowGrid.Size = new System.Drawing.Size(155, 332);
            this.OnlyBillNoShowGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSearchClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 586);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(915, 40);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back ";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // frmSearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 630);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OnlyBillNoShowGrid);
            this.Controls.Add(this.AllDataShowGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchData";
            this.Text = "frmSearchData";
            ((System.ComponentModel.ISupportInitialize)(this.AllDataShowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlyBillNoShowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AllDataShowGridView;
        private System.Windows.Forms.DataGridView OnlyBillNoShowGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBack;
    }
}