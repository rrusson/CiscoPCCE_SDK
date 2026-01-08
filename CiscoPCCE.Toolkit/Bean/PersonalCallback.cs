using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("personalCallback")]
    public class PersonalCallback : BaseApiBean
    {
        [XmlElement("delimiter")]
        public string? Delimiter { get; set; }

        [XmlElement("fileContent")]
        public string? FileContent { get; set; }

        [XmlElement("overwriteData")]
        public bool? OverwriteData { get; set; }

        // Path("personalcallback")
        [XmlRoot("results")]
        public class PersonalCallbackList : BaseApiListBean<PersonalCallback>
        {
            public override List<PersonalCallback>? GetItems() => Items;

            public override void SetItems(List<PersonalCallback>? value) => Items = value;
        }
    }
}