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
    public partial class FullView : Form
    {
        public FullView()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Title = "Time (Seconds)";
            chart1.ChartAreas[0].AxisY.Title = "Temperature (°C)";
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 8);
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 8);
        }

        public void addValueSector1(double temp)
        {
            chart1.Series[0].Points.AddY(temp);
        }

        public void finished()
        {
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisY.Minimum = (int)chart1.Series[0].Points[0].YValues[0];
        }
    }
}
