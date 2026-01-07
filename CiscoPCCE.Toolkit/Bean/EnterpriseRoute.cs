using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("enterpriseRoute")]
    public class EnterpriseRoute : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int EntityID { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("enterpriseroute")
        [XmlRoot("results")]
        public class EnterpriseRouteList : BaseApiListBean<EnterpriseRoute>
        {
            public override List<EnterpriseRoute>? GetItems() => Items;

            public override void SetItems(List<EnterpriseRoute>? value) => Items = value;
        }
    }
}