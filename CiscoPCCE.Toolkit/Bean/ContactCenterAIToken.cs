using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai/token")
    [XmlRoot("contactCenterAIToken")]
    public class ContactCenterAIToken : BaseApiBean
    {
        public string? AccessToken { get; set; }

        public string? CmsUrl { get; set; }

        public string? ExpiresIn { get; set; }

        public string? OrgId { get; set; }

        public string? U2cHost { get; set; }

        // Path("contactcenterai/token")
        [XmlRoot("results")]
        public class ContactCenterAITokenList : BaseApiListBean<ContactCenterAIToken>
        {
            public override List<ContactCenterAIToken>? GetItems() => Items;

            public override void SetItems(List<ContactCenterAIToken>? value) => Items = value;
        }
    }
}