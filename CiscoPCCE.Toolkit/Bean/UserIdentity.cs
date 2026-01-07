using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("useridentity")
    [XmlRoot("userIdentity")]
    public class UserIdentity : BaseApiBean
    {
        public string? DisplayName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Role { get; set; }

        public string? Username { get; set; }

        // Path("useridentity")
        [XmlRoot("results")]
        public class UserIdentityList : BaseApiListBean<UserIdentity>
        {
            public override List<UserIdentity>? GetItems() => Items;

            public override void SetItems(List<UserIdentity>? value) => Items = value;
        }
    }
}