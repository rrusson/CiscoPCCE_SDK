using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("administrator")]
    public class Administrator : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Customer { get; set; }

        public required ReferenceBean Department { get; set; }

        [XmlElement("departments")]
        [XmlElement("department")]
        public List<ReferenceBean>? Departments { get; set; }

        public string? Description { get; set; }

        public string? DomainName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? ReadOnly { get; set; }

        public new string? RefURL { get; set; }

        public required ReferenceBean Role { get; set; }

        public bool? SsoEnabled { get; set; }

        public bool? Supervisor { get; set; }

        public string? UserName { get; set; }

        // Path("administrator")
        [XmlRoot("results")]
        public class AdministratorList : BaseApiListBean<Administrator>
        {
            public override List<Administrator>? GetItems() => Items;

            public override void SetItems(List<Administrator>? value) => Items = value;
        }
    }
}