using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("ccb")
    [XmlRoot("results")]
    public class CCBConfigList : BaseApiList<CCBConfig>
    {
        [XmlArray("CCBs")]
        [XmlArrayItem("CCB")]
        public new List<CCBConfig>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}