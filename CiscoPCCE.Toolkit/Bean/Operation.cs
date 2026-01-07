using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class Operation : BaseApiBean {
      
  public ChangeSet ChangeSet { get; set; }

  public OperationType OperationType { get; set; }

  [XmlElement("refURLs")]
  [XmlElement("refURL")]
  public List<string?>? RefUrls { get; set; }

}

}