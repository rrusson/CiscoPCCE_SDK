using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sqluser")
    [XmlRoot("sqlUser")]
    public class SqlUser : BaseApiBean
    {
        [XmlElement("loginName")]
        public string? LoginName { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        // Path("sqluser")
        [XmlRoot("results")]
        public class SqlUserList : BaseApiListBean<SqlUser>
        {
            public override List<SqlUser>? GetItems() => Items;

            public override void SetItems(List<SqlUser>? value) => Items = value;
        }
    }
}