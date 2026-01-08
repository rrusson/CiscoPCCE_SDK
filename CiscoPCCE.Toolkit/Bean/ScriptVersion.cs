using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("scriptVersion")]
    public class ScriptVersion : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("dateTime")]
        public DateTime? DateTime { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("##default")]
        [XmlArrayItem("reference")]
        public List<ScriptCrossReference>? References { get; set; }

        [XmlElement("version")]
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