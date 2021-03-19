
namespace WindowsFormsApp1
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
            this.textSeed = new System.Windows.Forms.TextBox();
            this.textCapacity = new System.Windows.Forms.TextBox();
            this.textNoItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrzedmioty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSeed
            // 
            this.textSeed.Location = new System.Drawing.Point(102, 67);
            this.textSeed.Name = "textSeed";
            this.textSeed.Size = new System.Drawing.Size(100, 22);
            this.textSeed.TabIndex = 1;
            // 
            // textCapacity
            // 
            this.textCapacity.Location = new System.Drawing.Point(529, 67);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Size = new System.Drawing.Size(100, 22);
            this.textCapacity.TabIndex = 2;
            // 
            // textNoItems
            // 
            this.textNoItems.Location = new System.Drawing.Point(330, 67);
            this.textNoItems.Name = "textNoItems";
            this.textNoItems.Size = new System.Drawing.Size(100, 22);
            this.textNoItems.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // textPrzedmioty
            // 
            this.textPrzedmioty.Location = new System.Drawing.Point(46, 258);
            this.textPrzedmioty.Multiline = true;
            this.textPrzedmioty.Name = "textPrzedmioty";
            this.textPrzedmioty.Size = new System.Drawing.Size(360, 22);
            this.textPrzedmioty.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPrzedmioty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNoItems);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.textSeed);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSeed;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.TextBox textNoItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrzedmioty;
    }
}

