namespace GCClient.WindowApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserPassWord = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblOk = new DevExpress.XtraEditors.LabelControl();
            this.lblCancle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(292, 270);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(238)))));
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Properties.Appearance.Options.UseBackColor = true;
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.Appearance.Options.UseForeColor = true;
            this.txtUserName.Properties.AutoHeight = false;
            this.txtUserName.Size = new System.Drawing.Size(252, 49);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.EditValueChanged += new System.EventHandler(this.txtUserName_EditValueChanged);
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // txtUserPassWord
            // 
            this.txtUserPassWord.EditValue = "";
            this.txtUserPassWord.Location = new System.Drawing.Point(292, 359);
            this.txtUserPassWord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserPassWord.Name = "txtUserPassWord";
            this.txtUserPassWord.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(238)))));
            this.txtUserPassWord.Properties.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassWord.Properties.Appearance.Options.UseBackColor = true;
            this.txtUserPassWord.Properties.Appearance.Options.UseFont = true;
            this.txtUserPassWord.Properties.AutoHeight = false;
            this.txtUserPassWord.Properties.PasswordChar = '*';
            this.txtUserPassWord.Size = new System.Drawing.Size(252, 49);
            this.txtUserPassWord.TabIndex = 2;
            this.txtUserPassWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserPassWord_KeyUp);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(808, 500);
            this.pictureEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(169, 279);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = " 登 录 名 ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(169, 368);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = " 密     码 ";
            // 
            // lblOk
            // 
            this.lblOk.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOk.Appearance.Options.UseFont = true;
            this.lblOk.Appearance.Options.UseForeColor = true;
            this.lblOk.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblOk.Location = new System.Drawing.Point(198, 451);
            this.lblOk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(74, 31);
            this.lblOk.TabIndex = 10;
            this.lblOk.Text = " 登 录 ";
            this.lblOk.Click += new System.EventHandler(this.lblOk_Click);
            // 
            // lblCancle
            // 
            this.lblCancle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCancle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCancle.Appearance.Options.UseFont = true;
            this.lblCancle.Appearance.Options.UseForeColor = true;
            this.lblCancle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCancle.Location = new System.Drawing.Point(385, 451);
            this.lblCancle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblCancle.Name = "lblCancle";
            this.lblCancle.Size = new System.Drawing.Size(74, 31);
            this.lblCancle.TabIndex = 11;
            this.lblCancle.Text = " 取 消 ";
            this.lblCancle.Click += new System.EventHandler(this.lblCancle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(150, 108);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(582, 72);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "成  本  管  理  系  统  ";
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(808, 500);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblCancle);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUserPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 540);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成本核算报价系统";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtUserPassWord;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblOk;
        private DevExpress.XtraEditors.LabelControl lblCancle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}