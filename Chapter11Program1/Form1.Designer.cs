namespace Chapter11Program1
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
            this.label2 = new System.Windows.Forms.Label();
            this.Trajectory = new System.Windows.Forms.NumericUpDown();
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance";
            // 
            // Trajectory
            // 
            this.Trajectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trajectory.Location = new System.Drawing.Point(158, 45);
            this.Trajectory.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Trajectory.Name = "Trajectory";
            this.Trajectory.Size = new System.Drawing.Size(120, 28);
            this.Trajectory.TabIndex = 2;
            // 
            // Distance
            // 
            this.Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Distance.Location = new System.Drawing.Point(158, 99);
            this.Distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(120, 28);
            this.Distance.TabIndex = 3;
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(158, 154);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(113, 42);
            this.play.TabIndex = 4;
            this.play.Text = "Play ball!";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Trajectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baseball simulator";
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Trajectory;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.Button play;
    }
}

