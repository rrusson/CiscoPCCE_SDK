using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("initialize")
[XmlRoot("##default")]
public class InitialSettings : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private ReferenceBean cmSideA;
  private ReferenceBean cmSideB;
  private string? correlationId;
  private ReferenceBean department;
  private int? hardwareLayoutType;
  private string? idFromRefUrl;
  private string? mobileAgentCodec;
  private string? refURL;
  private string? serviceAccountPassword;
  private string? serviceAccountUserName;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean CmSideA
  {
      get => cmSideA;
      set => cmSideA = value;
  }


  public void setCmSideA(ReferenceBean cmSideA) {
     this.cmSideA = cmSideA;
  }

  public ReferenceBean CmSideB
  {
      get => cmSideB;
      set => cmSideB = value;
  }


  public void setCmSideB(ReferenceBean cmSideB) {
     this.cmSideB = cmSideB;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public int? HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }


  public void setHardwareLayoutType(int? hardwareLayoutType) {
     this.hardwareLayoutType = hardwareLayoutType;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? MobileAgentCodec
  {
      get => mobileAgentCodec;
      set => mobileAgentCodec = value;
  }


  public void setMobileAgentCodec(String mobileAgentCodec) {
     this.mobileAgentCodec = mobileAgentCodec;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? ServiceAccountPassword
  {
      get => serviceAccountPassword;
      set => serviceAccountPassword = value;
  }


  public void setServiceAccountPassword(String serviceAccountPassword) {
     this.serviceAccountPassword = serviceAccountPassword;
  }

  public string? ServiceAccountUserName
  {
      get => serviceAccountUserName;
      set => serviceAccountUserName = value;
  }


  public void setServiceAccountUserName(String serviceAccountUserName) {
     this.serviceAccountUserName = serviceAccountUserName;
  }


  // Path("initialize")
  [XmlRoot("results")]
  public class InitialSettingsList : BaseApiListBean<InitialSettings> {
    [XmlElement("##defaults")]
    [XmlElement("##default")]
   
    public override List<InitialSettings>? GetItems() => items;

    public override void SetItems(List<InitialSettings>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InitialSettings>? items)
    {
        this.items = items;
    }
  }
}

}