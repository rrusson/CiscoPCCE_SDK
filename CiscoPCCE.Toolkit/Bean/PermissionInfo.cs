using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class PermissionInfo : BaseApiBean
    {
        [XmlElement("canCreate")]
        public bool? CanCreate { get; set; }

        [XmlElement("canDelete")]
        public bool? CanDelete { get; set; }

        [XmlElement("canUpdate")]
        public bool? CanUpdate { get; set; }

        [XmlElement("departmentAdmin")]
        public bool? DepartmentAdmin { get; set; }

        [XmlElement("role")]
        public string? Role { get; set; }
    }
}