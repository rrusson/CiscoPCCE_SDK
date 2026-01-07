using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("dialedNumberCollection")]
public class DialedNumberCollection : BaseApiBean {
  private Collection dialedNumberConfigs;

  public Collection DialedNumberConfigs
  {
      get => dialedNumberConfigs;
      set => dialedNumberConfigs = value;
  }


  public void setDialedNumberConfigs(Collection dialedNumberConfigs) {
     this.dialedNumberConfigs = dialedNumberConfigs;
  }


}

}