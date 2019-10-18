namespace Bensa_Automaatti
{
    partial class Paaformi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paaformi));
            this.Hallintapaneeli_button = new System.Windows.Forms.Button();
            this.tunnus_textbox = new System.Windows.Forms.TextBox();
            this.salasana_textbox = new System.Windows.Forms.TextBox();
            this.Tunnus_label = new System.Windows.Forms.Label();
            this.Salasana_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hallintapaneeli_button
            // 
            this.Hallintapaneeli_button.Location = new System.Drawing.Point(97, 81);
            this.Hallintapaneeli_button.Name = "Hallintapaneeli_button";
            this.Hallintapaneeli_button.Size = new System.Drawing.Size(154, 23);
            this.Hallintapaneeli_button.TabIndex = 0;
            this.Hallintapaneeli_button.Text = "Logga in";
            this.Hallintapaneeli_button.UseVisualStyleBackColor = true;
            // 
            // tunnus_textbox
            // 
            this.tunnus_textbox.Location = new System.Drawing.Point(151, 12);
            this.tunnus_textbox.Name = "tunnus_textbox";
            this.tunnus_textbox.Size = new System.Drawing.Size(100, 20);
            this.tunnus_textbox.TabIndex = 1;
            // 
            // salasana_textbox
            // 
            this.salasana_textbox.Location = new System.Drawing.Point(151, 55);
            this.salasana_textbox.Name = "salasana_textbox";
            this.salasana_textbox.PasswordChar = '*';
            this.salasana_textbox.Size = new System.Drawing.Size(100, 20);
            this.salasana_textbox.TabIndex = 2;
            // 
            // Tunnus_label
            // 
            this.Tunnus_label.AutoSize = true;
            this.Tunnus_label.Location = new System.Drawing.Point(66, 15);
            this.Tunnus_label.Name = "Tunnus_label";
            this.Tunnus_label.Size = new System.Drawing.Size(79, 13);
            this.Tunnus_label.TabIndex = 3;
            this.Tunnus_label.Text = "Användarnamn";
            // 
            // Salasana_label
            // 
            this.Salasana_label.AutoSize = true;
            this.Salasana_label.Location = new System.Drawing.Point(94, 62);
            this.Salasana_label.Name = "Salasana_label";
            this.Salasana_label.Size = new System.Drawing.Size(51, 13);
            this.Salasana_label.TabIndex = 4;
            this.Salasana_label.Text = "Lösenord";
            // 
            // error_label
            // 
            this.error_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.error_label.Location = new System.Drawing.Point(-10, 107);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(387, 13);
            this.error_label.TabIndex = 5;
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Paaformi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 127);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.Salasana_label);
            this.Controls.Add(this.Tunnus_label);
            this.Controls.Add(this.salasana_textbox);
            this.Controls.Add(this.tunnus_textbox);
            this.Controls.Add(this.Hallintapaneeli_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paaformi";
            this.Text = "Pinacolada - Bensinmätare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hallintapaneeli_button;
        private System.Windows.Forms.TextBox tunnus_textbox;
        private System.Windows.Forms.TextBox salasana_textbox;
        private System.Windows.Forms.Label Tunnus_label;
        private System.Windows.Forms.Label Salasana_label;
        private System.Windows.Forms.Label error_label;
    }
}

