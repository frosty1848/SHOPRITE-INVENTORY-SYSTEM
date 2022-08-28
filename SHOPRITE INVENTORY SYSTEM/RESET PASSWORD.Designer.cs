namespace SHOPRITE_INVENTORY_SYSTEM
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nw_password_box = new System.Windows.Forms.TextBox();
            this.reset_password_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RETYPE PASSWORD:";
            // 
            // nw_password_box
            // 
            this.nw_password_box.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nw_password_box.Location = new System.Drawing.Point(144, 36);
            this.nw_password_box.Name = "nw_password_box";
            this.nw_password_box.Size = new System.Drawing.Size(220, 20);
            this.nw_password_box.TabIndex = 2;
            this.nw_password_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reset_password_box
            // 
            this.reset_password_box.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reset_password_box.Location = new System.Drawing.Point(144, 93);
            this.reset_password_box.Name = "reset_password_box";
            this.reset_password_box.Size = new System.Drawing.Size(220, 20);
            this.reset_password_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(289, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset_password_box);
            this.Controls.Add(this.nw_password_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nw_password_box;
        private System.Windows.Forms.TextBox reset_password_box;
        private System.Windows.Forms.Button button1;
    }
}