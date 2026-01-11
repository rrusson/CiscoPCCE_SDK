using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dataSources")]
    public class CuicDataSources : BaseApiBean
    {
        [XmlElement("dataSource")]
        public List<CuicDataSourceRef>? Items { get; set; }
    }
}