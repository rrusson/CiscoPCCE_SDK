using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/department")
    [XmlRoot("results")]
    public class DepartmentList : BaseApiBean
    {
        [XmlArray("departments")]
        [XmlArrayItem("department")]
        public List<Department>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("/department")
        [XmlRoot("results")]
        public class DepartmentListList : BaseApiListBean<DepartmentList>
        {
            public override List<DepartmentList>? GetItems() => Items;

            public override void SetItems(List<DepartmentList>? value) => Items = value;
        }
    }
}