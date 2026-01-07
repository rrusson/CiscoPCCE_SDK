using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("label")]
    public class Label : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required ReferenceBean NetworkTarget { get; set; }

        public new string? RefURL { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class LabelList : BaseApiListBean<Label>
        {
            public override List<Label>? GetItems() => Items;

            public override void SetItems(List<Label>? value) => Items = value;
        }
    }
}