using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgatewayglobalsetting")
    [XmlRoot("applicationGatewayGlobalSetting")]
    public class ApplicationGatewayGlobals : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("connectionParameters")]
        public required ConnectionParametersGlobal ConnectionParameters { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("type")]
        public ApplicationGatewayType Type { get; set; }

        // Path("applicationgatewayglobalsetting")
        [XmlRoot("results")]
        public class ApplicationGatewayGlobalsList : BaseApiListBean<ApplicationGatewayGlobals>
        {
            [XmlArray("applicationGatewayGlobalSettings")]
            [XmlArrayItem("applicationGatewayGlobalSetting")]
            public new List<ApplicationGatewayGlobals>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationGatewayGlobals>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayGlobals>? value) => Items = value;
        }
    }
}