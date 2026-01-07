using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("scriptVersion")]
    public class ScriptVersion : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public DateTime? DateTime { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("##default")]
        [XmlElement("reference")]
        public List<ScriptCrossReference>? References { get; set; }

        public int? Version { get; set; }

        // Path("masterscript")
        [XmlRoot("results")]
        public class ScriptVersionList : BaseApiListBean<ScriptVersion>
        {
            public override List<ScriptVersion>? GetItems() => Items;

            public override void SetItems(List<ScriptVersion>? value) => Items = value;
        }
    }
}