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
            public override List<WebsetupInstanceList>? GetItems() => Items;

            public override void SetItems(List<WebsetupInstanceList>? value) => Items = value;
        }
    }
}