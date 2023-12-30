using System;
using System.Collections.Generic;

namespace LightingCommander.Models
{
    [Serializable]
    public class Fixture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Channel> Channels { get; set; }

        /// <summary>
        /// Initialization constructor.
        /// </summary>
        public Fixture()
        {
            this.ID = 0;
            this.Name = "";
            this.Channels = new List<Channel>();
        }
    }
}