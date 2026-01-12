using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("sipServerGroupProperties")]
    public class SIPServerGroupProperties : BaseApiBean
    {
        [XmlElement("optionsOverrideHost")]
        public string? OptionsOverrideHost { get; set; }

        [XmlElement("serverGroupDownInterval")]
        public int? ServerGroupDownInterval { get; set; }

        [XmlElement("serverGroupHBLocalListenPort")]
        public int? ServerGroupHBLocalListenPort { get; set; }

        [XmlElement("serverGroupHBMethod")]
        public string? ServerGroupHBMethod { get; set; }

        [XmlElement("serverGroupHBNumTries")]
        public int? ServerGroupHBNumTries { get; set; }

        [XmlElement("serverGroupHBTimeout")]
        public int? ServerGroupHBTimeout { get; set; }

        [XmlElement("serverGroupHBTransportType")]
        public string? ServerGroupHBTransportType { get; set; }

        [XmlElement("serverGroupHeartbeats")]
        public bool? ServerGroupHeartbeats { get; set; }

        [XmlElement("serverGroupOverloadedResponseCodes")]
        public string? ServerGroupOverloadedResponseCodes { get; set; }

        [XmlElement("serverGroupUpInterval")]
        public int? ServerGroupUpInterval { get; set; }
        
    }
}