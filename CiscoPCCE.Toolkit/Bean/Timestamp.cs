using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Timestamp : BaseApiBean
    {
        [XmlElement("date")]
        public int Date { get; set; }

        [XmlElement("hours")]
        public int Hours { get; set; }

        [XmlElement("minutes")]
        public int Minutes { get; set; }

        [XmlElement("month")]
        public int Month { get; set; }

        [XmlElement("nanos")]
        public int Nanos { get; set; }

        [XmlElement("seconds")]
        public int Seconds { get; set; }

        [XmlElement("time")]
        public long Time { get; set; }

        [XmlElement("year")]
        public int Year { get; set; }
    }
}