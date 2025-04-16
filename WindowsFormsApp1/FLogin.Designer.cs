namespace WindowsFormsApp1
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.buttLogin = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 33);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(966, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "--";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttExit
            // 
            this.buttExit.FlatAppearance.BorderSize = 0;
            this.buttExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttExit.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.buttExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttExit.Location = new System.Drawing.Point(1017, 0);
            this.buttExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(47, 33);
            this.buttExit.TabIndex = 0;
            this.buttExit.Text = " X";
            this.buttExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(631, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng Nhập";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbUser);
            this.panel4.Location = new System.Drawing.Point(415, 130);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 71);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txbUser
            // 
            this.txbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbUser.Font = new System.Drawing.Font("Arial", 13F);
            this.txbUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbUser.Location = new System.Drawing.Point(271, 22);
            this.txbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(306, 32);
            this.txbUser.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txbPassWord);
            this.panel5.Location = new System.Drawing.Point(415, 231);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 71);
            this.panel5.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txbPassWord
            // 
            this.txbPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbPassWord.Font = new System.Drawing.Font("Arial", 13F);
            this.txbPassWord.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbPassWord.Location = new System.Drawing.Point(271, 20);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(306, 32);
            this.txbPassWord.TabIndex = 0;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // buttLogin
            // 
            this.buttLogin.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.buttLogin.FlatAppearance.BorderSize = 3;
            this.buttLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.buttLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttLogin.Location = new System.Drawing.Point(789, 338);
            this.buttLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttLogin.Name = "buttLogin";
            this.buttLogin.Size = new System.Drawing.Size(222, 44);
            this.buttLogin.TabIndex = 8;
            this.buttLogin.Text = "Đăng nhập";
            this.buttLogin.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(342, 431);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 467);
            this.ControlBox = false;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.buttLogin);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Button buttLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

