using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("results")]
    public class SipServerElementList : BaseApiList<SipServerElement>
    {
        [XmlArray("elements")]
        [XmlArrayItem("element")]
        public new List<SipServerElement>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}