using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("enterpriseRoute")]
    public class EnterpriseRoute : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("entityID")]
        public int EntityID { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("enterpriseroute")
        [XmlRoot("results")]
        public class EnterpriseRouteList : BaseApiListBean<EnterpriseRoute>
        {
            [XmlArray("enterpriseRoutes")]
            [XmlArrayItem("enterpriseRoute")]
            public new List<EnterpriseRoute>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<EnterpriseRoute>? GetItems() => Items;

            public override void SetItems(List<EnterpriseRoute>? value) => Items = value;
        }
    }
}