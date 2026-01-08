using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Term : BaseApiBean
    {
        [XmlElement("attribute")]
        public required ReferenceBean Attribute { get; set; }

        [XmlElement("attributeRelation")]
        public int? AttributeRelation { get; set; }

        [XmlElement("parenCount")]
        public int? ParenCount { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("termRelation")]
        public int? TermRelation { get; set; }

        [XmlElement("value1")]
        public string? Value1 { get; set; }
    }
}