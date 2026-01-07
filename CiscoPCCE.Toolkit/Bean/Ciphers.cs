using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class Ciphers : BaseApiBean {
  
  [XmlElement("cipher")]
  public List<string?>? Cipherlist { get; set; }

}

}