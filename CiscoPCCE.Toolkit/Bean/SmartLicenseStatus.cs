using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("smartLicenseStatus")]
public class SmartLicenseStatus : BaseApiBean {
  private string? agentEnabled;
  private string? serialNumber;
  private string? state;

  public string? AgentEnabled
  {
      get => agentEnabled;
      set => agentEnabled = value;
  }


  public void setAgentEnabled(String agentEnabled) {
     this.agentEnabled = agentEnabled;
  }

  public string? SerialNumber
  {
      get => serialNumber;
      set => serialNumber = value;
  }


  public void setSerialNumber(String serialNumber) {
     this.serialNumber = serialNumber;
  }

  public string? State
  {
      get => state;
      set => state = value;
  }


  public void setState(String state) {
     this.state = state;
  }


}

}