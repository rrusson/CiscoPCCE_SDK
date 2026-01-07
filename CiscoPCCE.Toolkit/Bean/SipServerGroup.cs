using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("sipServerGroup")]
    public class SipServerGroup : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public bool? DefaultGroup { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        [XmlElement("elements")]
        [XmlElement("element")]
        public List<SipServerElement>? Elements { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public int? NoOfElements { get; set; }

        public new string? RefURL { get; set; }

        public SipServerType Type { get; set; }

        // Path("sipservergroup")
        [XmlRoot("results")]
        public class SipServerGroupList : BaseApiListBean<SipServerGroup>
        {
            public override List<SipServerGroup>? GetItems() => Items;

            public override void SetItems(List<SipServerGroup>? value) => Items = value;
        }
    }
}