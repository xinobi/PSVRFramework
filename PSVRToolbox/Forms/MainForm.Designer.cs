﻿namespace PSVRToolbox
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.detectTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpFunctions = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpCinematic = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trkBrightness = new XComponent.SliderBar.MACTrackBar();
            this.trkSize = new XComponent.SliderBar.MACTrackBar();
            this.trkDistance = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.grpLeds = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.cbLeds = new System.Windows.Forms.ComboBox();
            this.trkLedIntensity = new XComponent.SliderBar.MACTrackBar();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblFirmware = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trkVolume = new XComponent.SliderBar.MACTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.chkHeadphones = new System.Windows.Forms.CheckBox();
            this.chkCinematic = new System.Windows.Forms.CheckBox();
            this.chkWorn = new System.Windows.Forms.CheckBox();
            this.chkHMDOn = new System.Windows.Forms.CheckBox();
            this.grpFunctions.SuspendLayout();
            this.grpCinematic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grpLeds.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detectTimer
            // 
            this.detectTimer.Enabled = true;
            this.detectTimer.Interval = 1000;
            this.detectTimer.Tick += new System.EventHandler(this.detectTimer_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Waiting for PS VR...";
            // 
            // grpFunctions
            // 
            this.grpFunctions.Controls.Add(this.button7);
            this.grpFunctions.Controls.Add(this.button6);
            this.grpFunctions.Controls.Add(this.button5);
            this.grpFunctions.Controls.Add(this.button4);
            this.grpFunctions.Controls.Add(this.button3);
            this.grpFunctions.Controls.Add(this.button2);
            this.grpFunctions.Controls.Add(this.button1);
            this.grpFunctions.Enabled = false;
            this.grpFunctions.Location = new System.Drawing.Point(12, 35);
            this.grpFunctions.Name = "grpFunctions";
            this.grpFunctions.Size = new System.Drawing.Size(179, 227);
            this.grpFunctions.TabIndex = 1;
            this.grpFunctions.TabStop = false;
            this.grpFunctions.Text = "Functions";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Shutdown";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Recenter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Enable Cinematic";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Enable VR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Enable tracking and VR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Headset off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Headset on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 501);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(445, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "PSVRToolbox";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // grpCinematic
            // 
            this.grpCinematic.Controls.Add(this.button15);
            this.grpCinematic.Controls.Add(this.pictureBox3);
            this.grpCinematic.Controls.Add(this.pictureBox2);
            this.grpCinematic.Controls.Add(this.pictureBox1);
            this.grpCinematic.Controls.Add(this.trkBrightness);
            this.grpCinematic.Controls.Add(this.trkSize);
            this.grpCinematic.Controls.Add(this.trkDistance);
            this.grpCinematic.Controls.Add(this.label1);
            this.grpCinematic.Enabled = false;
            this.grpCinematic.Location = new System.Drawing.Point(12, 268);
            this.grpCinematic.Name = "grpCinematic";
            this.grpCinematic.Size = new System.Drawing.Size(179, 227);
            this.grpCinematic.TabIndex = 15;
            this.grpCinematic.TabStop = false;
            this.grpCinematic.Text = "Cinematic mode";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(5, 193);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(167, 23);
            this.button15.TabIndex = 13;
            this.button15.Text = "Apply changes";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PSVRToolbox.Properties.Resources.icoBrigtness;
            this.pictureBox3.Location = new System.Drawing.Point(119, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PSVRToolbox.Properties.Resources.icoDistance;
            this.pictureBox2.Location = new System.Drawing.Point(65, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSVRToolbox.Properties.Resources.icoSize;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // trkBrightness
            // 
            this.trkBrightness.BackColor = System.Drawing.Color.Transparent;
            this.trkBrightness.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trkBrightness.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trkBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trkBrightness.IndentHeight = 6;
            this.trkBrightness.Location = new System.Drawing.Point(124, 67);
            this.trkBrightness.Maximum = 32;
            this.trkBrightness.Minimum = 0;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBrightness.Size = new System.Drawing.Size(38, 120);
            this.trkBrightness.TabIndex = 8;
            this.trkBrightness.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trkBrightness.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trkBrightness.TickFrequency = 4;
            this.trkBrightness.TickHeight = 4;
            this.trkBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkBrightness.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.trkBrightness.TrackerSize = new System.Drawing.Size(16, 16);
            this.trkBrightness.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkBrightness.TrackLineHeight = 3;
            this.trkBrightness.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkBrightness.Value = 32;
            // 
            // trkSize
            // 
            this.trkSize.BackColor = System.Drawing.Color.Transparent;
            this.trkSize.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trkSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trkSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trkSize.IndentHeight = 6;
            this.trkSize.Location = new System.Drawing.Point(16, 67);
            this.trkSize.Maximum = 80;
            this.trkSize.Minimum = 26;
            this.trkSize.Name = "trkSize";
            this.trkSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSize.Size = new System.Drawing.Size(38, 120);
            this.trkSize.TabIndex = 8;
            this.trkSize.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSize.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trkSize.TickFrequency = 6;
            this.trkSize.TickHeight = 4;
            this.trkSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkSize.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.trkSize.TrackerSize = new System.Drawing.Size(16, 16);
            this.trkSize.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkSize.TrackLineHeight = 3;
            this.trkSize.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkSize.Value = 50;
            // 
            // trkDistance
            // 
            this.trkDistance.BackColor = System.Drawing.Color.Transparent;
            this.trkDistance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trkDistance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trkDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trkDistance.IndentHeight = 6;
            this.trkDistance.Location = new System.Drawing.Point(70, 67);
            this.trkDistance.Maximum = 50;
            this.trkDistance.Minimum = 20;
            this.trkDistance.Name = "trkDistance";
            this.trkDistance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDistance.Size = new System.Drawing.Size(38, 120);
            this.trkDistance.TabIndex = 6;
            this.trkDistance.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trkDistance.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trkDistance.TickFrequency = 5;
            this.trkDistance.TickHeight = 4;
            this.trkDistance.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkDistance.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.trkDistance.TrackerSize = new System.Drawing.Size(16, 16);
            this.trkDistance.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkDistance.TrackLineHeight = 3;
            this.trkDistance.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkDistance.Value = 41;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screen size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PSVRToolbox.Properties.Resources.LEDIdentification;
            this.pictureBox4.Location = new System.Drawing.Point(6, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(245, 127);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Image = global::PSVRToolbox.Properties.Resources.config;
            this.btnSettings.Location = new System.Drawing.Point(422, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 33);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // grpLeds
            // 
            this.grpLeds.Controls.Add(this.button17);
            this.grpLeds.Controls.Add(this.cbLeds);
            this.grpLeds.Controls.Add(this.trkLedIntensity);
            this.grpLeds.Controls.Add(this.pictureBox4);
            this.grpLeds.Enabled = false;
            this.grpLeds.Location = new System.Drawing.Point(197, 268);
            this.grpLeds.Name = "grpLeds";
            this.grpLeds.Size = new System.Drawing.Size(260, 227);
            this.grpLeds.TabIndex = 18;
            this.grpLeds.TabStop = false;
            this.grpLeds.Text = "LED Setup";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(173, 195);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(78, 21);
            this.button17.TabIndex = 20;
            this.button17.Text = "Set";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // cbLeds
            // 
            this.cbLeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeds.FormattingEnabled = true;
            this.cbLeds.Items.AddRange(new object[] {
            "Led A",
            "Led B",
            "Led C",
            "Led D",
            "Led E",
            "Led F",
            "Led G",
            "Led H",
            "Led I",
            "All"});
            this.cbLeds.Location = new System.Drawing.Point(6, 195);
            this.cbLeds.Name = "cbLeds";
            this.cbLeds.Size = new System.Drawing.Size(161, 21);
            this.cbLeds.TabIndex = 19;
            this.cbLeds.SelectedIndexChanged += new System.EventHandler(this.cbLeds_SelectedIndexChanged);
            // 
            // trkLedIntensity
            // 
            this.trkLedIntensity.BackColor = System.Drawing.Color.Transparent;
            this.trkLedIntensity.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trkLedIntensity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trkLedIntensity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trkLedIntensity.IndentHeight = 6;
            this.trkLedIntensity.Location = new System.Drawing.Point(6, 152);
            this.trkLedIntensity.Maximum = 100;
            this.trkLedIntensity.Minimum = 0;
            this.trkLedIntensity.Name = "trkLedIntensity";
            this.trkLedIntensity.Size = new System.Drawing.Size(245, 33);
            this.trkLedIntensity.TabIndex = 18;
            this.trkLedIntensity.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trkLedIntensity.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trkLedIntensity.TickFrequency = 10;
            this.trkLedIntensity.TickHeight = 4;
            this.trkLedIntensity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkLedIntensity.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.trkLedIntensity.TrackerSize = new System.Drawing.Size(16, 16);
            this.trkLedIntensity.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkLedIntensity.TrackLineHeight = 3;
            this.trkLedIntensity.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkLedIntensity.Value = 72;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(6, 19);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(118, 13);
            this.lblSerial.TabIndex = 19;
            this.lblSerial.Text = "Device serial: unknown";
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.Location = new System.Drawing.Point(6, 38);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(136, 13);
            this.lblFirmware.TabIndex = 20;
            this.lblFirmware.Text = "Firmware version: unknown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trkVolume);
            this.groupBox1.Controls.Add(this.lblFirmware);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSerial);
            this.groupBox1.Controls.Add(this.chkMute);
            this.groupBox1.Controls.Add(this.chkHeadphones);
            this.groupBox1.Controls.Add(this.chkCinematic);
            this.groupBox1.Controls.Add(this.chkWorn);
            this.groupBox1.Controls.Add(this.chkHMDOn);
            this.groupBox1.Location = new System.Drawing.Point(197, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 227);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // trkVolume
            // 
            this.trkVolume.BackColor = System.Drawing.Color.Transparent;
            this.trkVolume.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trkVolume.Enabled = false;
            this.trkVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trkVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trkVolume.IndentHeight = 6;
            this.trkVolume.Location = new System.Drawing.Point(57, 165);
            this.trkVolume.Maximum = 50;
            this.trkVolume.Minimum = 0;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(194, 33);
            this.trkVolume.TabIndex = 19;
            this.trkVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trkVolume.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trkVolume.TickFrequency = 10;
            this.trkVolume.TickHeight = 4;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkVolume.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.trkVolume.TrackerSize = new System.Drawing.Size(16, 16);
            this.trkVolume.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkVolume.TrackLineHeight = 3;
            this.trkVolume.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.trkVolume.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // chkMute
            // 
            this.chkMute.AutoCheck = false;
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(9, 151);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(50, 17);
            this.chkMute.TabIndex = 4;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // chkHeadphones
            // 
            this.chkHeadphones.AutoCheck = false;
            this.chkHeadphones.AutoSize = true;
            this.chkHeadphones.Location = new System.Drawing.Point(9, 128);
            this.chkHeadphones.Name = "chkHeadphones";
            this.chkHeadphones.Size = new System.Drawing.Size(87, 17);
            this.chkHeadphones.TabIndex = 3;
            this.chkHeadphones.Text = "Headphones";
            this.chkHeadphones.UseVisualStyleBackColor = true;
            // 
            // chkCinematic
            // 
            this.chkCinematic.AutoCheck = false;
            this.chkCinematic.AutoSize = true;
            this.chkCinematic.Location = new System.Drawing.Point(9, 105);
            this.chkCinematic.Name = "chkCinematic";
            this.chkCinematic.Size = new System.Drawing.Size(72, 17);
            this.chkCinematic.TabIndex = 2;
            this.chkCinematic.Text = "Cinematic";
            this.chkCinematic.UseVisualStyleBackColor = true;
            // 
            // chkWorn
            // 
            this.chkWorn.AutoCheck = false;
            this.chkWorn.AutoSize = true;
            this.chkWorn.Location = new System.Drawing.Point(9, 82);
            this.chkWorn.Name = "chkWorn";
            this.chkWorn.Size = new System.Drawing.Size(52, 17);
            this.chkWorn.TabIndex = 1;
            this.chkWorn.Text = "Worn";
            this.chkWorn.UseVisualStyleBackColor = true;
            // 
            // chkHMDOn
            // 
            this.chkHMDOn.AutoCheck = false;
            this.chkHMDOn.AutoSize = true;
            this.chkHMDOn.Location = new System.Drawing.Point(9, 59);
            this.chkHMDOn.Name = "chkHMDOn";
            this.chkHMDOn.Size = new System.Drawing.Size(81, 17);
            this.chkHMDOn.TabIndex = 0;
            this.chkHMDOn.Text = "Headset on";
            this.chkHMDOn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLeds);
            this.Controls.Add(this.grpCinematic);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.grpFunctions);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSVRToolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFunctions.ResumeLayout(false);
            this.grpCinematic.ResumeLayout(false);
            this.grpCinematic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grpLeds.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer detectTimer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpFunctions;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox grpCinematic;
        private System.Windows.Forms.Label label1;
        private XComponent.SliderBar.MACTrackBar trkDistance;
        private XComponent.SliderBar.MACTrackBar trkBrightness;
        private XComponent.SliderBar.MACTrackBar trkSize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox grpLeds;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox cbLeds;
        private XComponent.SliderBar.MACTrackBar trkLedIntensity;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblFirmware;
        private System.Windows.Forms.GroupBox groupBox1;
        private XComponent.SliderBar.MACTrackBar trkVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.CheckBox chkHeadphones;
        private System.Windows.Forms.CheckBox chkCinematic;
        private System.Windows.Forms.CheckBox chkWorn;
        private System.Windows.Forms.CheckBox chkHMDOn;
    }
}

