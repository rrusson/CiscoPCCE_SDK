using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/department")
    [XmlRoot("department")]
    public class Department : BaseApiBean
    {
        [XmlArray("administrators")]
        [XmlArrayItem("administrator")]
        public List<ReferenceBean>? Administrators { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("departmentRef")]
        public required ReferenceBean DepartmentRef { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("/department")
        [XmlRoot("results")]
        public class DepartmentList : BaseApiListBean<Department>
        {
            [XmlArray("departments")]
            [XmlArrayItem("department")]
            public new List<Department>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Department>? GetItems() => Items;

            public override void SetItems(List<Department>? value) => Items = value;
        }
    }
}