using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai/token")
    [XmlRoot("contactCenterAIToken")]
    public class ContactCenterAIToken : BaseApiBean
    {
        [XmlElement("accessToken")]
        public string? AccessToken { get; set; }

        [XmlElement("cmsUrl")]
        public string? CmsUrl { get; set; }

        [XmlElement("expiresIn")]
        public string? ExpiresIn { get; set; }

        [XmlElement("orgId")]
        public string? OrgId { get; set; }

        [XmlElement("u2cHost")]
        public string? U2cHost { get; set; }

        // Path("contactcenterai/token")
        [XmlRoot("results")]
        public class ContactCenterAITokenList : BaseApiListBean<ContactCenterAIToken>
        {
            [XmlArray("contactCenterAITokens")]
            [XmlArrayItem("contactCenterAIToken")]
            public new List<ContactCenterAIToken>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactCenterAIToken>? GetItems() => Items;

            public override void SetItems(List<ContactCenterAIToken>? value) => Items = value;
        }
    }
}