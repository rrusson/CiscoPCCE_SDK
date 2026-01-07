using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class Ciphers : BaseApiBean {
  private List<string?>? cipherlist;

  [XmlElement("cipher")]
  public List<string?>? Cipherlist
  {
      get => cipherlist;
      set => cipherlist = value;
  }


  public void setCipherlist(List<String> cipherlist) {
     this.cipherlist = cipherlist;
  }


}

}