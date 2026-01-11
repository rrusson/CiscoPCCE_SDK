using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("aw")]
    public class WebsetupAW : BaseApiBean
    {
        [XmlElement("loggerSideAPublicAddress")]
        public string? LoggerSideAPublicAddress { get; set; }

        [XmlElement("loggerSideBPublicAddress")]
        public string? LoggerSideBPublicAddress { get; set; }

        [XmlElement("preferredSide")]
        public string? PreferredSide { get; set; }

        [XmlElement("primaryAdminAndDataServerName")]
        public string? PrimaryAdminAndDataServerName { get; set; }

        [XmlElement("routerSideAPublicAddress")]
        public string? RouterSideAPublicAddress { get; set; }

        [XmlElement("routerSideBPublicAddress")]
        public string? RouterSideBPublicAddress { get; set; }

        [XmlElement("secondaryAdminAndDataServerName")]
        public string? SecondaryAdminAndDataServerName { get; set; }

        [XmlElement("serviceAccountPassword")]
        public string? ServiceAccountPassword { get; set; }

        [XmlElement("serviceAccountUserName")]
        public string? ServiceAccountUserName { get; set; }
    }
}