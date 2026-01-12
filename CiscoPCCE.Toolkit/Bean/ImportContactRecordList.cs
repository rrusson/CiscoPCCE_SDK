using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("import")
    [XmlRoot("results")]
    public class ImportContactRecordList : BaseApiList<ImportContactRecord>
    {
        [XmlArray("importContacts")]
        [XmlArrayItem("importContact")]
        public new List<ImportContactRecord>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}