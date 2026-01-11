using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("status")
    [XmlRoot("SystemInfo")]
    public class FinesseSystemInfo : BaseApiBean
    {
        [XmlElement("##default")]
        public string? Status { get; set; }

        // Path("status")
        [XmlRoot("results")]
        public class FinesseSystemInfoList : BaseApiListBean<FinesseSystemInfo>
        {
            [XmlArray("SystemInfos")]
            [XmlArrayItem("SystemInfo")]
            public new List<FinesseSystemInfo>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<FinesseSystemInfo>? GetItems() => Items;

            public override void SetItems(List<FinesseSystemInfo>? value) => Items = value;
        }
    }
}