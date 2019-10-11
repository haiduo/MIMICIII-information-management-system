namespace MIMIC
{
    partial class FrmRegister
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.IbIPwd = new System.Windows.Forms.Label();
            this.lbIUser = new System.Windows.Forms.Label();
            this.lblIp_addr = new System.Windows.Forms.Label();
            this.lblMac_addr = new System.Windows.Forms.Label();
            this.txtIp_addr = new System.Windows.Forms.TextBox();
            this.txtMac_addr = new System.Windows.Forms.TextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(131, 69);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(177, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(131, 26);
            this.txtUser.MaxLength = 12;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(177, 20);
            this.txtUser.TabIndex = 0;
            // 
            // IbIPwd
            // 
            this.IbIPwd.AutoSize = true;
            this.IbIPwd.BackColor = System.Drawing.Color.Transparent;
            this.IbIPwd.Location = new System.Drawing.Point(69, 72);
            this.IbIPwd.Name = "IbIPwd";
            this.IbIPwd.Size = new System.Drawing.Size(31, 13);
            this.IbIPwd.TabIndex = 12;
            this.IbIPwd.Text = "密码";
            // 
            // lbIUser
            // 
            this.lbIUser.AutoSize = true;
            this.lbIUser.BackColor = System.Drawing.Color.Transparent;
            this.lbIUser.Location = new System.Drawing.Point(69, 29);
            this.lbIUser.Name = "lbIUser";
            this.lbIUser.Size = new System.Drawing.Size(43, 13);
            this.lbIUser.TabIndex = 11;
            this.lbIUser.Text = "用户名";
            // 
            // lblIp_addr
            // 
            this.lblIp_addr.AutoSize = true;
            this.lblIp_addr.BackColor = System.Drawing.Color.Transparent;
            this.lblIp_addr.Location = new System.Drawing.Point(69, 115);
            this.lblIp_addr.Name = "lblIp_addr";
            this.lblIp_addr.Size = new System.Drawing.Size(41, 13);
            this.lblIp_addr.TabIndex = 11;
            this.lblIp_addr.Text = "限制IP";
            // 
            // lblMac_addr
            // 
            this.lblMac_addr.AutoSize = true;
            this.lblMac_addr.BackColor = System.Drawing.Color.Transparent;
            this.lblMac_addr.Location = new System.Drawing.Point(69, 158);
            this.lblMac_addr.Name = "lblMac_addr";
            this.lblMac_addr.Size = new System.Drawing.Size(54, 13);
            this.lblMac_addr.TabIndex = 12;
            this.lblMac_addr.Text = "限制MAC";
            // 
            // txtIp_addr
            // 
            this.txtIp_addr.Location = new System.Drawing.Point(131, 112);
            this.txtIp_addr.MaxLength = 13;
            this.txtIp_addr.Name = "txtIp_addr";
            this.txtIp_addr.Size = new System.Drawing.Size(177, 20);
            this.txtIp_addr.TabIndex = 2;
            // 
            // txtMac_addr
            // 
            this.txtMac_addr.Location = new System.Drawing.Point(131, 155);
            this.txtMac_addr.MaxLength = 12;
            this.txtMac_addr.Name = "txtMac_addr";
            this.txtMac_addr.PasswordChar = '*';
            this.txtMac_addr.Size = new System.Drawing.Size(177, 20);
            this.txtMac_addr.TabIndex = 3;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(233, 230);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "取  消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(131, 230);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtMac_addr);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtIp_addr);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblMac_addr);
            this.Controls.Add(this.IbIPwd);
            this.Controls.Add(this.lblIp_addr);
            this.Controls.Add(this.lbIUser);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label IbIPwd;
        private System.Windows.Forms.Label lbIUser;
        private System.Windows.Forms.Label lblIp_addr;
        private System.Windows.Forms.Label lblMac_addr;
        private System.Windows.Forms.TextBox txtIp_addr;
        private System.Windows.Forms.TextBox txtMac_addr;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnRegister;
    }
}