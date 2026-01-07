using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("pim")]
public class WebsetupPim : BaseApiBean {
  private string? address;
  private string? mobileAgentCodec;
  private string? password;
  private string? peripheralId;
  private string? type;
  private string? userName;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public string? MobileAgentCodec
  {
      get => mobileAgentCodec;
      set => mobileAgentCodec = value;
  }


  public void setMobileAgentCodec(String mobileAgentCodec) {
     this.mobileAgentCodec = mobileAgentCodec;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(String peripheralId) {
     this.peripheralId = peripheralId;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


}

}