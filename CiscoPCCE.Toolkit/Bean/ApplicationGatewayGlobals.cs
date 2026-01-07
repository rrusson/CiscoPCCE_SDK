using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgatewayglobalsetting")
    [XmlRoot("applicationGatewayGlobalSetting")]
    public class ApplicationGatewayGlobals : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required ConnectionParametersGlobal ConnectionParameters { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public ApplicationGatewayType Type { get; set; }

        // Path("applicationgatewayglobalsetting")
        [XmlRoot("results")]
        public class ApplicationGatewayGlobalsList : BaseApiListBean<ApplicationGatewayGlobals>
        {
            public override List<ApplicationGatewayGlobals>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayGlobals>? value) => Items = value;
        }
    }
}