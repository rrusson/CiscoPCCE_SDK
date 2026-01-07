using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("ccb")
    [XmlRoot("CCB")]
    public class CCBConfig : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public string? ReportingAddress { get; set; }

        // Path("ccb")
        [XmlRoot("results")]
        public class CCBConfigList : BaseApiListBean<CCBConfig>
        {
            public override List<CCBConfig>? GetItems() => Items;

            public override void SetItems(List<CCBConfig>? value) => Items = value;
        }
    }
}