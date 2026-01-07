using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("instance")
    [XmlRoot("instance")]
    public class WebsetupInstance : BaseApiBean
    {
        public string? FacilityName { get; set; }

        public string? InstanceName { get; set; }

        public new string? RefURL { get; set; }

        // Path("instance")
        [XmlRoot("results")]
        public class WebsetupInstanceList : BaseApiListBean<WebsetupInstance>
        {
            public override List<WebsetupInstance>? GetItems() => Items;

            public override void SetItems(List<WebsetupInstance>? value) => Items = value;
        }
    }
}