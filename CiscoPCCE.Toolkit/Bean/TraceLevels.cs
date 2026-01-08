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
            [XmlArray("traceLevelss")]
            [XmlArrayItem("traceLevels")]
            public new List<TraceLevels>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<TraceLevels>? GetItems() => Items;

            public override void SetItems(List<TraceLevels>? value) => Items = value;
        }
    }
}