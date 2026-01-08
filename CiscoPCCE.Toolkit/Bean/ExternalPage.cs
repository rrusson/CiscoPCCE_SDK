using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("externalpage")
    [XmlRoot("externalpage")]
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

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("tabPosition")]
        public int? TabPosition { get; set; }

        [XmlElement("url")]
        public string? Url { get; set; }

        // Path("externalpage")
        [XmlRoot("results")]
        public class ExternalPageList : BaseApiListBean<ExternalPage>
        {
            public override List<ExternalPage>? GetItems() => Items;

            public override void SetItems(List<ExternalPage>? value) => Items = value;
        }
    }
}