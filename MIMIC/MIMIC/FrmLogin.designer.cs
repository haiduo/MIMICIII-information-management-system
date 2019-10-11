namespace MIMIC
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.IbIPwd = new System.Windows.Forms.Label();
            this.lbIUser = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(466, 148);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(177, 20);
            this.txtPwd.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(466, 100);
            this.txtUser.MaxLength = 12;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(177, 20);
            this.txtUser.TabIndex = 4;
            // 
            // IbIPwd
            // 
            this.IbIPwd.AutoSize = true;
            this.IbIPwd.BackColor = System.Drawing.Color.Transparent;
            this.IbIPwd.Location = new System.Drawing.Point(411, 148);
            this.IbIPwd.Name = "IbIPwd";
            this.IbIPwd.Size = new System.Drawing.Size(31, 13);
            this.IbIPwd.TabIndex = 8;
            this.IbIPwd.Text = "密码";
            // 
            // lbIUser
            // 
            this.lbIUser.AutoSize = true;
            this.lbIUser.BackColor = System.Drawing.Color.Transparent;
            this.lbIUser.Location = new System.Drawing.Point(411, 104);
            this.lbIUser.Name = "lbIUser";
            this.lbIUser.Size = new System.Drawing.Size(43, 13);
            this.lbIUser.TabIndex = 6;
            this.lbIUser.Text = "用户名";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(568, 219);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "取  消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click_1);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(466, 219);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "  登  录";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click_1);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegister.Location = new System.Drawing.Point(411, 224);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(31, 13);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "注册";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(674, 398);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.IbIPwd);
            this.Controls.Add(this.lbIUser);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "登录";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label IbIPwd;
        private System.Windows.Forms.Label lbIUser;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.LinkLabel lblRegister;
    }
}

