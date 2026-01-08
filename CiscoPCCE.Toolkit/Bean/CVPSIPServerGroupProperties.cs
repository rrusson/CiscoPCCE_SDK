using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("CVP")]
    public class CVPSIPServerGroupProperties : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("sipServerGroupProperties")]
        public required SIPServerGroupProperties SipServerGroupProperties { get; set; }

        // Path("sipservergroupproperties")
        [XmlRoot("results")]
        public class CVPSIPServerGroupPropertiesList : BaseApiListBean<CVPSIPServerGroupProperties>
        {
            [XmlArray("CVPs")]
            [XmlArrayItem("CVP")]
            public new List<CVPSIPServerGroupProperties>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CVPSIPServerGroupProperties>? GetItems() => Items;

            public override void SetItems(List<CVPSIPServerGroupProperties>? value) => Items = value;
        }
    }
}