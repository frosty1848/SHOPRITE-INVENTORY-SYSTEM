namespace SHOPRITE_INVENTORY_SYSTEM
{
    partial class USER_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.user_btn = new System.Windows.Forms.Button();
            this.reset_link = new System.Windows.Forms.LinkLabel();
            this.signup_link = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOPRITE USER LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(144, 144);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(211, 20);
            this.username_box.TabIndex = 3;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(146, 198);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(209, 20);
            this.password_box.TabIndex = 4;
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.Lime;
            this.user_btn.Location = new System.Drawing.Point(292, 283);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(75, 32);
            this.user_btn.TabIndex = 5;
            this.user_btn.Text = "SUBMIT";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset_link
            // 
            this.reset_link.AutoSize = true;
            this.reset_link.Location = new System.Drawing.Point(28, 288);
            this.reset_link.Name = "reset_link";
            this.reset_link.Size = new System.Drawing.Size(118, 13);
            this.reset_link.TabIndex = 6;
            this.reset_link.TabStop = true;
            this.reset_link.Text = "FORGOT PASSWORD";
            this.reset_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // signup_link
            // 
            this.signup_link.AutoSize = true;
            this.signup_link.Location = new System.Drawing.Point(28, 251);
            this.signup_link.Name = "signup_link";
            this.signup_link.Size = new System.Drawing.Size(51, 13);
            this.signup_link.TabIndex = 7;
            this.signup_link.TabStop = true;
            this.signup_link.Text = "SIGN UP";
            this.signup_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(300, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BACK TO ADMIN PAGE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // USER_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_link);
            this.Controls.Add(this.reset_link);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "USER_LOGIN";
            this.Text = "USER_LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.LinkLabel reset_link;
        private System.Windows.Forms.LinkLabel signup_link;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}