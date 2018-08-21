namespace Chapter8Program6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 394);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(311, 74);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 394);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deck #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck #2";
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToDeck1.Location = new System.Drawing.Point(221, 211);
            this.moveToDeck1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(56, 30);
            this.moveToDeck1.TabIndex = 4;
            this.moveToDeck1.Text = ">>";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToDeck2.Location = new System.Drawing.Point(221, 259);
            this.moveToDeck2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(56, 37);
            this.moveToDeck2.TabIndex = 5;
            this.moveToDeck2.Text = "<<";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // resetDeck1
            // 
            this.resetDeck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDeck1.Location = new System.Drawing.Point(37, 493);
            this.resetDeck1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(146, 34);
            this.resetDeck1.TabIndex = 6;
            this.resetDeck1.Text = "Reset Deck #1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleDeck1.Location = new System.Drawing.Point(37, 544);
            this.shuffleDeck1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(146, 36);
            this.shuffleDeck1.TabIndex = 7;
            this.shuffleDeck1.Text = "Shuffle Deck #1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDeck2.Location = new System.Drawing.Point(311, 493);
            this.resetDeck2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(148, 34);
            this.resetDeck2.TabIndex = 8;
            this.resetDeck2.Text = "Reset Deck #2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleDeck2.Location = new System.Drawing.Point(311, 544);
            this.shuffleDeck2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(148, 36);
            this.shuffleDeck2.TabIndex = 9;
            this.shuffleDeck2.Text = "Shuffle Deck #2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 612);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
    }
}

