using System.Xml.Serialization;

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
            public override List<FinesseSystemInfo>? GetItems() => Items;

            public override void SetItems(List<FinesseSystemInfo>? value) => Items = value;
        }
    }
}