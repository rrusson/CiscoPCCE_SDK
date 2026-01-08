using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("sipServerGroup")]
    public class SipServerGroup : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("defaultGroup")]
        public bool? DefaultGroup { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlArray("elements")]
        [XmlArrayItem("element")]
        public List<SipServerElement>? Elements { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("noOfElements")]
        public int? NoOfElements { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("type")]
        public SipServerType Type { get; set; }

        // Path("sipservergroup")
        [XmlRoot("results")]
        public class SipServerGroupList : BaseApiListBean<SipServerGroup>
        {
            [XmlArray("sipServerGroups")]
            [XmlArrayItem("sipServerGroup")]
            public new List<SipServerGroup>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SipServerGroup>? GetItems() => Items;

            public override void SetItems(List<SipServerGroup>? value) => Items = value;
        }
    }
}