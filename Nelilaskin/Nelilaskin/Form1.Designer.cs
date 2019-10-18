namespace Nelilaskin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.luku1 = new System.Windows.Forms.TextBox();
            this.luku2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Miinus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operator_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Plus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Operator_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Jako";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Operator_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kerto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operator_click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(255, 49);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 20);
            this.result.TabIndex = 4;
            // 
            // luku1
            // 
            this.luku1.Location = new System.Drawing.Point(12, 49);
            this.luku1.Name = "luku1";
            this.luku1.Size = new System.Drawing.Size(75, 20);
            this.luku1.TabIndex = 5;
            // 
            // luku2
            // 
            this.luku2.Location = new System.Drawing.Point(123, 49);
            this.luku2.Name = "luku2";
            this.luku2.Size = new System.Drawing.Size(100, 20);
            this.luku2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Tyhjennä";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 147);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.luku2);
            this.Controls.Add(this.luku1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox luku1;
        private System.Windows.Forms.TextBox luku2;
        private System.Windows.Forms.Button button5;
    }
}

