using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("masterScript")]
    public class MasterScript : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? CurrentVersion { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public required ScriptVersion Script { get; set; }

        public int? ScriptType { get; set; }

        [XmlElement("##default")]
        [XmlElement("scriptVersion")]
        public List<ReferenceBean>? ScriptVersions { get; set; }

        // Path("masterscript")
        [XmlRoot("results")]
        public class MasterScriptList : BaseApiListBean<MasterScript>
        {
            public override List<MasterScript>? GetItems() => Items;

            public override void SetItems(List<MasterScript>? value) => Items = value;
        }
    }
}