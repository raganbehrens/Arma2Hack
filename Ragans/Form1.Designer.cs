using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Ragans
{
    partial class MapForm
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
            this.refTick = new System.Windows.Forms.CheckBox();
            this.refTimer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zoombar = new System.Windows.Forms.TrackBar();
            this.StayCenter = new System.Windows.Forms.CheckBox();
            this.NoFatigue = new System.Windows.Forms.CheckBox();
            this.TeleportButton = new System.Windows.Forms.Button();
            this.TeleY = new System.Windows.Forms.TextBox();
            this.TeleX = new System.Windows.Forms.TextBox();
            this.ThermalBox = new System.Windows.Forms.CheckBox();
            this.NeafTele = new System.Windows.Forms.Button();
            this.ElektroTele = new System.Windows.Forms.Button();
            this.NwafTele = new System.Windows.Forms.Button();
            this.DavidTele = new System.Windows.Forms.Button();
            this.BalotaTele = new System.Windows.Forms.Button();
            this.DevilsTele = new System.Windows.Forms.Button();
            this.NoRecoil = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.UpZ = new System.Windows.Forms.Button();
            this.DownZ = new System.Windows.Forms.Button();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ShowVehiclesBox = new System.Windows.Forms.CheckBox();
            this.ShowAIBox = new System.Windows.Forms.CheckBox();
            this.ShowPlayersBox = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.FixLegs = new System.Windows.Forms.Button();
            this.StopBE = new System.Windows.Forms.Button();
            this.MapSelect = new System.Windows.Forms.ComboBox();
            this.objImageViewer1 = new Balance.objImageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.zoombar)).BeginInit();
            this.SuspendLayout();
            // 
            // refTick
            // 
            this.refTick.AutoSize = true;
            this.refTick.Location = new System.Drawing.Point(997, 12);
            this.refTick.Name = "refTick";
            this.refTick.Size = new System.Drawing.Size(80, 21);
            this.refTick.TabIndex = 0;
            this.refTick.Text = "Refresh";
            this.refTick.UseVisualStyleBackColor = true;
            this.refTick.CheckedChanged += new System.EventHandler(this.refTick_CheckedChanged);
            // 
            // refTimer
            // 
            this.refTimer.Location = new System.Drawing.Point(1093, 9);
            this.refTimer.Name = "refTimer";
            this.refTimer.Size = new System.Drawing.Size(52, 22);
            this.refTimer.TabIndex = 1;
            this.refTimer.Text = "100";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1120, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(25, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "ms";
            // 
            // zoombar
            // 
            this.zoombar.Location = new System.Drawing.Point(990, 35);
            this.zoombar.Maximum = 40;
            this.zoombar.Name = "zoombar";
            this.zoombar.Size = new System.Drawing.Size(155, 56);
            this.zoombar.TabIndex = 4;
            this.zoombar.TickFrequency = 2;
            this.zoombar.Scroll += new System.EventHandler(this.zoombar_Scroll);
            // 
            // StayCenter
            // 
            this.StayCenter.AutoSize = true;
            this.StayCenter.Location = new System.Drawing.Point(997, 123);
            this.StayCenter.Name = "StayCenter";
            this.StayCenter.Size = new System.Drawing.Size(72, 21);
            this.StayCenter.TabIndex = 6;
            this.StayCenter.Text = "Center";
            this.StayCenter.UseVisualStyleBackColor = true;
            this.StayCenter.CheckedChanged += new System.EventHandler(this.StayCenter_CheckedChanged);
            // 
            // NoFatigue
            // 
            this.NoFatigue.AutoSize = true;
            this.NoFatigue.Location = new System.Drawing.Point(997, 147);
            this.NoFatigue.Name = "NoFatigue";
            this.NoFatigue.Size = new System.Drawing.Size(95, 21);
            this.NoFatigue.TabIndex = 7;
            this.NoFatigue.Text = "NoFatigue";
            this.NoFatigue.UseVisualStyleBackColor = true;
            this.NoFatigue.CheckedChanged += new System.EventHandler(this.NoFatigue_CheckedChanged);
            // 
            // TeleportButton
            // 
            this.TeleportButton.Location = new System.Drawing.Point(997, 382);
            this.TeleportButton.Name = "TeleportButton";
            this.TeleportButton.Size = new System.Drawing.Size(75, 23);
            this.TeleportButton.TabIndex = 9;
            this.TeleportButton.Text = "TeleportButton";
            this.TeleportButton.UseVisualStyleBackColor = true;
            this.TeleportButton.Click += new System.EventHandler(this.TeleportButton_Click_1);
            // 
            // TeleY
            // 
            this.TeleY.Location = new System.Drawing.Point(997, 347);
            this.TeleY.Name = "TeleY";
            this.TeleY.Size = new System.Drawing.Size(100, 22);
            this.TeleY.TabIndex = 10;
            // 
            // TeleX
            // 
            this.TeleX.Location = new System.Drawing.Point(997, 319);
            this.TeleX.Name = "TeleX";
            this.TeleX.Size = new System.Drawing.Size(100, 22);
            this.TeleX.TabIndex = 11;
            this.TeleX.TextChanged += new System.EventHandler(this.TeleX_TextChanged);
            // 
            // ThermalBox
            // 
            this.ThermalBox.AutoSize = true;
            this.ThermalBox.Location = new System.Drawing.Point(1089, 123);
            this.ThermalBox.Name = "ThermalBox";
            this.ThermalBox.Size = new System.Drawing.Size(82, 21);
            this.ThermalBox.TabIndex = 12;
            this.ThermalBox.Text = "Thermal";
            this.ThermalBox.UseVisualStyleBackColor = true;
            this.ThermalBox.CheckedChanged += new System.EventHandler(this.ThermalBox_CheckedChanged);
            // 
            // NeafTele
            // 
            this.NeafTele.Location = new System.Drawing.Point(999, 418);
            this.NeafTele.Name = "NeafTele";
            this.NeafTele.Size = new System.Drawing.Size(75, 23);
            this.NeafTele.TabIndex = 13;
            this.NeafTele.Text = "Neaf";
            this.NeafTele.UseVisualStyleBackColor = true;
            this.NeafTele.Click += new System.EventHandler(this.NeafTele_Click);
            // 
            // ElektroTele
            // 
            this.ElektroTele.Location = new System.Drawing.Point(998, 476);
            this.ElektroTele.Name = "ElektroTele";
            this.ElektroTele.Size = new System.Drawing.Size(75, 23);
            this.ElektroTele.TabIndex = 14;
            this.ElektroTele.Text = "Elektro";
            this.ElektroTele.UseVisualStyleBackColor = true;
            this.ElektroTele.Click += new System.EventHandler(this.ElektroTele_Click);
            // 
            // NwafTele
            // 
            this.NwafTele.Location = new System.Drawing.Point(999, 447);
            this.NwafTele.Name = "NwafTele";
            this.NwafTele.Size = new System.Drawing.Size(75, 23);
            this.NwafTele.TabIndex = 15;
            this.NwafTele.Text = "Nwaf";
            this.NwafTele.UseVisualStyleBackColor = true;
            this.NwafTele.Click += new System.EventHandler(this.NwafTele_Click);
            // 
            // DavidTele
            // 
            this.DavidTele.Location = new System.Drawing.Point(1080, 418);
            this.DavidTele.Name = "DavidTele";
            this.DavidTele.Size = new System.Drawing.Size(75, 23);
            this.DavidTele.TabIndex = 16;
            this.DavidTele.Text = "David";
            this.DavidTele.UseVisualStyleBackColor = true;
            this.DavidTele.Click += new System.EventHandler(this.DavidTele_Click);
            // 
            // BalotaTele
            // 
            this.BalotaTele.Location = new System.Drawing.Point(1079, 447);
            this.BalotaTele.Name = "BalotaTele";
            this.BalotaTele.Size = new System.Drawing.Size(75, 23);
            this.BalotaTele.TabIndex = 17;
            this.BalotaTele.Text = "Balota";
            this.BalotaTele.UseVisualStyleBackColor = true;
            this.BalotaTele.Click += new System.EventHandler(this.BalotaTele_Click);
            // 
            // DevilsTele
            // 
            this.DevilsTele.Location = new System.Drawing.Point(1080, 476);
            this.DevilsTele.Name = "DevilsTele";
            this.DevilsTele.Size = new System.Drawing.Size(75, 23);
            this.DevilsTele.TabIndex = 18;
            this.DevilsTele.Text = "Devils";
            this.DevilsTele.UseVisualStyleBackColor = true;
            this.DevilsTele.Click += new System.EventHandler(this.DevilsTele_Click);
            // 
            // NoRecoil
            // 
            this.NoRecoil.AutoSize = true;
            this.NoRecoil.Location = new System.Drawing.Point(1089, 147);
            this.NoRecoil.Name = "NoRecoil";
            this.NoRecoil.Size = new System.Drawing.Size(87, 21);
            this.NoRecoil.TabIndex = 19;
            this.NoRecoil.Text = "NoRecoil";
            this.NoRecoil.UseVisualStyleBackColor = true;
            this.NoRecoil.CheckedChanged += new System.EventHandler(this.NoRecoil_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1039, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UpZ
            // 
            this.UpZ.Location = new System.Drawing.Point(999, 505);
            this.UpZ.Name = "UpZ";
            this.UpZ.Size = new System.Drawing.Size(75, 23);
            this.UpZ.TabIndex = 21;
            this.UpZ.Text = "Move Up";
            this.UpZ.UseVisualStyleBackColor = true;
            this.UpZ.Click += new System.EventHandler(this.UpZ_Click);
            // 
            // DownZ
            // 
            this.DownZ.Location = new System.Drawing.Point(1079, 505);
            this.DownZ.Name = "DownZ";
            this.DownZ.Size = new System.Drawing.Size(75, 23);
            this.DownZ.TabIndex = 22;
            this.DownZ.Text = "Move Down";
            this.DownZ.UseVisualStyleBackColor = true;
            this.DownZ.Click += new System.EventHandler(this.DownZ_Click);
            // 
            // DebugBox
            // 
            this.DebugBox.Location = new System.Drawing.Point(999, 601);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(100, 22);
            this.DebugBox.TabIndex = 24;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1200, 382);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ShowVehiclesBox
            // 
            this.ShowVehiclesBox.AutoSize = true;
            this.ShowVehiclesBox.Location = new System.Drawing.Point(1135, 287);
            this.ShowVehiclesBox.Name = "ShowVehiclesBox";
            this.ShowVehiclesBox.Size = new System.Drawing.Size(121, 21);
            this.ShowVehiclesBox.TabIndex = 26;
            this.ShowVehiclesBox.Text = "Show Vehicles";
            this.ShowVehiclesBox.UseVisualStyleBackColor = true;
            this.ShowVehiclesBox.CheckedChanged += new System.EventHandler(this.ShowVehiclesBox_CheckedChanged);
            // 
            // ShowAIBox
            // 
            this.ShowAIBox.AutoSize = true;
            this.ShowAIBox.Location = new System.Drawing.Point(1135, 260);
            this.ShowAIBox.Name = "ShowAIBox";
            this.ShowAIBox.Size = new System.Drawing.Size(80, 21);
            this.ShowAIBox.TabIndex = 27;
            this.ShowAIBox.Text = "Show AI";
            this.ShowAIBox.UseVisualStyleBackColor = true;
            this.ShowAIBox.CheckedChanged += new System.EventHandler(this.ShowAIBox_CheckedChanged);
            // 
            // ShowPlayersBox
            // 
            this.ShowPlayersBox.AutoSize = true;
            this.ShowPlayersBox.Location = new System.Drawing.Point(1135, 231);
            this.ShowPlayersBox.Name = "ShowPlayersBox";
            this.ShowPlayersBox.Size = new System.Drawing.Size(115, 21);
            this.ShowPlayersBox.TabIndex = 28;
            this.ShowPlayersBox.Text = "Show Players";
            this.ShowPlayersBox.UseVisualStyleBackColor = true;
            this.ShowPlayersBox.CheckedChanged += new System.EventHandler(this.ShowPlayersBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(1280, 462);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 29;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // FixLegs
            // 
            this.FixLegs.Location = new System.Drawing.Point(999, 199);
            this.FixLegs.Name = "FixLegs";
            this.FixLegs.Size = new System.Drawing.Size(75, 23);
            this.FixLegs.TabIndex = 0;
            this.FixLegs.Text = "Fix Legs";
            this.FixLegs.UseVisualStyleBackColor = true;
            this.FixLegs.Click += new System.EventHandler(this.FixLegs_Click);
            // 
            // StopBE
            // 
            this.StopBE.Location = new System.Drawing.Point(999, 231);
            this.StopBE.Name = "StopBE";
            this.StopBE.Size = new System.Drawing.Size(75, 23);
            this.StopBE.TabIndex = 31;
            this.StopBE.Text = "Stop BE";
            this.StopBE.UseVisualStyleBackColor = true;
            this.StopBE.Click += new System.EventHandler(this.StopBE_Click);
            // 
            // MapSelect
            // 
            this.MapSelect.FormattingEnabled = true;
            this.MapSelect.Items.AddRange(new object[] {
            "Chernarus",
            "Namalsk",
            "Taviana"});
            this.MapSelect.Location = new System.Drawing.Point(997, 274);
            this.MapSelect.Name = "MapSelect";
            this.MapSelect.Size = new System.Drawing.Size(121, 24);
            this.MapSelect.TabIndex = 32;
            // 
            // objImageViewer1
            // 
            this.objImageViewer1.AutoScroll = true;
            this.objImageViewer1.AutoScrollMargin = new System.Drawing.Size(980, 980);
            this.objImageViewer1.AutoScrollMinSize = new System.Drawing.Size(600, 600);
            this.objImageViewer1.Image = global::Ragans.Properties.Resources.Namalsk2;
            this.objImageViewer1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.objImageViewer1.Location = new System.Drawing.Point(12, 17);
            this.objImageViewer1.Name = "objImageViewer1";
            this.objImageViewer1.Size = new System.Drawing.Size(980, 980);
            this.objImageViewer1.TabIndex = 5;
            this.objImageViewer1.Text = "objImageViewer1";
            this.objImageViewer1.Zoom = 1F;
            // 
            // MapForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1927, 812);
            this.Controls.Add(this.MapSelect);
            this.Controls.Add(this.StopBE);
            this.Controls.Add(this.FixLegs);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.ShowPlayersBox);
            this.Controls.Add(this.ShowAIBox);
            this.Controls.Add(this.ShowVehiclesBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.DownZ);
            this.Controls.Add(this.UpZ);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NoRecoil);
            this.Controls.Add(this.DevilsTele);
            this.Controls.Add(this.BalotaTele);
            this.Controls.Add(this.DavidTele);
            this.Controls.Add(this.ElektroTele);
            this.Controls.Add(this.NwafTele);
            this.Controls.Add(this.NeafTele);
            this.Controls.Add(this.ThermalBox);
            this.Controls.Add(this.TeleX);
            this.Controls.Add(this.TeleY);
            this.Controls.Add(this.TeleportButton);
            this.Controls.Add(this.NoFatigue);
            this.Controls.Add(this.StayCenter);
            this.Controls.Add(this.objImageViewer1);
            this.Controls.Add(this.zoombar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.refTimer);
            this.Controls.Add(this.refTick);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapForm";
            this.Opacity = 0.5D;
            this.Text = "DayZ Map";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoombar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox refTick;
        private TextBox refTimer;
        private TextBox textBox1;
        private TrackBar zoombar;
        private Balance.objImageViewer objImageViewer1;
        private CheckBox StayCenter;
        private CheckBox NoFatigue;
        private Button TeleportButton;
        private TextBox TeleY;
        private TextBox TeleX;
        private CheckBox ThermalBox;
        private Button NeafTele;
        private Button ElektroTele;
        private Button NwafTele;
        private Button DavidTele;
        private Button BalotaTele;
        private Button DevilsTele;
        private CheckBox NoRecoil;
        private CheckBox checkBox1;
        private Button UpZ;
        private Button DownZ;
        private TextBox DebugBox;
        private CheckBox checkBox2;
        private CheckBox ShowVehiclesBox;
        private CheckBox ShowAIBox;
        private CheckBox ShowPlayersBox;
        private CheckBox checkBox6;
        private Button FixLegs;
        private Button StopBE;
        private ComboBox MapSelect;
    }
}