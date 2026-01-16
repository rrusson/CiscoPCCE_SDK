using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("department")]
    public class Department : BaseApiBean
    {
        [XmlArray("administrators")]
        [XmlArrayItem("administrator")]
        public List<ReferenceBean>? Administrators { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

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

    }
}