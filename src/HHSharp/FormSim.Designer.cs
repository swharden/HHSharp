namespace HHSharp
{
    partial class FormSim
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.nudDurationMs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCm = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudEKLeak = new System.Windows.Forms.NumericUpDown();
            this.nudEK = new System.Windows.Forms.NumericUpDown();
            this.nudENa = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudGKLeak = new System.Windows.Forms.NumericUpDown();
            this.nudGK = new System.Windows.Forms.NumericUpDown();
            this.nudGNa = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbStimRamp = new System.Windows.Forms.RadioButton();
            this.rbStimSquare = new System.Windows.Forms.RadioButton();
            this.rbStimConstant = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.nudStimCurrent = new System.Windows.Forms.NumericUpDown();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDisplayCurrent = new System.Windows.Forms.RadioButton();
            this.rbDisplayActivity = new System.Windows.Forms.RadioButton();
            this.btnLaunchLive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationMs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEKLeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudENa)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGKLeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGNa)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStimCurrent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(3, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(863, 197);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.AxesChanged += new System.EventHandler(this.formsPlot1_AxesChanged);
            // 
            // nudDurationMs
            // 
            this.nudDurationMs.Location = new System.Drawing.Point(94, 15);
            this.nudDurationMs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDurationMs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDurationMs.Name = "nudDurationMs";
            this.nudDurationMs.Size = new System.Drawing.Size(103, 20);
            this.nudDurationMs.TabIndex = 1;
            this.nudDurationMs.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudDurationMs.ValueChanged += new System.EventHandler(this.nudDurationMs_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duration (ms):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudCm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudDurationMs);
            this.groupBox1.Location = new System.Drawing.Point(12, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cm: (µF/cm²)";
            // 
            // nudCm
            // 
            this.nudCm.DecimalPlaces = 1;
            this.nudCm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCm.Location = new System.Drawing.Point(94, 41);
            this.nudCm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCm.Name = "nudCm";
            this.nudCm.Size = new System.Drawing.Size(103, 20);
            this.nudCm.TabIndex = 7;
            this.nudCm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCm.ValueChanged += new System.EventHandler(this.nudCm_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "HHSharp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hodgkin-Huxley Simulator";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.Blue;
            this.lblUrl.Location = new System.Drawing.Point(14, 52);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(171, 13);
            this.lblUrl.TabIndex = 8;
            this.lblUrl.Text = "github.com/swharden/HHSharp";
            this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
            this.lblUrl.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.lblUrl.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudEKLeak);
            this.groupBox2.Controls.Add(this.nudEK);
            this.groupBox2.Controls.Add(this.nudENa);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equilibrium Potential (mV)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Kleak:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "K:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Na:";
            // 
            // nudEKLeak
            // 
            this.nudEKLeak.Location = new System.Drawing.Point(54, 73);
            this.nudEKLeak.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEKLeak.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudEKLeak.Name = "nudEKLeak";
            this.nudEKLeak.Size = new System.Drawing.Size(62, 20);
            this.nudEKLeak.TabIndex = 5;
            this.nudEKLeak.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudEKLeak.ValueChanged += new System.EventHandler(this.nudEKLeak_ValueChanged);
            // 
            // nudEK
            // 
            this.nudEK.Location = new System.Drawing.Point(54, 47);
            this.nudEK.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEK.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudEK.Name = "nudEK";
            this.nudEK.Size = new System.Drawing.Size(62, 20);
            this.nudEK.TabIndex = 4;
            this.nudEK.Value = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.nudEK.ValueChanged += new System.EventHandler(this.nudEK_ValueChanged);
            // 
            // nudENa
            // 
            this.nudENa.Location = new System.Drawing.Point(54, 21);
            this.nudENa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudENa.Name = "nudENa";
            this.nudENa.Size = new System.Drawing.Size(62, 20);
            this.nudENa.TabIndex = 2;
            this.nudENa.Value = new decimal(new int[] {
            115,
            0,
            0,
            0});
            this.nudENa.ValueChanged += new System.EventHandler(this.nudENa_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.nudGKLeak);
            this.groupBox3.Controls.Add(this.nudGK);
            this.groupBox3.Controls.Add(this.nudGNa);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 104);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channel Conductance (µA/cm²)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kleak:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "K:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Na:";
            // 
            // nudGKLeak
            // 
            this.nudGKLeak.DecimalPlaces = 2;
            this.nudGKLeak.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGKLeak.Location = new System.Drawing.Point(54, 73);
            this.nudGKLeak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGKLeak.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudGKLeak.Name = "nudGKLeak";
            this.nudGKLeak.Size = new System.Drawing.Size(62, 20);
            this.nudGKLeak.TabIndex = 5;
            this.nudGKLeak.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.nudGKLeak.ValueChanged += new System.EventHandler(this.nudGKLeak_ValueChanged);
            // 
            // nudGK
            // 
            this.nudGK.Location = new System.Drawing.Point(54, 47);
            this.nudGK.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGK.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudGK.Name = "nudGK";
            this.nudGK.Size = new System.Drawing.Size(62, 20);
            this.nudGK.TabIndex = 4;
            this.nudGK.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudGK.ValueChanged += new System.EventHandler(this.nudGK_ValueChanged);
            // 
            // nudGNa
            // 
            this.nudGNa.Location = new System.Drawing.Point(54, 21);
            this.nudGNa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGNa.Name = "nudGNa";
            this.nudGNa.Size = new System.Drawing.Size(62, 20);
            this.nudGNa.TabIndex = 2;
            this.nudGNa.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudGNa.ValueChanged += new System.EventHandler(this.nudGNa_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbStimRamp);
            this.groupBox4.Controls.Add(this.rbStimSquare);
            this.groupBox4.Controls.Add(this.rbStimConstant);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nudStimCurrent);
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 71);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stimulation";
            // 
            // rbStimRamp
            // 
            this.rbStimRamp.AutoSize = true;
            this.rbStimRamp.Location = new System.Drawing.Point(146, 45);
            this.rbStimRamp.Name = "rbStimRamp";
            this.rbStimRamp.Size = new System.Drawing.Size(48, 17);
            this.rbStimRamp.TabIndex = 7;
            this.rbStimRamp.Text = "ramp";
            this.rbStimRamp.UseVisualStyleBackColor = true;
            this.rbStimRamp.CheckedChanged += new System.EventHandler(this.rbStimRamp_CheckedChanged);
            // 
            // rbStimSquare
            // 
            this.rbStimSquare.AutoSize = true;
            this.rbStimSquare.Checked = true;
            this.rbStimSquare.Location = new System.Drawing.Point(83, 45);
            this.rbStimSquare.Name = "rbStimSquare";
            this.rbStimSquare.Size = new System.Drawing.Size(57, 17);
            this.rbStimSquare.TabIndex = 6;
            this.rbStimSquare.TabStop = true;
            this.rbStimSquare.Text = "square";
            this.rbStimSquare.UseVisualStyleBackColor = true;
            this.rbStimSquare.CheckedChanged += new System.EventHandler(this.rbStimSquare_CheckedChanged);
            // 
            // rbStimConstant
            // 
            this.rbStimConstant.AutoSize = true;
            this.rbStimConstant.Location = new System.Drawing.Point(11, 45);
            this.rbStimConstant.Name = "rbStimConstant";
            this.rbStimConstant.Size = new System.Drawing.Size(66, 17);
            this.rbStimConstant.TabIndex = 5;
            this.rbStimConstant.Text = "constant";
            this.rbStimConstant.UseVisualStyleBackColor = true;
            this.rbStimConstant.CheckedChanged += new System.EventHandler(this.rbStimConstant_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Current (µA/cm²):";
            // 
            // nudStimCurrent
            // 
            this.nudStimCurrent.Location = new System.Drawing.Point(105, 19);
            this.nudStimCurrent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStimCurrent.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudStimCurrent.Name = "nudStimCurrent";
            this.nudStimCurrent.Size = new System.Drawing.Size(62, 20);
            this.nudStimCurrent.TabIndex = 3;
            this.nudStimCurrent.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStimCurrent.ValueChanged += new System.EventHandler(this.nudStimCurrent_ValueChanged);
            // 
            // formsPlot2
            // 
            this.formsPlot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot2.Location = new System.Drawing.Point(3, 409);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(863, 197);
            this.formsPlot2.TabIndex = 12;
            this.formsPlot2.AxesChanged += new System.EventHandler(this.formsPlot2_AxesChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.formsPlot2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(221, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 609);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // formsPlot3
            // 
            this.formsPlot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot3.Location = new System.Drawing.Point(3, 206);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(863, 197);
            this.formsPlot3.TabIndex = 13;
            this.formsPlot3.AxesChanged += new System.EventHandler(this.formsPlot3_AxesChanged);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Enabled = false;
            this.rtbStatus.Location = new System.Drawing.Point(12, 515);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(203, 53);
            this.rtbStatus.TabIndex = 15;
            this.rtbStatus.Text = "status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDisplayCurrent);
            this.groupBox5.Controls.Add(this.rbDisplayActivity);
            this.groupBox5.Location = new System.Drawing.Point(12, 467);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 42);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display";
            // 
            // rbDisplayCurrent
            // 
            this.rbDisplayCurrent.AutoSize = true;
            this.rbDisplayCurrent.Location = new System.Drawing.Point(94, 19);
            this.rbDisplayCurrent.Name = "rbDisplayCurrent";
            this.rbDisplayCurrent.Size = new System.Drawing.Size(106, 17);
            this.rbDisplayCurrent.TabIndex = 7;
            this.rbDisplayCurrent.Text = "Channel Currents";
            this.rbDisplayCurrent.UseVisualStyleBackColor = true;
            this.rbDisplayCurrent.CheckedChanged += new System.EventHandler(this.rbDisplayCurrent_CheckedChanged);
            // 
            // rbDisplayActivity
            // 
            this.rbDisplayActivity.AutoSize = true;
            this.rbDisplayActivity.Checked = true;
            this.rbDisplayActivity.Location = new System.Drawing.Point(6, 19);
            this.rbDisplayActivity.Name = "rbDisplayActivity";
            this.rbDisplayActivity.Size = new System.Drawing.Size(85, 17);
            this.rbDisplayActivity.TabIndex = 6;
            this.rbDisplayActivity.TabStop = true;
            this.rbDisplayActivity.Text = "Gate Activity";
            this.rbDisplayActivity.UseVisualStyleBackColor = true;
            this.rbDisplayActivity.CheckedChanged += new System.EventHandler(this.rbDisplayActivity_CheckedChanged);
            // 
            // btnLaunchLive
            // 
            this.btnLaunchLive.Location = new System.Drawing.Point(12, 598);
            this.btnLaunchLive.Name = "btnLaunchLive";
            this.btnLaunchLive.Size = new System.Drawing.Size(144, 23);
            this.btnLaunchLive.TabIndex = 16;
            this.btnLaunchLive.Text = "Launch realtime simulator";
            this.btnLaunchLive.UseVisualStyleBackColor = true;
            this.btnLaunchLive.Click += new System.EventHandler(this.btnLaunchLive_Click);
            // 
            // FormSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 633);
            this.Controls.Add(this.btnLaunchLive);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSim";
            this.Text = "HHSharp";
            this.Load += new System.EventHandler(this.FormSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationMs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEKLeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudENa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGKLeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGNa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStimCurrent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.NumericUpDown nudDurationMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudENa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudEKLeak;
        private System.Windows.Forms.NumericUpDown nudEK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudGKLeak;
        private System.Windows.Forms.NumericUpDown nudGK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudGNa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbStimRamp;
        private System.Windows.Forms.RadioButton rbStimSquare;
        private System.Windows.Forms.RadioButton rbStimConstant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudStimCurrent;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private ScottPlot.FormsPlot formsPlot3;
        private System.Windows.Forms.RadioButton rbDisplayCurrent;
        private System.Windows.Forms.RadioButton rbDisplayActivity;
        private System.Windows.Forms.Button btnLaunchLive;
    }
}

