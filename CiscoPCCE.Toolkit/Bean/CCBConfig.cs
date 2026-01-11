using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("ccb")
    [XmlRoot("CCB")]
    public class CCBConfig : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("reportingAddress")]
        public string? ReportingAddress { get; set; }

        // Path("ccb")
        [XmlRoot("results")]
        public class CCBConfigList : BaseApiListBean<CCBConfig>
        {
            [XmlArray("CCBs")]
            [XmlArrayItem("CCB")]
            public new List<CCBConfig>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CCBConfig>? GetItems() => Items;

            public override void SetItems(List<CCBConfig>? value) => Items = value;
        }
    }
}