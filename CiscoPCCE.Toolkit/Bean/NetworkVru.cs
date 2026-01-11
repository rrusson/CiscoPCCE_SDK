using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("networkVru")]
    public class NetworkVru : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("type")]
        public int Type { get; set; }

        // Path("networkvru")
        [XmlRoot("results")]
        public class NetworkVruList : BaseApiListBean<NetworkVru>
        {
            [XmlArray("networkVrus")]
            [XmlArrayItem("networkVru")]
            public new List<NetworkVru>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<NetworkVru>? GetItems() => Items;

            public override void SetItems(List<NetworkVru>? value) => Items = value;
        }
    }
}