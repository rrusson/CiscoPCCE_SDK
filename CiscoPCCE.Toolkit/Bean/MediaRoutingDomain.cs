using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("mediaroutingdomain")
    [XmlRoot("mediaRoutingDomain")]
    public class MediaRoutingDomain : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("interruptible")]
        public bool? Interruptible { get; set; }

        [XmlElement("id")]
        public int? MRDomainId { get; set; }

        [XmlElement("maxTaskDuration")]
        public int? MaxTaskDuration { get; set; }

        [XmlElement("maxTasksInQueue")]
        public int? MaxTasksInQueue { get; set; }

        [XmlElement("maxTimeInQueue")]
        public int? MaxTimeInQueue { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("serviceLevelThreshold")]
        public int? ServiceLevelThreshold { get; set; }

        [XmlElement("taskLife")]
        public int? TaskLife { get; set; }

        [XmlElement("taskStartTimeout")]
        public int? TaskStartTimeout { get; set; }

        [XmlElement("type")]
        public MediaRoutingType Type { get; set; }

        // Path("mediaroutingdomain")
        [XmlRoot("results")]
        public class MediaRoutingDomainList : BaseApiListBean<MediaRoutingDomain>
        {
            [XmlArray("mediaRoutingDomains")]
            [XmlArrayItem("mediaRoutingDomain")]
            public new List<MediaRoutingDomain>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MediaRoutingDomain>? GetItems() => Items;

            public override void SetItems(List<MediaRoutingDomain>? value) => Items = value;
        }
    }
}