namespace TicTacToe
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
            this.square1 = new System.Windows.Forms.Button();
            this.square5 = new System.Windows.Forms.Button();
            this.square9 = new System.Windows.Forms.Button();
            this.square6 = new System.Windows.Forms.Button();
            this.square2 = new System.Windows.Forms.Button();
            this.square3 = new System.Windows.Forms.Button();
            this.square4 = new System.Windows.Forms.Button();
            this.square7 = new System.Windows.Forms.Button();
            this.square8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // square1
            // 
            this.square1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square1.Location = new System.Drawing.Point(3, 1);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(87, 80);
            this.square1.TabIndex = 0;
            this.square1.UseVisualStyleBackColor = true;
            this.square1.Click += new System.EventHandler(this.square1_Click);
            // 
            // square5
            // 
            this.square5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square5.Location = new System.Drawing.Point(99, 90);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(87, 80);
            this.square5.TabIndex = 1;
            this.square5.UseVisualStyleBackColor = true;
            this.square5.Click += new System.EventHandler(this.square5_Click);
            // 
            // square9
            // 
            this.square9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square9.Location = new System.Drawing.Point(195, 179);
            this.square9.Name = "square9";
            this.square9.Size = new System.Drawing.Size(87, 80);
            this.square9.TabIndex = 2;
            this.square9.UseVisualStyleBackColor = true;
            this.square9.Click += new System.EventHandler(this.square9_Click);
            // 
            // square6
            // 
            this.square6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square6.Location = new System.Drawing.Point(195, 90);
            this.square6.Name = "square6";
            this.square6.Size = new System.Drawing.Size(87, 80);
            this.square6.TabIndex = 3;
            this.square6.UseVisualStyleBackColor = true;
            this.square6.Click += new System.EventHandler(this.square6_Click);
            // 
            // square2
            // 
            this.square2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square2.Location = new System.Drawing.Point(99, 1);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(87, 80);
            this.square2.TabIndex = 4;
            this.square2.UseVisualStyleBackColor = true;
            this.square2.Click += new System.EventHandler(this.square2_Click);
            // 
            // square3
            // 
            this.square3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square3.Location = new System.Drawing.Point(195, 1);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(87, 80);
            this.square3.TabIndex = 5;
            this.square3.UseVisualStyleBackColor = true;
            this.square3.Click += new System.EventHandler(this.square3_Click);
            // 
            // square4
            // 
            this.square4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square4.Location = new System.Drawing.Point(3, 90);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(87, 80);
            this.square4.TabIndex = 6;
            this.square4.UseVisualStyleBackColor = true;
            this.square4.Click += new System.EventHandler(this.square4_Click);
            // 
            // square7
            // 
            this.square7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square7.Location = new System.Drawing.Point(3, 179);
            this.square7.Name = "square7";
            this.square7.Size = new System.Drawing.Size(87, 80);
            this.square7.TabIndex = 7;
            this.square7.UseVisualStyleBackColor = true;
            this.square7.Click += new System.EventHandler(this.square7_Click);
            // 
            // square8
            // 
            this.square8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.square8.Location = new System.Drawing.Point(99, 179);
            this.square8.Name = "square8";
            this.square8.Size = new System.Drawing.Size(87, 80);
            this.square8.TabIndex = 8;
            this.square8.UseVisualStyleBackColor = true;
            this.square8.Click += new System.EventHandler(this.square8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.breathmint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.square8);
            this.Controls.Add(this.square7);
            this.Controls.Add(this.square4);
            this.Controls.Add(this.square3);
            this.Controls.Add(this.square2);
            this.Controls.Add(this.square6);
            this.Controls.Add(this.square9);
            this.Controls.Add(this.square5);
            this.Controls.Add(this.square1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button square1;
        private System.Windows.Forms.Button square5;
        private System.Windows.Forms.Button square9;
        private System.Windows.Forms.Button square6;
        private System.Windows.Forms.Button square2;
        private System.Windows.Forms.Button square3;
        private System.Windows.Forms.Button square4;
        private System.Windows.Forms.Button square7;
        private System.Windows.Forms.Button square8;
    }
}

