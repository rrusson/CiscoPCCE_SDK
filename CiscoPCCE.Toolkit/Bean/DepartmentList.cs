using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<DepartmentList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DepartmentList>? GetItems() => Items;

            public override void SetItems(List<DepartmentList>? value) => Items = value;
        }
    }
}