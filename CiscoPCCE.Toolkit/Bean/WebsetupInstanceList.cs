using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("instance")
    [XmlRoot("results")]
    public class WebsetupInstanceList : BaseApiList<WebsetupInstance>
    {
        [XmlArray("instances")]
        [XmlArrayItem("instance")]
        public new List<WebsetupInstance>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}