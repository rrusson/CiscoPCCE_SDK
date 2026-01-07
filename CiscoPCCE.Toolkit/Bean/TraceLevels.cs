using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("tracelevel")
    [XmlRoot("traceLevels")]
    public class TraceLevels : BaseApiBean
    {
        [XmlElement("component")]
        public List<Component>? Components { get; set; }

        // Path("tracelevel")
        [XmlRoot("results")]
        public class TraceLevelsList : BaseApiListBean<TraceLevels>
        {
            public override List<TraceLevels>? GetItems() => Items;

            public override void SetItems(List<TraceLevels>? value) => Items = value;
        }
    }
}