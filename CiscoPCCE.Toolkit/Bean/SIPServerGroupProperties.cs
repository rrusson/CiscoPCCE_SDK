using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("sipServerGroupProperties")]
    public class SIPServerGroupProperties : BaseApiBean
    {
        public string? OptionsOverrideHost { get; set; }

        public int? ServerGroupDownInterval { get; set; }

        public int? ServerGroupHBLocalListenPort { get; set; }

        public string? ServerGroupHBMethod { get; set; }

        public int? ServerGroupHBNumTries { get; set; }

        public int? ServerGroupHBTimeout { get; set; }

        public string? ServerGroupHBTransportType { get; set; }

        public bool? ServerGroupHeartbeats { get; set; }

        public string? ServerGroupOverloadedResponseCodes { get; set; }

        public int? ServerGroupUpInterval { get; set; }

        // Path("sipservergroupproperties")
        [XmlRoot("results")]
        public class SIPServerGroupPropertiesList : BaseApiListBean<SIPServerGroupProperties>
        {
            public override List<SIPServerGroupProperties>? GetItems() => Items;

            public override void SetItems(List<SIPServerGroupProperties>? value) => Items = value;
        }
    }
}