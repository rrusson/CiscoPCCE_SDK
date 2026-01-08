using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("sipServerGroupProperties")]
    public class SIPServerGroupProperties : BaseApiBean
    {
        [XmlElement("optionsOverrideHost")]
        public string? OptionsOverrideHost { get; set; }

        [XmlElement("serverGroupDownInterval")]
        public int? ServerGroupDownInterval { get; set; }

        [XmlElement("serverGroupHBLocalListenPort")]
        public int? ServerGroupHBLocalListenPort { get; set; }

        [XmlElement("serverGroupHBMethod")]
        public string? ServerGroupHBMethod { get; set; }

        [XmlElement("serverGroupHBNumTries")]
        public int? ServerGroupHBNumTries { get; set; }

        [XmlElement("serverGroupHBTimeout")]
        public int? ServerGroupHBTimeout { get; set; }

        [XmlElement("serverGroupHBTransportType")]
        public string? ServerGroupHBTransportType { get; set; }

        [XmlElement("serverGroupHeartbeats")]
        public bool? ServerGroupHeartbeats { get; set; }

        [XmlElement("serverGroupOverloadedResponseCodes")]
        public string? ServerGroupOverloadedResponseCodes { get; set; }

        [XmlElement("serverGroupUpInterval")]
        public int? ServerGroupUpInterval { get; set; }

        // Path("sipservergroupproperties")
        [XmlRoot("results")]
        public class SIPServerGroupPropertiesList : BaseApiListBean<SIPServerGroupProperties>
        {
            [XmlArray("sipServerGroupPropertiess")]
            [XmlArrayItem("sipServerGroupProperties")]
            public new List<SIPServerGroupProperties>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SIPServerGroupProperties>? GetItems() => Items;

            public override void SetItems(List<SIPServerGroupProperties>? value) => Items = value;
        }
    }
}