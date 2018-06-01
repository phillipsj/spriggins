using System.Collections.Generic;

namespace Spriggins.Models {
    public class Manifest {
        public string DockerRunVersion { get; set; }
        public Image Image { get; set; }
        public List<Port> Ports { get; set; }
        public List<Volume> Volumes { get; set; }
        public Extensions Extensions { get; set; }
    }
}
