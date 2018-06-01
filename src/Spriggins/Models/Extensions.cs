namespace Spriggins.Models {
    public class Extensions {
        public string TimeZone { get; set; }
        public MountedFileSystem FileSystem { get; set; }
    }

    public class MountedFileSystem {
        public string FileSystemId { get; set; }
        public string Region { get; set; }
    }
}
