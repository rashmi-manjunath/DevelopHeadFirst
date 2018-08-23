namespace Chapter14Program1
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
            this.Clone1 = new System.Windows.Forms.Button();
            this.Clone2 = new System.Windows.Forms.Button();
            this.GC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clone1
            // 
            this.Clone1.Location = new System.Drawing.Point(58, 25);
            this.Clone1.Name = "Clone1";
            this.Clone1.Size = new System.Drawing.Size(144, 44);
            this.Clone1.TabIndex = 0;
            this.Clone1.Text = "Clone #1";
            this.Clone1.UseVisualStyleBackColor = true;
            this.Clone1.Click += new System.EventHandler(this.Clone1_Click);
            // 
            // Clone2
            // 
            this.Clone2.Location = new System.Drawing.Point(58, 89);
            this.Clone2.Name = "Clone2";
            this.Clone2.Size = new System.Drawing.Size(144, 43);
            this.Clone2.TabIndex = 1;
            this.Clone2.Text = "Clone #2";
            this.Clone2.UseVisualStyleBackColor = true;
            this.Clone2.Click += new System.EventHandler(this.Clone2_Click);
            // 
            // GC
            // 
            this.GC.Location = new System.Drawing.Point(58, 160);
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(144, 42);
            this.GC.TabIndex = 2;
            this.GC.Text = "GC";
            this.GC.UseVisualStyleBackColor = true;
            this.GC.Click += new System.EventHandler(this.GC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 253);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.Clone2);
            this.Controls.Add(this.Clone1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clone1;
        private System.Windows.Forms.Button Clone2;
        private System.Windows.Forms.Button GC;
    }
}

