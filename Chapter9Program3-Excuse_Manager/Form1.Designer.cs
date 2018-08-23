namespace Chapter9Program3_Excuse_Manager
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.excuse = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.lastused = new System.Windows.Forms.DateTimePicker();
            this.FileDateLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "File date :";
            // 
            // folder
            // 
            this.folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder.Location = new System.Drawing.Point(13, 334);
            this.folder.Margin = new System.Windows.Forms.Padding(4);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(136, 41);
            this.folder.TabIndex = 4;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(181, 334);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(129, 41);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(339, 334);
            this.Open.Margin = new System.Windows.Forms.Padding(4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(120, 41);
            this.Open.TabIndex = 6;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Random
            // 
            this.Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Random.Location = new System.Drawing.Point(483, 334);
            this.Random.Margin = new System.Windows.Forms.Padding(4);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(122, 41);
            this.Random.TabIndex = 7;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // excuse
            // 
            this.excuse.Location = new System.Drawing.Point(141, 30);
            this.excuse.Name = "excuse";
            this.excuse.Size = new System.Drawing.Size(445, 27);
            this.excuse.TabIndex = 8;
            this.excuse.TextChanged += new System.EventHandler(this.excuse_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(141, 103);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(445, 27);
            this.result.TabIndex = 9;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // lastused
            // 
            this.lastused.Location = new System.Drawing.Point(141, 174);
            this.lastused.Name = "lastused";
            this.lastused.Size = new System.Drawing.Size(200, 27);
            this.lastused.TabIndex = 10;
            this.lastused.ValueChanged += new System.EventHandler(this.lastused_ValueChanged);
            // 
            // FileDateLabel
            // 
            this.FileDateLabel.AutoSize = true;
            this.FileDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileDateLabel.Location = new System.Drawing.Point(146, 251);
            this.FileDateLabel.Name = "FileDateLabel";
            this.FileDateLabel.Size = new System.Drawing.Size(111, 22);
            this.FileDateLabel.TabIndex = 11;
            this.FileDateLabel.Text = "                    ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 419);
            this.Controls.Add(this.FileDateLabel);
            this.Controls.Add(this.lastused);
            this.Controls.Add(this.result);
            this.Controls.Add(this.excuse);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.TextBox excuse;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.DateTimePicker lastused;
        private System.Windows.Forms.Label FileDateLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

