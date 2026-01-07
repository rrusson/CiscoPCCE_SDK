using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("stats")
    [XmlRoot("stats")]
    public class Stats : BaseApiBean
    {
        [XmlElement("numberOfAgentsLoggedIn")]
        public int NumberOfAgentsLoggedIn { get; set; }

        // Path("stats")
        [XmlRoot("results")]
        public class StatsList : BaseApiListBean<Stats>
        {
            public override List<Stats>? GetItems() => Items;

            public override void SetItems(List<Stats>? value) => Items = value;
        }
    }
}