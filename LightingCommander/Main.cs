using LightingCommander.Controls;
using LightingCommander.Models;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LightingCommander
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //LoadConfiguration();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lnkScenes_Click(null, null);
            //OpenDMX.Start();
            //if (OpenDMX.Status == OpenDMX.FT_STATUS.FT_DEVICE_NOT_FOUND)
            //{
            //    MessageBox.Show("No USB DMX controller found.", "Lighting Commander", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}
            //else if (OpenDMX.Status == OpenDMX.FT_STATUS.FT_OK)
            //{
            //    lblActiveScene.Text = "USB DMX controller found";
            //    timerDmx.Start();
            //}
            //else
            //{
            //    MessageBox.Show("DMX controller error: " + OpenDMX.Status.ToString() + ".", "Lighting Commander", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}
        }

        private void lnkScenes_Click(object sender, EventArgs e)
        {
            lnkScenes.BackColor = Color.FromArgb(64, 64, 64);
            lnkChannels.BackColor = Color.FromArgb(48, 48, 48);
            lnkSetup.BackColor = Color.FromArgb(48, 48, 48);
            pnlPages.SelectedPage = pgScenes;
        }

        private void lnkChannels_Click(object sender, EventArgs e)
        {
            lnkScenes.BackColor = Color.FromArgb(48, 48, 48);
            lnkChannels.BackColor = Color.FromArgb(64, 64, 64);
            lnkSetup.BackColor = Color.FromArgb(48, 48, 48);
            pnlPages.SelectedPage = pgChannels;
        }

        private void lnkSetup_Click(object sender, EventArgs e)
        {
            lnkScenes.BackColor = Color.FromArgb(48, 48, 48);
            lnkChannels.BackColor = Color.FromArgb(48, 48, 48);
            lnkSetup.BackColor = Color.FromArgb(64, 64, 64);
            pnlPages.SelectedPage = pgSetup;
        }

        private void btnScene_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                //Button btnScene = (Button)sender;
                //if (btnScene.Tag != null && btnScene.Tag is Scene)
                //{
                //    Scene scene = (Scene)btnScene.Tag;
                //    foreach (var sceneChannel in scene.Channels)
                //    {
                //        OpenDMX.SetValue(sceneChannel.Dmx, sceneChannel.Value);
                //    }
                //    UpdateChannelFaders();
                //    lblActiveScene.Text = scene.Name;
                //}
            }
        }

        private void btnBlackout_Click(object sender, EventArgs e)
        {
            for (int channel = 1; channel < 512; channel++)
            {
                //OpenDMX.SetValue(channel, 0);
            }
            UpdateChannelFaders();
        }

        private void btnReloadConfig_Click(object sender, EventArgs e)
        {
            timerDmx.Stop();
            ResetSceneButtons();
            LoadConfiguration();
            timerDmx.Start();
        }

        private void btnResetDMX_Click(object sender, EventArgs e)
        {
            timerDmx.Stop();
            LoadConfiguration();
            Main_Load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timerDmx.Stop();
            Application.Exit();
        }

        private void timerDmx_Tick(object sender, EventArgs e)
        {
            //OpenDMX.WriteData();
        }

        private void LoadConfiguration()
        {
            //OpenDMX.ClearControlChannels();
            //Configuration config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(@"c:\dmxconfig.json"));

            //// Fixtures
            //pnlChannels.Controls.Clear();
            //tvFixtures.Nodes.Clear();
            //int fixtureCount = 0;
            //foreach (var fixture in config.Fixtures)
            //{
            //    // Channel faders
            //    fixtureCount++;
            //    var panel = new FlowLayoutPanel();
            //    panel.AutoSize = true;
            //    panel.Margin = new Padding(0, 0, 20, 20);
            //    panel.Padding = new Padding(10);
            //    panel.BorderStyle = BorderStyle.FixedSingle;

            //    var label = new DarkLabel();
            //    label.Text = fixture.Name;

            //    label.RotationAngle = 270;
            //    label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            //    label.ForeColor = Color.White;
            //    panel.Controls.Add(label);
            //    foreach (var channel in fixture.Channels)
            //    {
            //        var fader = new DarkFader
            //        {
            //            Type = channel.Type,
            //            Dmx = channel.Dmx,
            //            Value = channel.Value
            //        };
            //        panel.Controls.Add(fader);

            //        if (channel.Type == ChannelType.Control)
            //        {
            //            //OpenDMX.RegisterControlChannel(channel.Dmx, channel.Value);
            //        }
            //    }
            //    pnlChannels.Controls.Add(panel);

            //    // Setup
            //    var root = new TreeNode(fixture.Name);
            //    foreach (var channel in fixture.Channels)
            //    {
            //        root.Nodes.Add(channel.Type.ToString() + ", DMX: " + channel.Dmx.ToString() + (channel.Value != 0 ? ", Value: " + channel.Value.ToString() : ""));
            //    }
            //    tvFixtures.Nodes.Add(root);
            //}

            //// Scenes
            //tvScenes.Nodes.Clear();
            //foreach (var scene in config.Scenes)
            //{
            //    // Scene buttons
            //    Button btnScene = (Button)pgScenes.Controls.Find("btnScene" + scene.ID.ToString(), true).FirstOrDefault();
            //    if (btnScene != null)
            //    {
            //        btnScene.Tag = scene;
            //        btnScene.Text = scene.Name;
            //        btnScene.Enabled = true;
            //        btnScene.BackColor = Color.FromArgb(40, 40, 40);
            //    }

            //    // Setup
            //    var root = new TreeNode("Scene" + scene.ID.ToString() + ": " + scene.Name);
            //    root.Nodes.Add("Type: " + scene.Type.ToString());
            //    foreach (var channel in scene.Channels)
            //    {
            //        root.Nodes.Add("DMX: " + channel.Dmx.ToString() + (channel.Value != 0 ? ", Value: " + channel.Value.ToString() : ""));
            //    }
            //    tvScenes.Nodes.Add(root);
            //}
        }

        private void ResetSceneButtons()
        {
            foreach (var control in pgScenes.Controls)
            {
                if (control is Button btnScene)
                {
                    btnScene.Tag = null;
                    btnScene.Text = "";
                    btnScene.Enabled = false;
                    btnScene.BackColor = Color.FromArgb(56, 56, 56);
                }
            }
        }

        private void UpdateChannelFaders()
        {

        }
    }
}