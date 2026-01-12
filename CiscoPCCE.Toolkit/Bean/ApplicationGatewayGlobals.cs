using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgatewayglobalsetting")
    [XmlRoot("applicationGatewayGlobalSetting")]
    public class ApplicationGatewayGlobals : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("connectionParameters")]
        public required ConnectionParametersGlobal ConnectionParameters { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("type")]
        public ApplicationGatewayType Type { get; set; }
        
    }
}