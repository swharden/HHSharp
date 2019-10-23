﻿namespace HHSharp
{
    partial class FormLive
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
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.nudCurrentConstant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCurrentPulse = new System.Windows.Forms.NumericUpDown();
            this.nudPulseLengthMs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeliverPulse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSimulationSlow = new System.Windows.Forms.CheckBox();
            this.cbSimulationRun = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulseLengthMs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.Location = new System.Drawing.Point(168, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1045, 383);
            this.formsPlot1.TabIndex = 0;
            // 
            // nudCurrentConstant
            // 
            this.nudCurrentConstant.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCurrentConstant.Location = new System.Drawing.Point(6, 19);
            this.nudCurrentConstant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCurrentConstant.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudCurrentConstant.Name = "nudCurrentConstant";
            this.nudCurrentConstant.Size = new System.Drawing.Size(86, 20);
            this.nudCurrentConstant.TabIndex = 1;
            this.nudCurrentConstant.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "µA/cm²";
            // 
            // nudCurrentPulse
            // 
            this.nudCurrentPulse.Location = new System.Drawing.Point(6, 19);
            this.nudCurrentPulse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCurrentPulse.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudCurrentPulse.Name = "nudCurrentPulse";
            this.nudCurrentPulse.Size = new System.Drawing.Size(86, 20);
            this.nudCurrentPulse.TabIndex = 4;
            this.nudCurrentPulse.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudPulseLengthMs
            // 
            this.nudPulseLengthMs.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPulseLengthMs.Location = new System.Drawing.Point(6, 45);
            this.nudPulseLengthMs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPulseLengthMs.Name = "nudPulseLengthMs";
            this.nudPulseLengthMs.Size = new System.Drawing.Size(86, 20);
            this.nudPulseLengthMs.TabIndex = 5;
            this.nudPulseLengthMs.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeliverPulse);
            this.groupBox1.Controls.Add(this.nudCurrentPulse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudPulseLengthMs);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 101);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stimulus";
            // 
            // btnDeliverPulse
            // 
            this.btnDeliverPulse.Location = new System.Drawing.Point(6, 71);
            this.btnDeliverPulse.Name = "btnDeliverPulse";
            this.btnDeliverPulse.Size = new System.Drawing.Size(86, 23);
            this.btnDeliverPulse.TabIndex = 7;
            this.btnDeliverPulse.Text = "deliver";
            this.btnDeliverPulse.UseVisualStyleBackColor = true;
            this.btnDeliverPulse.Click += new System.EventHandler(this.btnDeliverPulse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudCurrentConstant);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 47);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Constant Current";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "µA/cm²";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbSimulationSlow);
            this.groupBox3.Controls.Add(this.cbSimulationRun);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 88);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // cbSimulationSlow
            // 
            this.cbSimulationSlow.AutoSize = true;
            this.cbSimulationSlow.Location = new System.Drawing.Point(6, 42);
            this.cbSimulationSlow.Name = "cbSimulationSlow";
            this.cbSimulationSlow.Size = new System.Drawing.Size(81, 17);
            this.cbSimulationSlow.TabIndex = 1;
            this.cbSimulationSlow.Text = "slow motion";
            this.cbSimulationSlow.UseVisualStyleBackColor = true;
            // 
            // cbSimulationRun
            // 
            this.cbSimulationRun.AutoSize = true;
            this.cbSimulationRun.Checked = true;
            this.cbSimulationRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSimulationRun.Location = new System.Drawing.Point(6, 19);
            this.cbSimulationRun.Name = "cbSimulationRun";
            this.cbSimulationRun.Size = new System.Drawing.Size(41, 17);
            this.cbSimulationRun.TabIndex = 0;
            this.cbSimulationRun.Text = "run";
            this.cbSimulationRun.UseVisualStyleBackColor = true;
            this.cbSimulationRun.CheckedChanged += new System.EventHandler(this.cbSimulationRun_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Enabled = false;
            this.lblTime.Location = new System.Drawing.Point(45, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "12.345 sec";
            // 
            // FormLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formsPlot1);
            this.Name = "FormLive";
            this.Text = "FormLive";
            this.Load += new System.EventHandler(this.FormLive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulseLengthMs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.NumericUpDown nudCurrentConstant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCurrentPulse;
        private System.Windows.Forms.NumericUpDown nudPulseLengthMs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeliverPulse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSimulationSlow;
        private System.Windows.Forms.CheckBox cbSimulationRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}