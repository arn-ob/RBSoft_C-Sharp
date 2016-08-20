namespace RBSoft.Forms
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.btn_Edit_clientData = new System.Windows.Forms.Button();
            this.btn_Account_Data = new System.Windows.Forms.Button();
            this.btn_Employee_Data = new System.Windows.Forms.Button();
            this.btn_print_Data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Edit_clientData
            // 
            this.btn_Edit_clientData.Location = new System.Drawing.Point(27, 192);
            this.btn_Edit_clientData.Name = "btn_Edit_clientData";
            this.btn_Edit_clientData.Size = new System.Drawing.Size(125, 113);
            this.btn_Edit_clientData.TabIndex = 0;
            this.btn_Edit_clientData.Text = "Edit Client Data";
            this.btn_Edit_clientData.UseVisualStyleBackColor = true;
            this.btn_Edit_clientData.Click += new System.EventHandler(this.btn_EditClientDATA);
            // 
            // btn_Account_Data
            // 
            this.btn_Account_Data.Location = new System.Drawing.Point(174, 192);
            this.btn_Account_Data.Name = "btn_Account_Data";
            this.btn_Account_Data.Size = new System.Drawing.Size(125, 113);
            this.btn_Account_Data.TabIndex = 1;
            this.btn_Account_Data.Text = "Edit Account Data";
            this.btn_Account_Data.UseVisualStyleBackColor = true;
            // 
            // btn_Employee_Data
            // 
            this.btn_Employee_Data.Location = new System.Drawing.Point(320, 192);
            this.btn_Employee_Data.Name = "btn_Employee_Data";
            this.btn_Employee_Data.Size = new System.Drawing.Size(125, 113);
            this.btn_Employee_Data.TabIndex = 2;
            this.btn_Employee_Data.Text = "Edit Employee Data";
            this.btn_Employee_Data.UseVisualStyleBackColor = true;
            // 
            // btn_print_Data
            // 
            this.btn_print_Data.Location = new System.Drawing.Point(468, 192);
            this.btn_print_Data.Name = "btn_print_Data";
            this.btn_print_Data.Size = new System.Drawing.Size(125, 113);
            this.btn_print_Data.TabIndex = 3;
            this.btn_print_Data.Text = "Print Data";
            this.btn_print_Data.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 350);
            this.Controls.Add(this.btn_print_Data);
            this.Controls.Add(this.btn_Employee_Data);
            this.Controls.Add(this.btn_Account_Data);
            this.Controls.Add(this.btn_Edit_clientData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.Text = "Edit Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit_clientData;
        private System.Windows.Forms.Button btn_Account_Data;
        private System.Windows.Forms.Button btn_Employee_Data;
        private System.Windows.Forms.Button btn_print_Data;
    }
}