using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("courtesyCallBack")]
    public class CourtesyCallBack : BaseApiBean
    {
        [XmlElement("allowUnmatchedDialedNumbers")]
        public string? AllowUnmatchedDialedNumbers { get; set; }

        public List<string?>? AllowedDialedNumbers { get; set; }

        public List<string?>? DeniedDialedNumbers { get; set; }

        [XmlElement("maximumCallBacksPerAni")]
        public string? MaximumCallBacksPerAni { get; set; }

        [XmlElement("reportingAddress")]
        public string? ReportingAddress { get; set; }
    }
}