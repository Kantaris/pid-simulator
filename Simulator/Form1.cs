using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulator
{
    public partial class Form1 : Form
    {
        int sampleRate;
        int maxReadError;
        double tempIncreaseRate;
        double tempDecreaseRate;
        double maxTemperature;
        double minTemperature;
        double tempIncreaseKvalue;
        double tempIncreaseMvalue;
        double tempDecreaseKvalue;
        double tempDecreaseMvalue;
        int[] targetTemp = new int[4];
        int targetIndex = 0;
        int delayTime;
        int processTime = 5000;
        int currentTime = 0;
        double currentTemp1;
        double oldTemp1;
        double kpvalue;
        double kivalue;
        double kdvalue;
        double iv1 = 0;
        List<double> outputDelayList1 = new List<double>();
        FullView fv = new FullView();
        FullViewOutput fvo = new FullViewOutput();
        FullView[] fvs = new FullView[4];
        FullViewOutput[] fvos = new FullViewOutput[4];


        public Form1()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {

            fv.Show();
            fvo.Show();
            fvos[0] = new FullViewOutput();
            fvos[1] = new FullViewOutput();
            fvos[2] = new FullViewOutput();
            fvos[3] = new FullViewOutput();
            fvs[0] = new FullView();
            fvs[1] = new FullView();
            fvs[2] = new FullView();
            fvs[3] = new FullView();
            fvos[0].Show();
            fvos[1].Show();
            fvos[2].Show();
            fvs[0].Show();
            fvs[1].Show();
            fvs[2].Show();
            targetTemp[0] = int.Parse(targetTemp1Box.Text);
            targetTemp[1] = int.Parse(targetTemp2Box.Text);
            targetTemp[2] = int.Parse(targetTemp3Box.Text);
            targetTemp[3] = 0;
            sampleRate = int.Parse(sampleRateBox.Text);
            maxReadError = int.Parse(readErrorBox.Text);
            tempIncreaseRate = double.Parse(tempIncreaseBox1.Text);
            tempDecreaseRate = double.Parse(tempDecreaseBox2.Text);
            maxTemperature = double.Parse(maxTempBox.Text);
            minTemperature = double.Parse(minTempBox.Text);
            kpvalue = double.Parse(kpBox.Text);
            kivalue = double.Parse(kiBox.Text);
            kdvalue = double.Parse(kdBox.Text);
            currentTemp1 = minTemperature;
            oldTemp1 = minTemperature;
            delayTime = int.Parse(delayBox.Text);

            for (int i = 0; i < delayTime; i++)
            {
                outputDelayList1.Add(0);
            }
          

            double tempIncreaseDelta = 100 - maxTemperature;
            tempIncreaseKvalue = tempIncreaseRate / tempIncreaseDelta;
            tempIncreaseMvalue = maxTemperature * (-tempIncreaseKvalue);
            double tempDecreaseDelta = 1000 - minTemperature;
            tempDecreaseKvalue = tempDecreaseRate / tempIncreaseDelta;
            tempDecreaseMvalue = minTemperature * (-tempDecreaseKvalue);

           
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int targetTime = 0;
            bool usingPID = false; 
            while (currentTime < processTime)
            {
                currentTime++;
                double cOutput1 = 0;
                double pPart1 = 0;
                double iPart1 = 0;
                double dPart1 = 0;
                if (currentTemp1 > targetTemp[targetIndex] - 10 && currentTemp1 < targetTemp[targetIndex] + 10)
                {
                    if (targetTime < 500)
                    {
                        usingPID = true;
                        targetTime++;
                        double pv1 = targetTemp[targetIndex] - currentTemp1;
                        iv1 += pv1;
                        double dv1 = oldTemp1 - currentTemp1;

                        pPart1 = kpvalue * pv1;
                        iPart1 = iv1 * kivalue;
                        dPart1 = dv1 * kdvalue;
                        cOutput1 = kpvalue * pv1 + iv1 * kivalue + dv1 * kdvalue;
                        if (cOutput1 < 0)
                        {
                            cOutput1 = 0;
                        }
                        if (cOutput1 > 1)
                        {
                            cOutput1 = 1;
                        }
                    }
                    else
                    {
                        targetTime = 0;
                        targetIndex++;
                        usingPID = false;
                    }
                }
                else if (currentTemp1 < targetTemp[targetIndex])
                {
                    cOutput1 = 1;
                    iv1 = 0;
                }

                outputDelayList1.Add(cOutput1);
                outputDelayList1.RemoveAt(0);

                double sumOutput1 = 0;
                for (int i = 0; i < delayTime; i++)
                {
                    sumOutput1 += outputDelayList1[i];
                }
                double delayedOutput1 = sumOutput1 / delayTime;
                double maxIncrease1 = tempIncreaseKvalue * currentTemp1 + tempIncreaseMvalue;
                double maxDecrease1 = tempDecreaseKvalue * currentTemp1 + tempDecreaseMvalue;

                double tempChangeDelta1 = maxIncrease1 - maxDecrease1;
                oldTemp1 = currentTemp1;
                currentTemp1 = currentTemp1 + maxDecrease1 + (tempChangeDelta1 * delayedOutput1);
                
                double sumSamples1 = 0;
                Random randomgen = new Random();
                for (int i = 0; i < sampleRate; i++)
                {
                    sumSamples1 += currentTemp1 - (maxReadError / 2) + (randomgen.NextDouble() * maxReadError);
                }
                double readTemp1 = sumSamples1 / sampleRate;
                object[] obj = { readTemp1, cOutput1, pPart1, iPart1, dPart1, usingPID, targetIndex};
                backgroundWorker1.ReportProgress(0, obj);
            }

            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object[] obj = (object[])e.UserState;
            fv.addValueSector1((double)obj[0]);
            fvo.addValueSector1((double)obj[1]);
            fvo.addValueP((double)obj[2]);
            fvo.addValueI((double)obj[3]);
            fvo.addValueD((double)obj[4]);
            if ((bool)obj[5])
            {

                fvs[(int)obj[6]].addValueSector1((double)obj[0]);
                fvos[(int)obj[6]].addValueSector1((double)obj[1]);
                fvos[(int)obj[6]].addValueP((double)obj[2]);
                fvos[(int)obj[6]].addValueI((double)obj[3]);
                fvos[(int)obj[6]].addValueD((double)obj[4]);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fvs[0].finished();
            fvs[1].finished();
            fvs[2].finished();
        }
    }
}
