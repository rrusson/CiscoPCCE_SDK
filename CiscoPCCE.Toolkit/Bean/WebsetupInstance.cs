using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("instance")
    [XmlRoot("instance")]
    public class WebsetupInstance : BaseApiBean
    {
        [XmlElement("facilityName")]
        public string? FacilityName { get; set; }

        [XmlElement("instanceName")]
        public string? InstanceName { get; set; }

        [XmlElement("refURL")]
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