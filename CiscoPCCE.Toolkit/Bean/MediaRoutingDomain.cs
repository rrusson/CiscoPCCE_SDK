using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("mediaroutingdomain")
    [XmlRoot("mediaRoutingDomain")]
    public class MediaRoutingDomain : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? Interruptible { get; set; }

        [XmlElement("id")]
        public int? MRDomainId { get; set; }

        public int? MaxTaskDuration { get; set; }

        public int? MaxTasksInQueue { get; set; }

        public int? MaxTimeInQueue { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? ServiceLevelThreshold { get; set; }

        public int? TaskLife { get; set; }

        public int? TaskStartTimeout { get; set; }

        public MediaRoutingType Type { get; set; }

        // Path("mediaroutingdomain")
        [XmlRoot("results")]
        public class MediaRoutingDomainList : BaseApiListBean<MediaRoutingDomain>
        {
            public override List<MediaRoutingDomain>? GetItems() => Items;

            public override void SetItems(List<MediaRoutingDomain>? value) => Items = value;
        }
    }
}