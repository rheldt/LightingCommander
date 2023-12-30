using System;
using System.Collections.Generic;

namespace LightingCommander.Models
{
    [Serializable]
    public class Scene
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SceneType Type { get; set; }
        public string ButtonColor { get; set; }
        public List<Channel> Channels { get; set; }

        /// <summary>
        /// Initialization constructor.
        /// </summary>
        public Scene()
        {
            this.ID = 0;
            this.Name = "";
            this.Type = SceneType.None;
            this.ButtonColor = "#000000";
            this.Channels = new List<Channel>();
        }
    }

    public enum SceneType
    {
        None,
        Augment,
        Replace
    }
}