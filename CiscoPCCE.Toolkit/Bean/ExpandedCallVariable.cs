using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("expandedCallVariable")]
    public class ExpandedCallVariable : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public int? BytesRequired { get; set; }

        public int? BytesRequiredInCtiServer { get; set; }

        public new int? ChangeStamp { get; set; }

        public bool? CiscoProvided { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public bool? EccArray { get; set; }

        public bool? Enabled { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public int? MaximumArraySize { get; set; }

        public int? MaximumLength { get; set; }

        public string? Name { get; set; }

        public bool? Persistent { get; set; }

        public new string? RefURL { get; set; }

        // Path("expandedcallvariable")
        [XmlRoot("results")]
        public class ExpandedCallVariableList : BaseApiListBean<ExpandedCallVariable>
        {
            public override List<ExpandedCallVariable>? GetItems() => Items;

            public override void SetItems(List<ExpandedCallVariable>? value) => Items = value;
        }
    }
}