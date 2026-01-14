using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("results")]
    public class CampaignList : BaseApiWrappedList<Campaign>
    {
        [XmlArray("campaigns")]
        [XmlArrayItem("campaign")]
        public new List<Campaign>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}