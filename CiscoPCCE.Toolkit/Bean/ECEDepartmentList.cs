using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("departments")]
    public class ECEDepartmentList : BaseApiBean
    {
        public List<ECEDepartment>? Departments { get; set; }
    }
}