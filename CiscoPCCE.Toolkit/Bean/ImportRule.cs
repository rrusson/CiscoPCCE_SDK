using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("dnc")]
    public class ImportRule : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        [XmlElement("filePath")]
        public string? FilePath { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("overwrite")]
        public bool? OverwriteEnabled { get; set; }

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