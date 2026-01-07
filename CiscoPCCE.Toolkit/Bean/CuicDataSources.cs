using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("dataSources")]
public class CuicDataSources : BaseApiBean {
  private List<CuicDataSourceRef>? items;

  [XmlElement("dataSource")]
  public List<CuicDataSourceRef>? Items
  {
      get => items;
      set => items = value;
  }


}

}