using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("courtesyCallBack")]
    public class CourtesyCallBack : BaseApiBean
    {
        public string? AllowUnmatchedDialedNumbers { get; set; }

        public List<string?>? AllowedDialedNumbers { get; set; }

        public List<string?>? DeniedDialedNumbers { get; set; }

        public string? MaximumCallBacksPerAni { get; set; }

        public string? ReportingAddress { get; set; }
    }
}