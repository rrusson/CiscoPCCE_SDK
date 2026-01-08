using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("dnc")]
    public class ImportRule : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("filePath")]
        public string? FilePath { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("overwrite")]
        public bool? OverwriteEnabled { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("renameFileAfterImport")]
        public bool? RenameEnabled { get; set; }

        // Path("dnc")
        [XmlRoot("results")]
        public class ImportRuleList : BaseApiListBean<ImportRule>
        {
            public override List<ImportRule>? GetItems() => Items;

            public override void SetItems(List<ImportRule>? value) => Items = value;
        }
    }
}