namespace Bensa_Automaatti
{
    partial class TilausIkkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TilausIkkuna));
            this.Tilausnappi = new System.Windows.Forms.Button();
            this.maara_updown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.diesel_box = new System.Windows.Forms.RadioButton();
            this.ysiviis_box = new System.Windows.Forms.RadioButton();
            this.ysikasi_box = new System.Windows.Forms.RadioButton();
            this.viesti_label = new System.Windows.Forms.Label();
            this.sulje_nappi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maara_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // Tilausnappi
            // 
            this.Tilausnappi.Location = new System.Drawing.Point(23, 124);
            this.Tilausnappi.Name = "Tilausnappi";
            this.Tilausnappi.Size = new System.Drawing.Size(75, 23);
            this.Tilausnappi.TabIndex = 0;
            this.Tilausnappi.Text = "Beställa";
            this.Tilausnappi.UseVisualStyleBackColor = true;
            // 
            // maara_updown
            // 
            this.maara_updown.Location = new System.Drawing.Point(23, 81);
            this.maara_updown.Name = "maara_updown";
            this.maara_updown.Size = new System.Drawing.Size(55, 20);
            this.maara_updown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välja vilken typ vill du beställa.\r\nDärefter trycka på Beställa-knappen.";
            // 
            // diesel_box
            // 
            this.diesel_box.AutoSize = true;
            this.diesel_box.Checked = true;
            this.diesel_box.Location = new System.Drawing.Point(13, 12);
            this.diesel_box.Name = "diesel_box";
            this.diesel_box.Size = new System.Drawing.Size(54, 17);
            this.diesel_box.TabIndex = 4;
            this.diesel_box.TabStop = true;
            this.diesel_box.Text = "Diesel";
            this.diesel_box.UseVisualStyleBackColor = true;
            // 
            // ysiviis_box
            // 
            this.ysiviis_box.AutoSize = true;
            this.ysiviis_box.Location = new System.Drawing.Point(12, 34);
            this.ysiviis_box.Name = "ysiviis_box";
            this.ysiviis_box.Size = new System.Drawing.Size(37, 17);
            this.ysiviis_box.TabIndex = 4;
            this.ysiviis_box.Text = "95";
            this.ysiviis_box.UseVisualStyleBackColor = true;
            // 
            // ysikasi_box
            // 
            this.ysikasi_box.AutoSize = true;
            this.ysikasi_box.Location = new System.Drawing.Point(12, 57);
            this.ysikasi_box.Name = "ysikasi_box";
            this.ysikasi_box.Size = new System.Drawing.Size(37, 17);
            this.ysikasi_box.TabIndex = 4;
            this.ysikasi_box.Text = "98";
            this.ysikasi_box.UseVisualStyleBackColor = true;
            // 
            // viesti_label
            // 
            this.viesti_label.AutoSize = true;
            this.viesti_label.Location = new System.Drawing.Point(119, 103);
            this.viesti_label.Name = "viesti_label";
            this.viesti_label.Size = new System.Drawing.Size(0, 13);
            this.viesti_label.TabIndex = 5;
            // 
            // sulje_nappi
            // 
            this.sulje_nappi.Location = new System.Drawing.Point(184, 124);
            this.sulje_nappi.Name = "sulje_nappi";
            this.sulje_nappi.Size = new System.Drawing.Size(87, 23);
            this.sulje_nappi.TabIndex = 0;
            this.sulje_nappi.Text = "Stäng fönster";
            this.sulje_nappi.UseVisualStyleBackColor = true;
            // 
            // TilausIkkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 166);
            this.Controls.Add(this.viesti_label);
            this.Controls.Add(this.ysikasi_box);
            this.Controls.Add(this.ysiviis_box);
            this.Controls.Add(this.diesel_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maara_updown);
            this.Controls.Add(this.sulje_nappi);
            this.Controls.Add(this.Tilausnappi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TilausIkkuna";
            this.Text = "Pinacolada -  Bensinmätare - Beställningpanel";
            ((System.ComponentModel.ISupportInitialize)(this.maara_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tilausnappi;
        private System.Windows.Forms.NumericUpDown maara_updown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton diesel_box;
        private System.Windows.Forms.RadioButton ysiviis_box;
        private System.Windows.Forms.RadioButton ysikasi_box;
        private System.Windows.Forms.Label viesti_label;
        private System.Windows.Forms.Button sulje_nappi;
    }
}