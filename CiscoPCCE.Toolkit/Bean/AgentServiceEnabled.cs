using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AgentServiceEnabled : BaseApiBean {
  private string? mappedServiceType;

  public string? MappedServiceType
  {
      get => mappedServiceType;
      set => mappedServiceType = value;
  }


  public void setMappedServiceType(String mappedServiceType) {
     this.mappedServiceType = mappedServiceType;
  }


}

}