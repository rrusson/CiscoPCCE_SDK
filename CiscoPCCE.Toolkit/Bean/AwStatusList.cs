using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("awstatus")
    [XmlRoot("results")]
    public class AwStatusList : BaseApiList<AwStatus>
    {
        [XmlArray("awStatuss")]
        [XmlArrayItem("awStatus")]
        public new List<AwStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}