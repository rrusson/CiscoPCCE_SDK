using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("CVP")]
    public class CVPSIPServerGroupProperties : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public required SIPServerGroupProperties SipServerGroupProperties { get; set; }

        // Path("sipservergroupproperties")
        [XmlRoot("results")]
        public class CVPSIPServerGroupPropertiesList : BaseApiListBean<CVPSIPServerGroupProperties>
        {
            public override List<CVPSIPServerGroupProperties>? GetItems() => Items;

            public override void SetItems(List<CVPSIPServerGroupProperties>? value) => Items = value;
        }
    }
}