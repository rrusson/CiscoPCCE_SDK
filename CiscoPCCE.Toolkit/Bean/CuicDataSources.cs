using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dataSources")]
    public class CuicDataSources : BaseApiBean
    {
        [XmlElement("dataSource")]
        public List<CuicDataSourceRef>? Items { get; set; }
    }
}