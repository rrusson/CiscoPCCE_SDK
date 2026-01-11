using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("sqlUsers")]
            [XmlArrayItem("sqlUser")]
            public new List<SqlUser>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SqlUser>? GetItems() => Items;

            public override void SetItems(List<SqlUser>? value) => Items = value;
        }
    }
}