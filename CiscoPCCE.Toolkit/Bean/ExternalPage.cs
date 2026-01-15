using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("externalpage")]
    public class ExternalPage : BaseApiBean
    {
        [XmlElement("baseData")]
        public string? BaseData { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("card")]
        public required ReferenceBean Card { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("dynamicData")]
        public string? DynamicData { get; set; }

        [XmlElement("featureId")]
        public int? FeatureId { get; set; }

        [XmlElement("gadget")]
        public bool? Gadget { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("ipAddress")]
        public string? IpAddress { get; set; }

        [XmlElement("menu")]
        public required ReferenceBean Menu { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("tabPosition")]
        public int? TabPosition { get; set; }

        [XmlElement("url")]
        public string? Url { get; set; }
    }
}