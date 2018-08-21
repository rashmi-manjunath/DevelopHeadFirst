namespace Chapter5Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fancy = new System.Windows.Forms.CheckBox();
            this.healthy = new System.Windows.Forms.CheckBox();
            this.cashlabel = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of People";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(204, 33);
            this.numericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // fancy
            // 
            this.fancy.AutoSize = true;
            this.fancy.Checked = true;
            this.fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancy.Location = new System.Drawing.Point(113, 99);
            this.fancy.Name = "fancy";
            this.fancy.Size = new System.Drawing.Size(180, 28);
            this.fancy.TabIndex = 2;
            this.fancy.Text = "Fancy Decoration";
            this.fancy.UseVisualStyleBackColor = true;
            this.fancy.CheckedChanged += new System.EventHandler(this.fancy_CheckedChanged);
            // 
            // healthy
            // 
            this.healthy.AutoSize = true;
            this.healthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthy.Location = new System.Drawing.Point(113, 145);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(152, 28);
            this.healthy.TabIndex = 3;
            this.healthy.Text = "Heathy Option\r\n";
            this.healthy.UseVisualStyleBackColor = true;
            this.healthy.CheckedChanged += new System.EventHandler(this.healthy_CheckedChanged);
            // 
            // cashlabel
            // 
            this.cashlabel.AutoSize = true;
            this.cashlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashlabel.Location = new System.Drawing.Point(28, 236);
            this.cashlabel.Name = "cashlabel";
            this.cashlabel.Size = new System.Drawing.Size(53, 24);
            this.cashlabel.TabIndex = 4;
            this.cashlabel.Text = "Cash";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(120, 236);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(75, 24);
            this.cash.TabIndex = 5;
            this.cash.Text = "             ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.cashlabel);
            this.Controls.Add(this.healthy);
            this.Controls.Add(this.fancy);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label cashlabel;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.CheckBox healthy;
        private System.Windows.Forms.CheckBox fancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
#endregion
