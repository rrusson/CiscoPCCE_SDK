using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Timeout : BaseApiBean
    {
        [XmlElement("abandon")]
        public int? Abandon { get; set; }

        [XmlElement("late")]
        public int? Late { get; set; }

        [XmlElement("request")]
        public int? Request { get; set; }
    }
}