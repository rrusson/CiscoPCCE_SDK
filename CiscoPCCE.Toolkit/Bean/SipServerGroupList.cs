using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("results")]
    public class SipServerGroupList : BaseApiWrappedList<SipServerGroup>
    {
        [XmlArray("sipServerGroups")]
        [XmlArrayItem("sipServerGroup")]
        public new List<SipServerGroup>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}