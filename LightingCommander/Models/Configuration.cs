using System;
using System.Collections.Generic;

namespace LightingCommander.Models
{
    [Serializable]
    public class Configuration
    {
        public List<Fixture> Fixtures { get; set; }
        public List<Scene> Scenes { get; set; }

        public List<Scene> Cues { get; set; }

        /// <summary>
        /// Initialization constructor.
        /// </summary>
        public Configuration()
        {
            this.Fixtures = new List<Fixture>();
            this.Scenes = new List<Scene>();
        }
    }
}