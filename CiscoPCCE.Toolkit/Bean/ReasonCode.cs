using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("reasonCode")]
    public class ReasonCode : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? Category { get; set; }

        public new int? ChangeStamp { get; set; }

        public int? Code { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? IsGlobal { get; set; }

        public bool? MarkDeletable { get; set; }

        public ReasonTypeEnum ReasonType { get; set; }

        public new string? RefURL { get; set; }

        public string? Text { get; set; }

        // Path("reasoncode")
        [XmlRoot("results")]
        public class ReasonCodeList : BaseApiListBean<ReasonCode>
        {
            public override List<ReasonCode>? GetItems() => Items;

            public override void SetItems(List<ReasonCode>? value) => Items = value;
        }
    }
}