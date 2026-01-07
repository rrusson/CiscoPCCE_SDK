using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("transferablefiles")
    [XmlRoot("IVRApplication")]
    public class IVRApplication : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public string? CreateDateTime { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? FileName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public string? Size { get; set; }

        // Path("transferablefiles")
        [XmlRoot("results")]
        public class IVRApplicationList : BaseApiListBean<IVRApplication>
        {
            public override List<IVRApplication>? GetItems() => Items;

            public override void SetItems(List<IVRApplication>? value) => Items = value;
        }
    }
}