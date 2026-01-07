using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("datacenter")
    [XmlRoot("datacenter")]
    public class DataCenter : BaseApiBean
    {
        public required AgentPG AgentPG { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public bool? CMPublisherAssociationRequired { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public bool? EceConfigured { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required MultiChannelPG MultiChannelPG { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public string? SideAPGAddress { get; set; }

        public string? SideBPGAddress { get; set; }

        public required VruPG VruPG { get; set; }

        // Path("datacenter")
        [XmlRoot("results")]
        public class DataCenterList : BaseApiListBean<DataCenter>
        {
            public override List<DataCenter>? GetItems() => Items;

            public override void SetItems(List<DataCenter>? value) => Items = value;
        }
    }
}