﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6Program3
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] {"Nectar collector","Honey manufacturing"});
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring"});
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol"});
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing"});
            queen = new Queen(workers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("No workers are available to do this job '" + workerBeeJob.Text + " '", "The queen bee says..");
            }
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + " ' will be done in " + shifts.Value + " shifts", "the queen bee says..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkNextShift();
        }
    }
}
