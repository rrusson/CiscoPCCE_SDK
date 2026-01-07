using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deployment")
    [XmlRoot("deployment")]
    public class Deployment : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? DeploymentType { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? SupervisorLoginAllowed { get; set; }

        // Path("deployment")
        [XmlRoot("results")]
        public class DeploymentList : BaseApiListBean<Deployment>
        {
            public override List<Deployment>? GetItems() => Items;

            public override void SetItems(List<Deployment>? value) => Items = value;
        }
    }
}