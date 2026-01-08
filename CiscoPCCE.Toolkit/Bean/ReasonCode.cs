using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("reasonCode")]
    public class ReasonCode : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("category")]
        public string? Category { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("code")]
        public int? Code { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("isGlobal")]
        public bool? IsGlobal { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("reasonType")]
        public ReasonTypeEnum ReasonType { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("text")]
        public string? Text { get; set; }

        // Path("reasoncode")
        [XmlRoot("results")]
        public class ReasonCodeList : BaseApiListBean<ReasonCode>
        {
            [XmlArray("reasonCodes")]
            [XmlArrayItem("reasonCode")]
            public new List<ReasonCode>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ReasonCode>? GetItems() => Items;

            public override void SetItems(List<ReasonCode>? value) => Items = value;
        }
    }
}