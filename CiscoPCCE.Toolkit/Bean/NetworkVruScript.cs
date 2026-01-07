using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvruscript")
    [XmlRoot("networkVruScript")]
    public class NetworkVruScript : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? ConfigParam { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? Interruptible { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? RoutingType { get; set; }

        public int? Timeout { get; set; }

        public string? VruScriptName { get; set; }

        // Path("networkvruscript")
        [XmlRoot("results")]
        public class NetworkVruScriptList : BaseApiListBean<NetworkVruScript>
        {
            public override List<NetworkVruScript>? GetItems() => Items;

            public override void SetItems(List<NetworkVruScript>? value) => Items = value;
        }
    }
}