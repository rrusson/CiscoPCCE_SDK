using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("status")
    [XmlRoot("results")]
    public class FinesseSystemInfoList : BaseApiList<FinesseSystemInfo>
    {
        [XmlArray("SystemInfos")]
        [XmlArrayItem("SystemInfo")]
        public new List<FinesseSystemInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}