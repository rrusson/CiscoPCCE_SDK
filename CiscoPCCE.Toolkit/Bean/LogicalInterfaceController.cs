using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("pg")]
    public class LogicalInterfaceController : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("logicalControllerType")]
        public short? LogicalControllerType { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("primaryCtiAddress")]
        public string? PrimaryCtiAddress { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("secondaryCtiAddress")]
        public string? SecondaryCtiAddress { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class LogicalInterfaceControllerList : BaseApiListBean<LogicalInterfaceController>
        {
            [XmlArray("pgs")]
            [XmlArrayItem("pg")]
            public new List<LogicalInterfaceController>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<LogicalInterfaceController>? GetItems() => Items;

            public override void SetItems(List<LogicalInterfaceController>? value) => Items = value;
        }
    }
}