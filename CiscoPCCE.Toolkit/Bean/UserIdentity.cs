using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("useridentity")
    [XmlRoot("userIdentity")]
    public class UserIdentity : BaseApiBean
    {
        [XmlElement("displayName")]
        public string? DisplayName { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("role")]
        public string? Role { get; set; }

        [XmlElement("username")]
        public string? Username { get; set; }

        // Path("useridentity")
        [XmlRoot("results")]
        public class UserIdentityList : BaseApiListBean<UserIdentity>
        {
            [XmlArray("userIdentitys")]
            [XmlArrayItem("userIdentity")]
            public new List<UserIdentity>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<UserIdentity>? GetItems() => Items;

            public override void SetItems(List<UserIdentity>? value) => Items = value;
        }
    }
}