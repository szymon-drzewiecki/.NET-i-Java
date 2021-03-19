
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
            this.textBag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSeed
            // 
            this.textSeed.Location = new System.Drawing.Point(38, 54);
            this.textSeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSeed.Name = "textSeed";
            this.textSeed.Size = new System.Drawing.Size(251, 20);
            this.textSeed.TabIndex = 1;
            // 
            // textCapacity
            // 
            this.textCapacity.Location = new System.Drawing.Point(467, 54);
            this.textCapacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Size = new System.Drawing.Size(339, 20);
            this.textCapacity.TabIndex = 2;
            // 
            // textNoItems
            // 
            this.textNoItems.Location = new System.Drawing.Point(360, 54);
            this.textNoItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNoItems.Name = "textNoItems";
            this.textNoItems.Size = new System.Drawing.Size(76, 20);
            this.textNoItems.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "capacity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPrzedmioty
            // 
            this.textPrzedmioty.Location = new System.Drawing.Point(26, 162);
            this.textPrzedmioty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPrzedmioty.Multiline = true;
            this.textPrzedmioty.Name = "textPrzedmioty";
            this.textPrzedmioty.Size = new System.Drawing.Size(350, 434);
            this.textPrzedmioty.TabIndex = 8;
            // 
            // textBag
            // 
            this.textBag.Location = new System.Drawing.Point(419, 162);
            this.textBag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBag.Multiline = true;
            this.textBag.Name = "textBag";
            this.textBag.Size = new System.Drawing.Size(387, 434);
            this.textBag.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "no of items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "generated items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "items in backpack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 617);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBag);
            this.Controls.Add(this.textPrzedmioty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNoItems);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.textSeed);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

