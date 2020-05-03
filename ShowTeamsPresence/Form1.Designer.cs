namespace ShowTeamsPresence
{
    partial class Form1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserPresence = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPresence = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 7);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 22);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 7);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 22);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPresence
            // 
            this.lblUserPresence.AutoSize = true;
            this.lblUserPresence.Location = new System.Drawing.Point(14, 56);
            this.lblUserPresence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPresence.Name = "lblUserPresence";
            this.lblUserPresence.Size = new System.Drawing.Size(77, 13);
            this.lblUserPresence.TabIndex = 4;
            this.lblUserPresence.Text = "User Presence";
            // 
            // boxStatus
            // 
            this.boxStatus.Location = new System.Drawing.Point(33, 95);
            this.boxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(144, 130);
            this.boxStatus.TabIndex = 5;
            this.boxStatus.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(259, 9);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPresence
            // 
            this.txtPresence.Location = new System.Drawing.Point(234, 95);
            this.txtPresence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPresence.Multiline = true;
            this.txtPresence.Name = "txtPresence";
            this.txtPresence.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPresence.Size = new System.Drawing.Size(288, 265);
            this.txtPresence.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(259, 56);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 28);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 369);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtPresence);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.lblUserPresence);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserPresence;
        private System.Windows.Forms.PictureBox boxStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPresence;
        private System.Windows.Forms.Button btnRefresh;
    }
}

