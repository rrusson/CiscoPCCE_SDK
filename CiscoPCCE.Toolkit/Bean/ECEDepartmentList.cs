using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("departments")]
    public class ECEDepartmentList : BaseApiBean
    {
        public List<ECEDepartment>? Departments { get; set; }
    }
}