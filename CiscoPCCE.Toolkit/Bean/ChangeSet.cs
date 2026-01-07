using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class ChangeSet : BaseApiBean {
  
  public List<BaseDbRestBean>? Beans { get; set; }

}

}