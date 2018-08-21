namespace Chapter7Program3
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
            this.exists = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exists
            // 
            this.exists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exists.FormattingEnabled = true;
            this.exists.Location = new System.Drawing.Point(183, 191);
            this.exists.Name = "exists";
            this.exists.Size = new System.Drawing.Size(359, 37);
            this.exists.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go here:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goThroughTheDoor.Location = new System.Drawing.Point(26, 251);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(516, 45);
            this.goThroughTheDoor.TabIndex = 2;
            this.goThroughTheDoor.Text = "Go through the door\r\n";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(26, 22);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(516, 155);
            this.description.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 335);
            this.Controls.Add(this.description);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exists);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox exists;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.TextBox description;
    }
}

