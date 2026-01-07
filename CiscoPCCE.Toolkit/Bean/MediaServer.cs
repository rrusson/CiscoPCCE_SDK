namespace CiscoPCCE.Toolkit.Bean
{
    public class MediaServer : BaseApiBean
    {
        public bool? FtpEnabled { get; set; }

        public string? FtpPassword { get; set; }

        public int? FtpPort { get; set; }

        public string? FtpUserName { get; set; }

        public string? HostName { get; set; }

        public string? Ip { get; set; }
    }
}