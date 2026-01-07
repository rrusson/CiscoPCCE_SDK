using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("attributeSummary")]
    public class AttributeSummary : BaseApiBean
    {
        public int? AgentCount { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? DataType { get; set; }

        public string? DefaultValue { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? SelectedAgentCount { get; set; }

        // Path("attribute")
        [XmlRoot("results")]
        public class AttributeSummaryList : BaseApiListBean<AttributeSummary>
        {
            public override List<AttributeSummary>? GetItems() => Items;

            public override void SetItems(List<AttributeSummary>? value) => Items = value;
        }
    }
}