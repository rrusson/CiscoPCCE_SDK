using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("masterScript")]
    public class MasterScript : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("currentVersion")]
        public int? CurrentVersion { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("script")]
        public required ScriptVersion Script { get; set; }

        [XmlElement("scriptType")]
        public int? ScriptType { get; set; }

        [XmlArray("##default")]
        [XmlArrayItem("scriptVersion")]
        public List<ReferenceBean>? ScriptVersions { get; set; }

        // Path("masterscript")
        [XmlRoot("results")]
        public class MasterScriptList : BaseApiListBean<MasterScript>
        {
            [XmlArray("masterScripts")]
            [XmlArrayItem("masterScript")]
            public new List<MasterScript>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MasterScript>? GetItems() => Items;

            public override void SetItems(List<MasterScript>? value) => Items = value;
        }
    }
}