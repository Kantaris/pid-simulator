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
    public partial class FullViewOutput : Form
    {
        public FullViewOutput()
        {
            InitializeComponent(); chart1.ChartAreas[0].AxisX.Title = "Time (Seconds)";
            chart1.ChartAreas[0].AxisY.Title = "Output";
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 8);
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 8);
        }

        public void addValueSector1(double temp)
        {
            chart1.Series[0].Points.AddY(temp);
        }
        public void addValueP(double temp)
        {
            chart1.Series[1].Points.AddY(temp);
        }
        public void addValueI(double temp)
        {
            chart1.Series[2].Points.AddY(temp);
        }
        public void addValueD(double temp)
        {
            chart1.Series[3].Points.AddY(temp);
        }
    }
}
