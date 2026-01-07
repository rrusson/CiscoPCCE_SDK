using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("networkVru")]
    public class NetworkVru : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int Type { get; set; }

        // Path("networkvru")
        [XmlRoot("results")]
        public class NetworkVruList : BaseApiListBean<NetworkVru>
        {
            public override List<NetworkVru>? GetItems() => Items;

            public override void SetItems(List<NetworkVru>? value) => Items = value;
        }
    }
}