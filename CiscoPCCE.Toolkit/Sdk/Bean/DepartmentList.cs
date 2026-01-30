using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/department")
    [XmlRoot("results")]
    public class DepartmentList : BaseApiWrappedList<Department>
    {
        [XmlArray("departments")]
        [XmlArrayItem("department")]
        public new List<Department>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}