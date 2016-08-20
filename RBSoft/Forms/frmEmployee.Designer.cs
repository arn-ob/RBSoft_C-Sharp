namespace RBSoft.Forms
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Show_User = new System.Windows.Forms.Button();
            this.btn_Edit_User = new System.Windows.Forms.Button();
            this.btnCreate_User = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Location = new System.Drawing.Point(503, 185);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(125, 113);
            this.btn_Delete_User.TabIndex = 8;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            // 
            // btn_Show_User
            // 
            this.btn_Show_User.Location = new System.Drawing.Point(355, 185);
            this.btn_Show_User.Name = "btn_Show_User";
            this.btn_Show_User.Size = new System.Drawing.Size(125, 113);
            this.btn_Show_User.TabIndex = 7;
            this.btn_Show_User.Text = "Edit  Data";
            this.btn_Show_User.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_User
            // 
            this.btn_Edit_User.Location = new System.Drawing.Point(209, 185);
            this.btn_Edit_User.Name = "btn_Edit_User";
            this.btn_Edit_User.Size = new System.Drawing.Size(125, 113);
            this.btn_Edit_User.TabIndex = 6;
            this.btn_Edit_User.Text = "Edit User";
            this.btn_Edit_User.UseVisualStyleBackColor = true;
            // 
            // btnCreate_User
            // 
            this.btnCreate_User.Location = new System.Drawing.Point(62, 185);
            this.btnCreate_User.Name = "btnCreate_User";
            this.btnCreate_User.Size = new System.Drawing.Size(125, 113);
            this.btnCreate_User.TabIndex = 5;
            this.btnCreate_User.Text = "Create User";
            this.btnCreate_User.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.btn_Show_User);
            this.Controls.Add(this.btn_Edit_User);
            this.Controls.Add(this.btnCreate_User);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Show_User;
        private System.Windows.Forms.Button btn_Edit_User;
        private System.Windows.Forms.Button btnCreate_User;
        private System.Windows.Forms.Button button1;
    }
}