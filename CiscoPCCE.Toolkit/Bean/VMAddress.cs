using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMAddress : BaseApiBean {
  private string? ipAddress;
  private string? name;
  private string? networkType;

  public string? IpAddress
  {
      get => ipAddress;
      set => ipAddress = value;
  }


  public void setIpAddress(String ipAddress) {
     this.ipAddress = ipAddress;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? NetworkType
  {
      get => networkType;
      set => networkType = value;
  }


  public void setNetworkType(String networkType) {
     this.networkType = networkType;
  }


}

}