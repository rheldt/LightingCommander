using MultiPanel;

namespace LightingCommander
{
    partial class frmMain
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lnkScenes = new LightingCommander.Controls.DarkLink();
            this.lnkChannels = new LightingCommander.Controls.DarkLink();
            this.lnkSetup = new LightingCommander.Controls.DarkLink();
            this.timerDmx = new System.Windows.Forms.Timer(this.components);
            this.pnlPages = new MultiPanel.MultiPanel();
            this.pgScenes = new MultiPanel.MultiPanelPage();
            this.btnScene13 = new System.Windows.Forms.Button();
            this.lblActiveCue = new System.Windows.Forms.Label();
            this.lblCues = new System.Windows.Forms.Label();
            this.lblActiveScene = new System.Windows.Forms.Label();
            this.lblScenes = new System.Windows.Forms.Label();
            this.btnCue12 = new System.Windows.Forms.Button();
            this.btnCue11 = new System.Windows.Forms.Button();
            this.btnCue10 = new System.Windows.Forms.Button();
            this.btnCue9 = new System.Windows.Forms.Button();
            this.btnCue8 = new System.Windows.Forms.Button();
            this.btnBlackoutCue = new System.Windows.Forms.Button();
            this.btnCue7 = new System.Windows.Forms.Button();
            this.btnCue6 = new System.Windows.Forms.Button();
            this.btnCue5 = new System.Windows.Forms.Button();
            this.btnCue4 = new System.Windows.Forms.Button();
            this.btnCue3 = new System.Windows.Forms.Button();
            this.btnCue2 = new System.Windows.Forms.Button();
            this.btnScene12 = new System.Windows.Forms.Button();
            this.btnScene11 = new System.Windows.Forms.Button();
            this.btnScene10 = new System.Windows.Forms.Button();
            this.btnScene9 = new System.Windows.Forms.Button();
            this.btnScene7 = new System.Windows.Forms.Button();
            this.btnScene6 = new System.Windows.Forms.Button();
            this.btnScene5 = new System.Windows.Forms.Button();
            this.btnScene4 = new System.Windows.Forms.Button();
            this.btnScene3 = new System.Windows.Forms.Button();
            this.btnScene2 = new System.Windows.Forms.Button();
            this.btnCue1 = new System.Windows.Forms.Button();
            this.btnScene8 = new System.Windows.Forms.Button();
            this.btnScene1 = new System.Windows.Forms.Button();
            this.pgSetup = new MultiPanel.MultiPanelPage();
            this.btnResetDMX = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReloadConfig = new System.Windows.Forms.Button();
            this.tvScenes = new System.Windows.Forms.TreeView();
            this.tvFixtures = new System.Windows.Forms.TreeView();
            this.pgChannels = new MultiPanel.MultiPanelPage();
            this.pnlChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.btnScene14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlPages.SuspendLayout();
            this.pgScenes.SuspendLayout();
            this.pgSetup.SuspendLayout();
            this.pgChannels.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::LightingCommander.Properties.Resources.Logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(30, 30);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(264, 50);
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // lnkScenes
            // 
            this.lnkScenes.AutoSize = true;
            this.lnkScenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lnkScenes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkScenes.ForeColor = System.Drawing.Color.White;
            this.lnkScenes.Location = new System.Drawing.Point(880, 30);
            this.lnkScenes.Margin = new System.Windows.Forms.Padding(0);
            this.lnkScenes.Name = "lnkScenes";
            this.lnkScenes.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.lnkScenes.Size = new System.Drawing.Size(117, 60);
            this.lnkScenes.TabIndex = 5;
            this.lnkScenes.Text = "Scenes";
            this.lnkScenes.Click += new System.EventHandler(this.lnkScenes_Click);
            // 
            // lnkChannels
            // 
            this.lnkChannels.AutoSize = true;
            this.lnkChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lnkChannels.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChannels.ForeColor = System.Drawing.Color.White;
            this.lnkChannels.Location = new System.Drawing.Point(998, 30);
            this.lnkChannels.Margin = new System.Windows.Forms.Padding(0);
            this.lnkChannels.Name = "lnkChannels";
            this.lnkChannels.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.lnkChannels.Size = new System.Drawing.Size(138, 60);
            this.lnkChannels.TabIndex = 4;
            this.lnkChannels.Text = "Channels";
            this.lnkChannels.Click += new System.EventHandler(this.lnkChannels_Click);
            // 
            // lnkSetup
            // 
            this.lnkSetup.AutoSize = true;
            this.lnkSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lnkSetup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSetup.ForeColor = System.Drawing.Color.White;
            this.lnkSetup.Location = new System.Drawing.Point(1137, 30);
            this.lnkSetup.Margin = new System.Windows.Forms.Padding(0);
            this.lnkSetup.Name = "lnkSetup";
            this.lnkSetup.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.lnkSetup.Size = new System.Drawing.Size(106, 60);
            this.lnkSetup.TabIndex = 0;
            this.lnkSetup.Text = "Setup";
            this.lnkSetup.Click += new System.EventHandler(this.lnkSetup_Click);
            // 
            // timerDmx
            // 
            this.timerDmx.Enabled = true;
            this.timerDmx.Tick += new System.EventHandler(this.timerDmx_Tick);
            // 
            // pnlPages
            // 
            this.pnlPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPages.Controls.Add(this.pgScenes);
            this.pnlPages.Controls.Add(this.pgSetup);
            this.pnlPages.Controls.Add(this.pgChannels);
            this.pnlPages.Location = new System.Drawing.Point(30, 90);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.SelectedPage = this.pgScenes;
            this.pnlPages.Size = new System.Drawing.Size(1213, 905);
            this.pnlPages.TabIndex = 14;
            // 
            // pgScenes
            // 
            this.pgScenes.Controls.Add(this.btnScene14);
            this.pgScenes.Controls.Add(this.btnScene13);
            this.pgScenes.Controls.Add(this.lblActiveCue);
            this.pgScenes.Controls.Add(this.lblCues);
            this.pgScenes.Controls.Add(this.lblActiveScene);
            this.pgScenes.Controls.Add(this.lblScenes);
            this.pgScenes.Controls.Add(this.btnCue12);
            this.pgScenes.Controls.Add(this.btnCue11);
            this.pgScenes.Controls.Add(this.btnCue10);
            this.pgScenes.Controls.Add(this.btnCue9);
            this.pgScenes.Controls.Add(this.btnCue8);
            this.pgScenes.Controls.Add(this.btnBlackoutCue);
            this.pgScenes.Controls.Add(this.btnCue7);
            this.pgScenes.Controls.Add(this.btnCue6);
            this.pgScenes.Controls.Add(this.btnCue5);
            this.pgScenes.Controls.Add(this.btnCue4);
            this.pgScenes.Controls.Add(this.btnCue3);
            this.pgScenes.Controls.Add(this.btnCue2);
            this.pgScenes.Controls.Add(this.btnScene12);
            this.pgScenes.Controls.Add(this.btnScene11);
            this.pgScenes.Controls.Add(this.btnScene10);
            this.pgScenes.Controls.Add(this.btnScene9);
            this.pgScenes.Controls.Add(this.btnScene7);
            this.pgScenes.Controls.Add(this.btnScene6);
            this.pgScenes.Controls.Add(this.btnScene5);
            this.pgScenes.Controls.Add(this.btnScene4);
            this.pgScenes.Controls.Add(this.btnScene3);
            this.pgScenes.Controls.Add(this.btnScene2);
            this.pgScenes.Controls.Add(this.btnCue1);
            this.pgScenes.Controls.Add(this.btnScene8);
            this.pgScenes.Controls.Add(this.btnScene1);
            this.pgScenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgScenes.Location = new System.Drawing.Point(0, 0);
            this.pgScenes.Margin = new System.Windows.Forms.Padding(0);
            this.pgScenes.Name = "pgScenes";
            this.pgScenes.Size = new System.Drawing.Size(1213, 905);
            this.pgScenes.TabIndex = 0;
            this.pgScenes.Text = "Scenes";
            // 
            // btnScene13
            // 
            this.btnScene13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene13.Enabled = false;
            this.btnScene13.FlatAppearance.BorderSize = 0;
            this.btnScene13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene13.ForeColor = System.Drawing.Color.White;
            this.btnScene13.Location = new System.Drawing.Point(870, 280);
            this.btnScene13.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene13.Name = "btnScene13";
            this.btnScene13.Size = new System.Drawing.Size(150, 165);
            this.btnScene13.TabIndex = 35;
            this.btnScene13.UseVisualStyleBackColor = false;
            this.btnScene13.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // lblActiveCue
            // 
            this.lblActiveCue.AutoSize = true;
            this.lblActiveCue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCue.ForeColor = System.Drawing.Color.White;
            this.lblActiveCue.Location = new System.Drawing.Point(84, 473);
            this.lblActiveCue.Name = "lblActiveCue";
            this.lblActiveCue.Size = new System.Drawing.Size(117, 30);
            this.lblActiveCue.TabIndex = 34;
            this.lblActiveCue.Text = "Active Cue";
            // 
            // lblCues
            // 
            this.lblCues.AutoSize = true;
            this.lblCues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCues.ForeColor = System.Drawing.Color.White;
            this.lblCues.Location = new System.Drawing.Point(15, 473);
            this.lblCues.Name = "lblCues";
            this.lblCues.Size = new System.Drawing.Size(63, 30);
            this.lblCues.TabIndex = 33;
            this.lblCues.Text = "Cues:";
            // 
            // lblActiveScene
            // 
            this.lblActiveScene.AutoSize = true;
            this.lblActiveScene.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveScene.ForeColor = System.Drawing.Color.White;
            this.lblActiveScene.Location = new System.Drawing.Point(103, 33);
            this.lblActiveScene.Name = "lblActiveScene";
            this.lblActiveScene.Size = new System.Drawing.Size(137, 30);
            this.lblActiveScene.TabIndex = 32;
            this.lblActiveScene.Text = "Active Scene";
            // 
            // lblScenes
            // 
            this.lblScenes.AutoSize = true;
            this.lblScenes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScenes.ForeColor = System.Drawing.Color.White;
            this.lblScenes.Location = new System.Drawing.Point(15, 33);
            this.lblScenes.Name = "lblScenes";
            this.lblScenes.Size = new System.Drawing.Size(82, 30);
            this.lblScenes.TabIndex = 31;
            this.lblScenes.Text = "Scenes:";
            // 
            // btnCue12
            // 
            this.btnCue12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue12.Enabled = false;
            this.btnCue12.FlatAppearance.BorderSize = 0;
            this.btnCue12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue12.ForeColor = System.Drawing.Color.White;
            this.btnCue12.Location = new System.Drawing.Point(700, 720);
            this.btnCue12.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue12.Name = "btnCue12";
            this.btnCue12.Size = new System.Drawing.Size(150, 165);
            this.btnCue12.TabIndex = 27;
            this.btnCue12.UseVisualStyleBackColor = false;
            this.btnCue12.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue11
            // 
            this.btnCue11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue11.Enabled = false;
            this.btnCue11.FlatAppearance.BorderSize = 0;
            this.btnCue11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue11.ForeColor = System.Drawing.Color.White;
            this.btnCue11.Location = new System.Drawing.Point(530, 720);
            this.btnCue11.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue11.Name = "btnCue11";
            this.btnCue11.Size = new System.Drawing.Size(150, 165);
            this.btnCue11.TabIndex = 26;
            this.btnCue11.UseVisualStyleBackColor = false;
            this.btnCue11.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue10
            // 
            this.btnCue10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue10.Enabled = false;
            this.btnCue10.FlatAppearance.BorderSize = 0;
            this.btnCue10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue10.ForeColor = System.Drawing.Color.White;
            this.btnCue10.Location = new System.Drawing.Point(360, 720);
            this.btnCue10.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue10.Name = "btnCue10";
            this.btnCue10.Size = new System.Drawing.Size(150, 165);
            this.btnCue10.TabIndex = 25;
            this.btnCue10.UseVisualStyleBackColor = false;
            this.btnCue10.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue9
            // 
            this.btnCue9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue9.Enabled = false;
            this.btnCue9.FlatAppearance.BorderSize = 0;
            this.btnCue9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue9.ForeColor = System.Drawing.Color.White;
            this.btnCue9.Location = new System.Drawing.Point(190, 720);
            this.btnCue9.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue9.Name = "btnCue9";
            this.btnCue9.Size = new System.Drawing.Size(150, 165);
            this.btnCue9.TabIndex = 24;
            this.btnCue9.UseVisualStyleBackColor = false;
            this.btnCue9.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue8
            // 
            this.btnCue8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue8.Enabled = false;
            this.btnCue8.FlatAppearance.BorderSize = 0;
            this.btnCue8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue8.ForeColor = System.Drawing.Color.White;
            this.btnCue8.Location = new System.Drawing.Point(20, 720);
            this.btnCue8.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue8.Name = "btnCue8";
            this.btnCue8.Size = new System.Drawing.Size(150, 165);
            this.btnCue8.TabIndex = 23;
            this.btnCue8.UseVisualStyleBackColor = false;
            this.btnCue8.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnBlackoutCue
            // 
            this.btnBlackoutCue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBlackoutCue.FlatAppearance.BorderSize = 0;
            this.btnBlackoutCue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlackoutCue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackoutCue.ForeColor = System.Drawing.Color.White;
            this.btnBlackoutCue.Location = new System.Drawing.Point(870, 720);
            this.btnBlackoutCue.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnBlackoutCue.Name = "btnBlackoutCue";
            this.btnBlackoutCue.Size = new System.Drawing.Size(320, 165);
            this.btnBlackoutCue.TabIndex = 21;
            this.btnBlackoutCue.Text = "Blackout";
            this.btnBlackoutCue.UseVisualStyleBackColor = false;
            this.btnBlackoutCue.Click += new System.EventHandler(this.btnBlackout_Click);
            // 
            // btnCue7
            // 
            this.btnCue7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue7.Enabled = false;
            this.btnCue7.FlatAppearance.BorderSize = 0;
            this.btnCue7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue7.ForeColor = System.Drawing.Color.White;
            this.btnCue7.Location = new System.Drawing.Point(1040, 535);
            this.btnCue7.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue7.Name = "btnCue7";
            this.btnCue7.Size = new System.Drawing.Size(150, 165);
            this.btnCue7.TabIndex = 20;
            this.btnCue7.UseVisualStyleBackColor = false;
            this.btnCue7.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue6
            // 
            this.btnCue6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue6.Enabled = false;
            this.btnCue6.FlatAppearance.BorderSize = 0;
            this.btnCue6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue6.ForeColor = System.Drawing.Color.White;
            this.btnCue6.Location = new System.Drawing.Point(870, 535);
            this.btnCue6.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue6.Name = "btnCue6";
            this.btnCue6.Size = new System.Drawing.Size(150, 165);
            this.btnCue6.TabIndex = 19;
            this.btnCue6.UseVisualStyleBackColor = false;
            this.btnCue6.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue5
            // 
            this.btnCue5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue5.Enabled = false;
            this.btnCue5.FlatAppearance.BorderSize = 0;
            this.btnCue5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue5.ForeColor = System.Drawing.Color.White;
            this.btnCue5.Location = new System.Drawing.Point(700, 535);
            this.btnCue5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue5.Name = "btnCue5";
            this.btnCue5.Size = new System.Drawing.Size(150, 165);
            this.btnCue5.TabIndex = 18;
            this.btnCue5.UseVisualStyleBackColor = false;
            this.btnCue5.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue4
            // 
            this.btnCue4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue4.Enabled = false;
            this.btnCue4.FlatAppearance.BorderSize = 0;
            this.btnCue4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue4.ForeColor = System.Drawing.Color.White;
            this.btnCue4.Location = new System.Drawing.Point(530, 535);
            this.btnCue4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue4.Name = "btnCue4";
            this.btnCue4.Size = new System.Drawing.Size(150, 165);
            this.btnCue4.TabIndex = 17;
            this.btnCue4.UseVisualStyleBackColor = false;
            this.btnCue4.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue3
            // 
            this.btnCue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue3.Enabled = false;
            this.btnCue3.FlatAppearance.BorderSize = 0;
            this.btnCue3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue3.ForeColor = System.Drawing.Color.White;
            this.btnCue3.Location = new System.Drawing.Point(360, 535);
            this.btnCue3.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue3.Name = "btnCue3";
            this.btnCue3.Size = new System.Drawing.Size(150, 165);
            this.btnCue3.TabIndex = 16;
            this.btnCue3.UseVisualStyleBackColor = false;
            this.btnCue3.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue2
            // 
            this.btnCue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue2.Enabled = false;
            this.btnCue2.FlatAppearance.BorderSize = 0;
            this.btnCue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue2.ForeColor = System.Drawing.Color.White;
            this.btnCue2.Location = new System.Drawing.Point(190, 535);
            this.btnCue2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue2.Name = "btnCue2";
            this.btnCue2.Size = new System.Drawing.Size(150, 165);
            this.btnCue2.TabIndex = 15;
            this.btnCue2.UseVisualStyleBackColor = false;
            this.btnCue2.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene12
            // 
            this.btnScene12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene12.Enabled = false;
            this.btnScene12.FlatAppearance.BorderSize = 0;
            this.btnScene12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene12.ForeColor = System.Drawing.Color.White;
            this.btnScene12.Location = new System.Drawing.Point(700, 280);
            this.btnScene12.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene12.Name = "btnScene12";
            this.btnScene12.Size = new System.Drawing.Size(150, 165);
            this.btnScene12.TabIndex = 12;
            this.btnScene12.UseVisualStyleBackColor = false;
            this.btnScene12.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene11
            // 
            this.btnScene11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene11.Enabled = false;
            this.btnScene11.FlatAppearance.BorderSize = 0;
            this.btnScene11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene11.ForeColor = System.Drawing.Color.White;
            this.btnScene11.Location = new System.Drawing.Point(530, 280);
            this.btnScene11.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene11.Name = "btnScene11";
            this.btnScene11.Size = new System.Drawing.Size(150, 165);
            this.btnScene11.TabIndex = 11;
            this.btnScene11.UseVisualStyleBackColor = false;
            this.btnScene11.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene10
            // 
            this.btnScene10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene10.Enabled = false;
            this.btnScene10.FlatAppearance.BorderSize = 0;
            this.btnScene10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene10.ForeColor = System.Drawing.Color.White;
            this.btnScene10.Location = new System.Drawing.Point(360, 280);
            this.btnScene10.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene10.Name = "btnScene10";
            this.btnScene10.Size = new System.Drawing.Size(150, 165);
            this.btnScene10.TabIndex = 10;
            this.btnScene10.UseVisualStyleBackColor = false;
            this.btnScene10.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene9
            // 
            this.btnScene9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene9.Enabled = false;
            this.btnScene9.FlatAppearance.BorderSize = 0;
            this.btnScene9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene9.ForeColor = System.Drawing.Color.White;
            this.btnScene9.Location = new System.Drawing.Point(190, 280);
            this.btnScene9.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene9.Name = "btnScene9";
            this.btnScene9.Size = new System.Drawing.Size(150, 165);
            this.btnScene9.TabIndex = 9;
            this.btnScene9.UseVisualStyleBackColor = false;
            this.btnScene9.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene7
            // 
            this.btnScene7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene7.Enabled = false;
            this.btnScene7.FlatAppearance.BorderSize = 0;
            this.btnScene7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene7.ForeColor = System.Drawing.Color.White;
            this.btnScene7.Location = new System.Drawing.Point(1040, 95);
            this.btnScene7.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene7.Name = "btnScene7";
            this.btnScene7.Size = new System.Drawing.Size(150, 165);
            this.btnScene7.TabIndex = 8;
            this.btnScene7.UseVisualStyleBackColor = false;
            this.btnScene7.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene6
            // 
            this.btnScene6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene6.Enabled = false;
            this.btnScene6.FlatAppearance.BorderSize = 0;
            this.btnScene6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene6.ForeColor = System.Drawing.Color.White;
            this.btnScene6.Location = new System.Drawing.Point(870, 95);
            this.btnScene6.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene6.Name = "btnScene6";
            this.btnScene6.Size = new System.Drawing.Size(150, 165);
            this.btnScene6.TabIndex = 7;
            this.btnScene6.UseVisualStyleBackColor = false;
            this.btnScene6.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene5
            // 
            this.btnScene5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene5.Enabled = false;
            this.btnScene5.FlatAppearance.BorderSize = 0;
            this.btnScene5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene5.ForeColor = System.Drawing.Color.White;
            this.btnScene5.Location = new System.Drawing.Point(700, 95);
            this.btnScene5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene5.Name = "btnScene5";
            this.btnScene5.Size = new System.Drawing.Size(150, 165);
            this.btnScene5.TabIndex = 6;
            this.btnScene5.UseVisualStyleBackColor = false;
            this.btnScene5.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene4
            // 
            this.btnScene4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene4.Enabled = false;
            this.btnScene4.FlatAppearance.BorderSize = 0;
            this.btnScene4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene4.ForeColor = System.Drawing.Color.White;
            this.btnScene4.Location = new System.Drawing.Point(530, 95);
            this.btnScene4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene4.Name = "btnScene4";
            this.btnScene4.Size = new System.Drawing.Size(150, 165);
            this.btnScene4.TabIndex = 5;
            this.btnScene4.UseVisualStyleBackColor = false;
            this.btnScene4.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene3
            // 
            this.btnScene3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene3.Enabled = false;
            this.btnScene3.FlatAppearance.BorderSize = 0;
            this.btnScene3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene3.ForeColor = System.Drawing.Color.White;
            this.btnScene3.Location = new System.Drawing.Point(360, 95);
            this.btnScene3.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene3.Name = "btnScene3";
            this.btnScene3.Size = new System.Drawing.Size(150, 165);
            this.btnScene3.TabIndex = 4;
            this.btnScene3.UseVisualStyleBackColor = false;
            this.btnScene3.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene2
            // 
            this.btnScene2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene2.Enabled = false;
            this.btnScene2.FlatAppearance.BorderSize = 0;
            this.btnScene2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene2.ForeColor = System.Drawing.Color.White;
            this.btnScene2.Location = new System.Drawing.Point(190, 95);
            this.btnScene2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene2.Name = "btnScene2";
            this.btnScene2.Size = new System.Drawing.Size(150, 165);
            this.btnScene2.TabIndex = 3;
            this.btnScene2.UseVisualStyleBackColor = false;
            this.btnScene2.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnCue1
            // 
            this.btnCue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCue1.Enabled = false;
            this.btnCue1.FlatAppearance.BorderSize = 0;
            this.btnCue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCue1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCue1.ForeColor = System.Drawing.Color.White;
            this.btnCue1.Location = new System.Drawing.Point(20, 535);
            this.btnCue1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnCue1.Name = "btnCue1";
            this.btnCue1.Size = new System.Drawing.Size(150, 165);
            this.btnCue1.TabIndex = 2;
            this.btnCue1.UseVisualStyleBackColor = false;
            this.btnCue1.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene8
            // 
            this.btnScene8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene8.Enabled = false;
            this.btnScene8.FlatAppearance.BorderSize = 0;
            this.btnScene8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene8.ForeColor = System.Drawing.Color.White;
            this.btnScene8.Location = new System.Drawing.Point(20, 280);
            this.btnScene8.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene8.Name = "btnScene8";
            this.btnScene8.Size = new System.Drawing.Size(150, 165);
            this.btnScene8.TabIndex = 1;
            this.btnScene8.UseVisualStyleBackColor = false;
            this.btnScene8.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // btnScene1
            // 
            this.btnScene1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene1.Enabled = false;
            this.btnScene1.FlatAppearance.BorderSize = 0;
            this.btnScene1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene1.ForeColor = System.Drawing.Color.White;
            this.btnScene1.Location = new System.Drawing.Point(20, 95);
            this.btnScene1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene1.Name = "btnScene1";
            this.btnScene1.Size = new System.Drawing.Size(150, 165);
            this.btnScene1.TabIndex = 0;
            this.btnScene1.UseVisualStyleBackColor = false;
            this.btnScene1.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // pgSetup
            // 
            this.pgSetup.Controls.Add(this.btnResetDMX);
            this.pgSetup.Controls.Add(this.btnExit);
            this.pgSetup.Controls.Add(this.btnReloadConfig);
            this.pgSetup.Controls.Add(this.tvScenes);
            this.pgSetup.Controls.Add(this.tvFixtures);
            this.pgSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSetup.Location = new System.Drawing.Point(0, 0);
            this.pgSetup.Name = "pgSetup";
            this.pgSetup.Size = new System.Drawing.Size(1375, 835);
            this.pgSetup.TabIndex = 1;
            this.pgSetup.Text = "Setup";
            // 
            // btnResetDMX
            // 
            this.btnResetDMX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnResetDMX.FlatAppearance.BorderSize = 0;
            this.btnResetDMX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDMX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDMX.ForeColor = System.Drawing.Color.White;
            this.btnResetDMX.Location = new System.Drawing.Point(1080, 100);
            this.btnResetDMX.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnResetDMX.Name = "btnResetDMX";
            this.btnResetDMX.Size = new System.Drawing.Size(275, 60);
            this.btnResetDMX.TabIndex = 30;
            this.btnResetDMX.Text = "Reset DMX Interface";
            this.btnResetDMX.UseVisualStyleBackColor = false;
            this.btnResetDMX.Click += new System.EventHandler(this.btnResetDMX_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1080, 755);
            this.btnExit.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(275, 60);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit Lighting Commander";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReloadConfig
            // 
            this.btnReloadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReloadConfig.FlatAppearance.BorderSize = 0;
            this.btnReloadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadConfig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadConfig.ForeColor = System.Drawing.Color.White;
            this.btnReloadConfig.Location = new System.Drawing.Point(1080, 20);
            this.btnReloadConfig.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnReloadConfig.Name = "btnReloadConfig";
            this.btnReloadConfig.Size = new System.Drawing.Size(275, 60);
            this.btnReloadConfig.TabIndex = 28;
            this.btnReloadConfig.Text = "Reload Configuration";
            this.btnReloadConfig.UseVisualStyleBackColor = false;
            this.btnReloadConfig.Click += new System.EventHandler(this.btnReloadConfig_Click);
            // 
            // tvScenes
            // 
            this.tvScenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvScenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvScenes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvScenes.ForeColor = System.Drawing.Color.White;
            this.tvScenes.Location = new System.Drawing.Point(550, 20);
            this.tvScenes.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.tvScenes.Name = "tvScenes";
            this.tvScenes.Size = new System.Drawing.Size(510, 795);
            this.tvScenes.TabIndex = 1;
            // 
            // tvFixtures
            // 
            this.tvFixtures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvFixtures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvFixtures.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFixtures.ForeColor = System.Drawing.Color.White;
            this.tvFixtures.Location = new System.Drawing.Point(20, 20);
            this.tvFixtures.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.tvFixtures.Name = "tvFixtures";
            this.tvFixtures.Size = new System.Drawing.Size(510, 795);
            this.tvFixtures.TabIndex = 0;
            // 
            // pgChannels
            // 
            this.pgChannels.Controls.Add(this.pnlChannels);
            this.pgChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgChannels.Location = new System.Drawing.Point(0, 0);
            this.pgChannels.Name = "pgChannels";
            this.pgChannels.Size = new System.Drawing.Size(1213, 905);
            this.pgChannels.TabIndex = 2;
            this.pgChannels.Text = "Channels";
            // 
            // pnlChannels
            // 
            this.pnlChannels.AutoScroll = true;
            this.pnlChannels.Location = new System.Drawing.Point(20, 20);
            this.pnlChannels.Margin = new System.Windows.Forms.Padding(20);
            this.pnlChannels.Name = "pnlChannels";
            this.pnlChannels.Size = new System.Drawing.Size(1173, 865);
            this.pnlChannels.TabIndex = 0;
            // 
            // btnScene14
            // 
            this.btnScene14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnScene14.Enabled = false;
            this.btnScene14.FlatAppearance.BorderSize = 0;
            this.btnScene14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScene14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScene14.ForeColor = System.Drawing.Color.White;
            this.btnScene14.Location = new System.Drawing.Point(1040, 280);
            this.btnScene14.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.btnScene14.Name = "btnScene14";
            this.btnScene14.Size = new System.Drawing.Size(150, 165);
            this.btnScene14.TabIndex = 36;
            this.btnScene14.UseVisualStyleBackColor = false;
            this.btnScene14.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lnkScenes);
            this.Controls.Add(this.lnkChannels);
            this.Controls.Add(this.lnkSetup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lighting Commander";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlPages.ResumeLayout(false);
            this.pgScenes.ResumeLayout(false);
            this.pgScenes.PerformLayout();
            this.pgSetup.ResumeLayout(false);
            this.pgChannels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DarkLink lnkSetup;
        private Controls.DarkLink lnkChannels;
        private Controls.DarkLink lnkScenes;
        private System.Windows.Forms.PictureBox picLogo;
        private MultiPanel.MultiPanel pnlPages;
        private MultiPanel.MultiPanelPage pgSetup;
        private MultiPanel.MultiPanelPage pgScenes;
        private System.Windows.Forms.Button btnScene1;
        private System.Windows.Forms.Button btnBlackoutCue;
        private System.Windows.Forms.Button btnCue7;
        private System.Windows.Forms.Button btnCue6;
        private System.Windows.Forms.Button btnCue5;
        private System.Windows.Forms.Button btnCue4;
        private System.Windows.Forms.Button btnCue3;
        private System.Windows.Forms.Button btnCue2;
        private System.Windows.Forms.Button btnScene12;
        private System.Windows.Forms.Button btnScene11;
        private System.Windows.Forms.Button btnScene10;
        private System.Windows.Forms.Button btnScene9;
        private System.Windows.Forms.Button btnScene7;
        private System.Windows.Forms.Button btnScene6;
        private System.Windows.Forms.Button btnScene5;
        private System.Windows.Forms.Button btnScene4;
        private System.Windows.Forms.Button btnScene3;
        private System.Windows.Forms.Button btnScene2;
        private System.Windows.Forms.Button btnCue1;
        private System.Windows.Forms.Button btnScene8;
        private System.Windows.Forms.Label lblActiveScene;
        private System.Windows.Forms.Label lblScenes;
        private System.Windows.Forms.TreeView tvFixtures;
        private MultiPanel.MultiPanelPage pgChannels;
        private System.Windows.Forms.Button btnReloadConfig;
        private System.Windows.Forms.TreeView tvScenes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResetDMX;
        private System.Windows.Forms.FlowLayoutPanel pnlChannels;
        private System.Windows.Forms.Timer timerDmx;
        private System.Windows.Forms.Button btnCue12;
        private System.Windows.Forms.Button btnCue11;
        private System.Windows.Forms.Button btnCue10;
        private System.Windows.Forms.Button btnCue9;
        private System.Windows.Forms.Button btnCue8;
        private System.Windows.Forms.Label lblCues;
        private System.Windows.Forms.Label lblActiveCue;
        private System.Windows.Forms.Button btnScene13;
        private System.Windows.Forms.Button btnScene14;
    }
}

