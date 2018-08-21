using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Program4
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].getHoneyConsumption();
            totalConsumption += getHoneyConsumption();

            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + "finished the job \r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker # " + (i + 1) + " is doing '" + workers[i].CurrentJob + "'for " + workers[i].ShiftLeft + " more shifts\r\n";
                else
                if (workers[i].ShiftLeft > 0)
                    report += "worker # " + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftLeft + " more shifts \r\n";
                else
                    report += "Worker # " + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n";
            }
            report += "Total honey consumption: " + totalConsumption + "units";
            return report;
        }
        public override double getHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].getHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].getHoneyConsumption();
                if (workers[i].ShiftLeft > 0)
                    workersDoingJobs++;
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
                consumption += 20;
            return consumption;
        }
    }
}
