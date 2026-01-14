using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CongestionControlPermissionInfo : BaseApiBean
    {
        [XmlElement("canChangeDeploymentType")]
        public bool? CanChangeDeploymentType { get; set; }

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