using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class OverrideMediaTermination : BaseApiBean {
  
  public List<NameUriPair>? DialogGroup { get; set; }

}

}