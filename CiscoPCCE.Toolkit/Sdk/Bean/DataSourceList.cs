using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("results")]
    public class DataSourceList : BaseApiList<DataSource>
    {
        [XmlArray("dataSources")]
        [XmlArrayItem("dataSource")]
        public new List<DataSource>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}