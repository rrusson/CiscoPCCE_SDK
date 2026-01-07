using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/department")
    [XmlRoot("department")]
    public class Department : BaseApiBean
    {
        [XmlElement("administrators")]
        [XmlElement("administrator")]
        public List<ReferenceBean>? Administrators { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean DepartmentRef { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("/department")
        [XmlRoot("results")]
        public class DepartmentList : BaseApiListBean<Department>
        {
            public override List<Department>? GetItems() => Items;

            public override void SetItems(List<Department>? value) => Items = value;
        }
    }
}