using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("sqlUser")]
    public class SqlUser : BaseApiBean
    {
        [XmlElement("loginName")]
        public string? LoginName { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }
    }
}