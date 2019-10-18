namespace Bensa_Automaatti
{
    partial class Hallintaikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hallintaikkuna));
            this.label1 = new System.Windows.Forms.Label();
            this.diesel_bar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ysikasi_bar = new System.Windows.Forms.ProgressBar();
            this.ysiviis_bar = new System.Windows.Forms.ProgressBar();
            this.diesel_varoitus = new System.Windows.Forms.Label();
            this.ysikasi_varoitus = new System.Windows.Forms.Label();
            this.ysiviis_varoitus = new System.Windows.Forms.Label();
            this.Tilaa_lisaa_nappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diesel";
            // 
            // diesel_bar
            // 
            this.diesel_bar.Location = new System.Drawing.Point(108, 19);
            this.diesel_bar.Name = "diesel_bar";
            this.diesel_bar.Size = new System.Drawing.Size(73, 31);
            this.diesel_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.diesel_bar.TabIndex = 1;
            this.diesel_bar.Value = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "98E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "95E";
            // 
            // ysikasi_bar
            // 
            this.ysikasi_bar.Location = new System.Drawing.Point(108, 64);
            this.ysikasi_bar.Name = "ysikasi_bar";
            this.ysikasi_bar.Size = new System.Drawing.Size(73, 31);
            this.ysikasi_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ysikasi_bar.TabIndex = 4;
            this.ysikasi_bar.Value = 50;
            // 
            // ysiviis_bar
            // 
            this.ysiviis_bar.Location = new System.Drawing.Point(108, 108);
            this.ysiviis_bar.Name = "ysiviis_bar";
            this.ysiviis_bar.Size = new System.Drawing.Size(73, 31);
            this.ysiviis_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ysiviis_bar.TabIndex = 5;
            this.ysiviis_bar.Value = 50;
            // 
            // diesel_varoitus
            // 
            this.diesel_varoitus.AutoSize = true;
            this.diesel_varoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diesel_varoitus.Location = new System.Drawing.Point(196, 19);
            this.diesel_varoitus.Name = "diesel_varoitus";
            this.diesel_varoitus.Size = new System.Drawing.Size(0, 31);
            this.diesel_varoitus.TabIndex = 6;
            // 
            // ysikasi_varoitus
            // 
            this.ysikasi_varoitus.AutoSize = true;
            this.ysikasi_varoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysikasi_varoitus.Location = new System.Drawing.Point(196, 64);
            this.ysikasi_varoitus.Name = "ysikasi_varoitus";
            this.ysikasi_varoitus.Size = new System.Drawing.Size(0, 31);
            this.ysikasi_varoitus.TabIndex = 7;
            // 
            // ysiviis_varoitus
            // 
            this.ysiviis_varoitus.AutoSize = true;
            this.ysiviis_varoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysiviis_varoitus.Location = new System.Drawing.Point(196, 108);
            this.ysiviis_varoitus.Name = "ysiviis_varoitus";
            this.ysiviis_varoitus.Size = new System.Drawing.Size(0, 31);
            this.ysiviis_varoitus.TabIndex = 8;
            // 
            // Tilaa_lisaa_nappi
            // 
            this.Tilaa_lisaa_nappi.Location = new System.Drawing.Point(92, 195);
            this.Tilaa_lisaa_nappi.Name = "Tilaa_lisaa_nappi";
            this.Tilaa_lisaa_nappi.Size = new System.Drawing.Size(75, 23);
            this.Tilaa_lisaa_nappi.TabIndex = 9;
            this.Tilaa_lisaa_nappi.Text = "Beställa mer";
            this.Tilaa_lisaa_nappi.UseVisualStyleBackColor = true;
            this.Tilaa_lisaa_nappi.Visible = false;
            // 
            // Hallintaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 246);
            this.Controls.Add(this.Tilaa_lisaa_nappi);
            this.Controls.Add(this.ysiviis_varoitus);
            this.Controls.Add(this.ysikasi_varoitus);
            this.Controls.Add(this.diesel_varoitus);
            this.Controls.Add(this.ysiviis_bar);
            this.Controls.Add(this.ysikasi_bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diesel_bar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hallintaikkuna";
            this.Text = "Pinacolada - Bensinmätare - Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar diesel_bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ysikasi_bar;
        private System.Windows.Forms.ProgressBar ysiviis_bar;
        private System.Windows.Forms.Label diesel_varoitus;
        private System.Windows.Forms.Label ysikasi_varoitus;
        private System.Windows.Forms.Label ysiviis_varoitus;
        private System.Windows.Forms.Button Tilaa_lisaa_nappi;
    }
}