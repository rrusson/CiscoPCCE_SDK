using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("transferablefiles")
    [XmlRoot("IVRApplication")]
    public class IVRApplication : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("createDateTime")]
        public string? CreateDateTime { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("fileName")]
        public string? FileName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("size")]
        public string? Size { get; set; }

        // Path("transferablefiles")
        [XmlRoot("results")]
        public class IVRApplicationList : BaseApiListBean<IVRApplication>
        {
            [XmlArray("IVRApplications")]
            [XmlArrayItem("IVRApplication")]
            public new List<IVRApplication>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<IVRApplication>? GetItems() => Items;

            public override void SetItems(List<IVRApplication>? value) => Items = value;
        }
    }
}