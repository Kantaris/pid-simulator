namespace Simulator
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
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.initTempBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.targetTemp3Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.targetTemp2Box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.targetTemp1Box = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sampleRateBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kiBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kpBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.speadBox = new System.Windows.Forms.TextBox();
            this.heatSpreadBox = new System.Windows.Forms.Label();
            this.tempThresholdBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tempDecreaseBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tempIncreaseBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readErrorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minTempBox
            // 
            this.minTempBox.Location = new System.Drawing.Point(35, 231);
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(208, 20);
            this.minTempBox.TabIndex = 44;
            this.minTempBox.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lowest reachable temperature:";
            // 
            // maxTempBox
            // 
            this.maxTempBox.Location = new System.Drawing.Point(35, 192);
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(208, 20);
            this.maxTempBox.TabIndex = 42;
            this.maxTempBox.Text = "1300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Maximum reachable temperature:";
            // 
            // initTempBox
            // 
            this.initTempBox.Location = new System.Drawing.Point(632, 207);
            this.initTempBox.Name = "initTempBox";
            this.initTempBox.Size = new System.Drawing.Size(208, 20);
            this.initTempBox.TabIndex = 40;
            this.initTempBox.Text = "25";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(629, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Initial temperature (C):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(632, 245);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(208, 23);
            this.startButton.TabIndex = 38;
            this.startButton.Text = "Run Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // targetTemp3Box
            // 
            this.targetTemp3Box.Location = new System.Drawing.Point(632, 168);
            this.targetTemp3Box.Name = "targetTemp3Box";
            this.targetTemp3Box.Size = new System.Drawing.Size(208, 20);
            this.targetTemp3Box.TabIndex = 37;
            this.targetTemp3Box.Text = "1121";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Target temperature 3 (C):";
            // 
            // targetTemp2Box
            // 
            this.targetTemp2Box.Location = new System.Drawing.Point(632, 129);
            this.targetTemp2Box.Name = "targetTemp2Box";
            this.targetTemp2Box.Size = new System.Drawing.Size(208, 20);
            this.targetTemp2Box.TabIndex = 35;
            this.targetTemp2Box.Text = "1060";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(629, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Target temperature 2 (C):";
            // 
            // targetTemp1Box
            // 
            this.targetTemp1Box.Location = new System.Drawing.Point(632, 90);
            this.targetTemp1Box.Name = "targetTemp1Box";
            this.targetTemp1Box.Size = new System.Drawing.Size(208, 20);
            this.targetTemp1Box.TabIndex = 33;
            this.targetTemp1Box.Text = "600";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(629, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Target temperature 1 (C):";
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(632, 51);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(208, 20);
            this.delayBox.TabIndex = 29;
            this.delayBox.Text = "30";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(629, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 28);
            this.label13.TabIndex = 28;
            this.label13.Text = "Delay on effect from output on temperature readings(seconds):";
            // 
            // sampleRateBox
            // 
            this.sampleRateBox.Location = new System.Drawing.Point(35, 36);
            this.sampleRateBox.Name = "sampleRateBox";
            this.sampleRateBox.Size = new System.Drawing.Size(208, 20);
            this.sampleRateBox.TabIndex = 24;
            this.sampleRateBox.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Temperature samples per second";
            // 
            // kdBox
            // 
            this.kdBox.Location = new System.Drawing.Point(354, 208);
            this.kdBox.Name = "kdBox";
            this.kdBox.Size = new System.Drawing.Size(208, 20);
            this.kdBox.TabIndex = 22;
            this.kdBox.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "K_d: Derivative gain:";
            // 
            // kiBox
            // 
            this.kiBox.Location = new System.Drawing.Point(354, 169);
            this.kiBox.Name = "kiBox";
            this.kiBox.Size = new System.Drawing.Size(208, 20);
            this.kiBox.TabIndex = 20;
            this.kiBox.Text = "0,0002";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "K_i: Integral gain";
            // 
            // kpBox
            // 
            this.kpBox.Location = new System.Drawing.Point(354, 130);
            this.kpBox.Name = "kpBox";
            this.kpBox.Size = new System.Drawing.Size(208, 20);
            this.kpBox.TabIndex = 18;
            this.kpBox.Text = "0,1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "K_p: Proportional gain:";
            // 
            // speadBox
            // 
            this.speadBox.Location = new System.Drawing.Point(354, 91);
            this.speadBox.Name = "speadBox";
            this.speadBox.Size = new System.Drawing.Size(208, 20);
            this.speadBox.TabIndex = 16;
            this.speadBox.Text = "1000";
            // 
            // heatSpreadBox
            // 
            this.heatSpreadBox.AutoSize = true;
            this.heatSpreadBox.Location = new System.Drawing.Point(351, 75);
            this.heatSpreadBox.Name = "heatSpreadBox";
            this.heatSpreadBox.Size = new System.Drawing.Size(94, 13);
            this.heatSpreadBox.TabIndex = 15;
            this.heatSpreadBox.Text = "Target hold time(s)";
            // 
            // tempThresholdBox
            // 
            this.tempThresholdBox.Location = new System.Drawing.Point(354, 52);
            this.tempThresholdBox.Name = "tempThresholdBox";
            this.tempThresholdBox.Size = new System.Drawing.Size(208, 20);
            this.tempThresholdBox.TabIndex = 14;
            this.tempThresholdBox.Text = "5";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(351, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "Always full power if difference between target and current temp exceds (C) :";
            // 
            // tempDecreaseBox2
            // 
            this.tempDecreaseBox2.Location = new System.Drawing.Point(35, 153);
            this.tempDecreaseBox2.Name = "tempDecreaseBox2";
            this.tempDecreaseBox2.Size = new System.Drawing.Size(208, 20);
            this.tempDecreaseBox2.TabIndex = 12;
            this.tempDecreaseBox2.Text = "0,7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Temperature decrease per second at no power at 1000C:";
            // 
            // tempIncreaseBox1
            // 
            this.tempIncreaseBox1.Location = new System.Drawing.Point(35, 114);
            this.tempIncreaseBox1.Name = "tempIncreaseBox1";
            this.tempIncreaseBox1.Size = new System.Drawing.Size(208, 20);
            this.tempIncreaseBox1.TabIndex = 4;
            this.tempIncreaseBox1.Text = "0,8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature increase per second at full power at 100C:";
            // 
            // readErrorBox
            // 
            this.readErrorBox.Location = new System.Drawing.Point(35, 75);
            this.readErrorBox.Name = "readErrorBox";
            this.readErrorBox.Size = new System.Drawing.Size(208, 20);
            this.readErrorBox.TabIndex = 2;
            this.readErrorBox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum temperature Read Error ( C ) :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Temperature interval  PID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 290);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minTempBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kiBox);
            this.Controls.Add(this.maxTempBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.readErrorBox);
            this.Controls.Add(this.initTempBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tempIncreaseBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetTemp3Box);
            this.Controls.Add(this.tempDecreaseBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.targetTemp2Box);
            this.Controls.Add(this.tempThresholdBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.heatSpreadBox);
            this.Controls.Add(this.targetTemp1Box);
            this.Controls.Add(this.speadBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.kpBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kdBox);
            this.Controls.Add(this.sampleRateBox);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox readErrorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kiBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kpBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox speadBox;
        private System.Windows.Forms.Label heatSpreadBox;
        private System.Windows.Forms.TextBox tempThresholdBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tempDecreaseBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tempIncreaseBox1;
        private System.Windows.Forms.TextBox sampleRateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox initTempBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox targetTemp3Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox targetTemp2Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox targetTemp1Box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
    }
}

