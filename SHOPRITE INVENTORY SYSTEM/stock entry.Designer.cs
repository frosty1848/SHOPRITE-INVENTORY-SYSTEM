namespace SHOPRITE_INVENTORY_SYSTEM
{
    partial class stock_entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_entry));
            this.Points_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Stock_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SUBMIT_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Points_box
            // 
            this.Points_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Points_box.Location = new System.Drawing.Point(237, 133);
            this.Points_box.Name = "Points_box";
            this.Points_box.Size = new System.Drawing.Size(158, 20);
            this.Points_box.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "STOCK POINTS:";
            // 
            // Stock_box
            // 
            this.Stock_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stock_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Stock_box.Location = new System.Drawing.Point(237, 67);
            this.Stock_box.Name = "Stock_box";
            this.Stock_box.Size = new System.Drawing.Size(158, 20);
            this.Stock_box.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(138, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "STOCK NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "STOCK  ENTRY";
            // 
            // SUBMIT_btn
            // 
            this.SUBMIT_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.SUBMIT_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SUBMIT_btn.Location = new System.Drawing.Point(320, 173);
            this.SUBMIT_btn.Name = "SUBMIT_btn";
            this.SUBMIT_btn.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT_btn.TabIndex = 12;
            this.SUBMIT_btn.Text = "SUBMIT";
            this.SUBMIT_btn.UseVisualStyleBackColor = false;
            this.SUBMIT_btn.Click += new System.EventHandler(this.SUBMIT_btn_Click);
            // 
            // stock_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 225);
            this.Controls.Add(this.SUBMIT_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Points_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stock_box);
            this.Controls.Add(this.label2);
            this.Name = "stock_entry";
            this.Text = "stock_entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Points_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Stock_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SUBMIT_btn;
    }
}