using System;

namespace LightingCommander.Models
{
    [Serializable]
    public class Channel
    {
        public ChannelType Type { get; set; }
        public byte Dmx { get; set; }
        public byte Value { get; set; }

        /// <summary>
        /// Initialization constructor.
        /// </summary>
        public Channel()
        {
            this.Type = ChannelType.None;
            this.Dmx = 0;
            this.Value = 0;
        }
    }

    public enum ChannelType
    {
        None,
        Brightness,
        Control,
        Red,
        Green,
        Blue
    }
}