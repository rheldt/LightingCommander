using System.Drawing;
using System.Windows.Forms;
using LightingCommander.Models;

namespace LightingCommander.Controls
{
    public partial class DarkFader : UserControl
    {
        public ChannelType Type { get; set; }
        public byte Dmx { get; set; }
        public byte Value { get; set; }

        public DarkFader()
        {
            InitializeComponent();
        }

        private void DarkFader_Load(object sender, System.EventArgs e)
        {
            lblChannel.Text = this.Dmx.ToString();
            if (this.Value > 0)
            {
                colorSlider.Value = this.Value;
                colorSlider.Enabled = false;
                colorSlider.ForeColor = Color.DarkGray;
                lblChannel.ForeColor = Color.DarkGray;
                lblType.ForeColor = Color.DarkGray;
            }
            switch (this.Type)
            {
                case ChannelType.Brightness:
                    lblType.Text = "BRIGHT";
                    break;
                case ChannelType.None:
                    lblType.Text = "UNKNOWN";
                    break;
                case ChannelType.Red:
                    colorSlider.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.RedColors;
                    lblType.Text = this.Type.ToString().ToUpper();
                    break;
                case ChannelType.Green:
                    colorSlider.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.GreenColors;
                    lblType.Text = this.Type.ToString().ToUpper();
                    break;
                case ChannelType.Blue:
                    colorSlider.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.BlueColors;
                    lblType.Text = this.Type.ToString().ToUpper();
                    break;
                default:
                    lblType.Text = this.Type.ToString().ToUpper();
                    break;
            }
        }
    }
}