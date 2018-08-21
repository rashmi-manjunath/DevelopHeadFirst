namespace Chapter6Program1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cash = new System.Windows.Forms.Label();
            this.cashlabel = new System.Windows.Forms.Label();
            this.healthy = new System.Windows.Forms.CheckBox();
            this.fancy = new System.Windows.Forms.CheckBox();
            this.dinnerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.cakewriting = new System.Windows.Forms.TextBox();
            this.bdayUpDown = new System.Windows.Forms.NumericUpDown();
            this.cost = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.cakewritinglabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cash);
            this.tabPage1.Controls.Add(this.cashlabel);
            this.tabPage1.Controls.Add(this.healthy);
            this.tabPage1.Controls.Add(this.fancy);
            this.tabPage1.Controls.Add(this.dinnerUpDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.BackColor = System.Drawing.Color.Gray;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(103, 213);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(75, 24);
            this.cash.TabIndex = 11;
            this.cash.Text = "             ";
            // 
            // cashlabel
            // 
            this.cashlabel.AutoSize = true;
            this.cashlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashlabel.Location = new System.Drawing.Point(24, 213);
            this.cashlabel.Name = "cashlabel";
            this.cashlabel.Size = new System.Drawing.Size(47, 24);
            this.cashlabel.TabIndex = 10;
            this.cashlabel.Text = "Cost";
            // 
            // healthy
            // 
            this.healthy.AutoSize = true;
            this.healthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthy.Location = new System.Drawing.Point(74, 137);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(152, 28);
            this.healthy.TabIndex = 9;
            this.healthy.Text = "Heathy Option\r\n";
            this.healthy.UseVisualStyleBackColor = true;
            this.healthy.CheckedChanged += new System.EventHandler(this.healthy_CheckedChanged);
            // 
            // fancy
            // 
            this.fancy.AutoSize = true;
            this.fancy.Checked = true;
            this.fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancy.Location = new System.Drawing.Point(74, 94);
            this.fancy.Name = "fancy";
            this.fancy.Size = new System.Drawing.Size(180, 28);
            this.fancy.TabIndex = 8;
            this.fancy.Text = "Fancy Decoration";
            this.fancy.UseVisualStyleBackColor = true;
            this.fancy.CheckedChanged += new System.EventHandler(this.fancy_CheckedChanged);
            // 
            // dinnerUpDown
            // 
            this.dinnerUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerUpDown.Location = new System.Drawing.Point(212, 25);
            this.dinnerUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dinnerUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dinnerUpDown.Name = "dinnerUpDown";
            this.dinnerUpDown.Size = new System.Drawing.Size(120, 28);
            this.dinnerUpDown.TabIndex = 7;
            this.dinnerUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dinnerUpDown.ValueChanged += new System.EventHandler(this.dinnerUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number Of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fancyCheckBox);
            this.tabPage2.Controls.Add(this.cakewriting);
            this.tabPage2.Controls.Add(this.bdayUpDown);
            this.tabPage2.Controls.Add(this.cost);
            this.tabPage2.Controls.Add(this.costLabel);
            this.tabPage2.Controls.Add(this.cakewritinglabel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Checked = true;
            this.fancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyCheckBox.Location = new System.Drawing.Point(87, 79);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(189, 28);
            this.fancyCheckBox.TabIndex = 6;
            this.fancyCheckBox.Text = "Fancy Decorations";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            this.fancyCheckBox.CheckedChanged += new System.EventHandler(this.fancyCheckBox_CheckedChanged);
            // 
            // cakewriting
            // 
            this.cakewriting.Location = new System.Drawing.Point(23, 162);
            this.cakewriting.Name = "cakewriting";
            this.cakewriting.Size = new System.Drawing.Size(204, 28);
            this.cakewriting.TabIndex = 5;
            this.cakewriting.Text = "Happy Birthday!";
            this.cakewriting.TextChanged += new System.EventHandler(this.cakewriting_TextChanged);
            // 
            // bdayUpDown
            // 
            this.bdayUpDown.Location = new System.Drawing.Point(206, 26);
            this.bdayUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bdayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bdayUpDown.Name = "bdayUpDown";
            this.bdayUpDown.Size = new System.Drawing.Size(120, 28);
            this.bdayUpDown.TabIndex = 4;
            this.bdayUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bdayUpDown.ValueChanged += new System.EventHandler(this.bdayUpDown_ValueChanged);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.BackColor = System.Drawing.Color.Gray;
            this.cost.Location = new System.Drawing.Point(103, 211);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(75, 24);
            this.cost.TabIndex = 3;
            this.cost.Text = "             ";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(26, 211);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(47, 24);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost";
            // 
            // cakewritinglabel
            // 
            this.cakewritinglabel.AutoSize = true;
            this.cakewritinglabel.Location = new System.Drawing.Point(17, 124);
            this.cakewritinglabel.Name = "cakewritinglabel";
            this.cakewritinglabel.Size = new System.Drawing.Size(116, 24);
            this.cakewritinglabel.TabIndex = 1;
            this.cakewritinglabel.Text = "Cake Writing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdayUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label cashlabel;
        private System.Windows.Forms.CheckBox healthy;
        private System.Windows.Forms.CheckBox fancy;
        private System.Windows.Forms.NumericUpDown dinnerUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.TextBox cakewriting;
        private System.Windows.Forms.NumericUpDown bdayUpDown;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label cakewritinglabel;
        private System.Windows.Forms.Label label2;
    }
}

