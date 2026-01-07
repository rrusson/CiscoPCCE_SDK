using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AgentPG : BaseApiBean {
  private ReferenceBean cmSubSideA;
  private ReferenceBean cmSubSideB;
  private bool? configured;
  private string? finessePassword;
  private string? finessePrimaryAddress;
  private string? finesseUserName;
  private string? mobileAgentCodec;

  public ReferenceBean CmSubSideA
  {
      get => cmSubSideA;
      set => cmSubSideA = value;
  }


  public void setCmSubSideA(ReferenceBean cmSubSideA) {
     this.cmSubSideA = cmSubSideA;
  }

  public ReferenceBean CmSubSideB
  {
      get => cmSubSideB;
      set => cmSubSideB = value;
  }


  public void setCmSubSideB(ReferenceBean cmSubSideB) {
     this.cmSubSideB = cmSubSideB;
  }

  [XmlElement("configured")]
  public bool? Configured
  {
      get => configured;
      set => configured = value;
  }


  public void setConfigured(Boolean configured) {
     this.configured = configured;
  }

  public string? FinessePassword
  {
      get => finessePassword;
      set => finessePassword = value;
  }


  public void setFinessePassword(String finessePassword) {
     this.finessePassword = finessePassword;
  }

  public string? FinessePrimaryAddress
  {
      get => finessePrimaryAddress;
      set => finessePrimaryAddress = value;
  }


  public void setFinessePrimaryAddress(String finessePrimaryAddress) {
     this.finessePrimaryAddress = finessePrimaryAddress;
  }

  public string? FinesseUserName
  {
      get => finesseUserName;
      set => finesseUserName = value;
  }


  public void setFinesseUserName(String finesseUserName) {
     this.finesseUserName = finesseUserName;
  }

  public string? MobileAgentCodec
  {
      get => mobileAgentCodec;
      set => mobileAgentCodec = value;
  }


  public void setMobileAgentCodec(String mobileAgentCodec) {
     this.mobileAgentCodec = mobileAgentCodec;
  }


}

}