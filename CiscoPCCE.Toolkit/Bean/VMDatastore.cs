using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class VMDatastore : BaseApiBean {
        
  public long? MaxSizeInGB { get; set; }

  public long? MinSizeInGB { get; set; }

  public long? SizeInGB { get; set; }

  [XmlElement("vmsToMatch")]
  [XmlElement("vm")]
  public List<VMProfile>? VmsToMatch { get; set; }

}

}