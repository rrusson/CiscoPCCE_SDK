using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvruscript")
    [XmlRoot("networkVruScript")]
    public class NetworkVruScript : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("configParam")]
        public string? ConfigParam { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("interruptible")]
        public bool? Interruptible { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("routingType")]
        public int? RoutingType { get; set; }

        [XmlElement("timeout")]
        public int? Timeout { get; set; }

        [XmlElement("vruScriptName")]
        public string? VruScriptName { get; set; }

        // Path("networkvruscript")
        [XmlRoot("results")]
        public class NetworkVruScriptList : BaseApiListBean<NetworkVruScript>
        {
            [XmlArray("networkVruScripts")]
            [XmlArrayItem("networkVruScript")]
            public new List<NetworkVruScript>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<NetworkVruScript>? GetItems() => Items;

            public override void SetItems(List<NetworkVruScript>? value) => Items = value;
        }
    }
}