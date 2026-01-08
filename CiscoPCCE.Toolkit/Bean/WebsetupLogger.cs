using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("logger")]
    public class WebsetupLogger : BaseApiBean
    {
        [XmlElement("loggerSideAPrivateAddress")]
        public string? LoggerSideAPrivateAddress { get; set; }

        [XmlElement("loggerSideBPrivateAddress")]
        public string? LoggerSideBPrivateAddress { get; set; }

        [XmlElement("routerSideAPrivateAddress")]
        public string? RouterSideAPrivateAddress { get; set; }

        [XmlElement("routerSideBPrivateAddress")]
        public string? RouterSideBPrivateAddress { get; set; }

        [XmlElement("serviceAccountPassword")]
        public string? ServiceAccountPassword { get; set; }

        [XmlElement("serviceAccountUserName")]
        public string? ServiceAccountUserName { get; set; }

        [XmlElement("side")]
        public string? Side { get; set; }
    }
}