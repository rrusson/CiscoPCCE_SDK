using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("instance")
    [XmlRoot("results")]
    public class WebsetupInstanceList : BaseApiBean
    {
        // Path("instance")
        [XmlRoot("results")]
        public class WebsetupInstanceListList : BaseApiListBean<WebsetupInstanceList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<WebsetupInstanceList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<WebsetupInstanceList>? GetItems() => Items;

            public override void SetItems(List<WebsetupInstanceList>? value) => Items = value;
        }
    }
}