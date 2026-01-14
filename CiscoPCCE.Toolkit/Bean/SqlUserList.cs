using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sqluser")
    [XmlRoot("results")]
    public class SqlUserList : BaseApiList<SqlUser>
    {
        [XmlArray("sqlUsers")]
        [XmlArrayItem("sqlUser")]
        public new List<SqlUser>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}