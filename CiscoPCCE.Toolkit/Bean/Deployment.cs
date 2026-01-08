using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deployment")
    [XmlRoot("deployment")]
    public class Deployment : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentType")]
        public int? DeploymentType { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("supervisorLoginAllowed")]
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