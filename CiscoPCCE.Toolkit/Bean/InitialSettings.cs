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

  public ReferenceBean CmSideA
  {
      get => cmSideA;
      set => cmSideA = value;
  }

  public ReferenceBean CmSideB
  {
      get => cmSideB;
      set => cmSideB = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public int? HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? MobileAgentCodec
  {
      get => mobileAgentCodec;
      set => mobileAgentCodec = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? ServiceAccountPassword
  {
      get => serviceAccountPassword;
      set => serviceAccountPassword = value;
  }

  public string? ServiceAccountUserName
  {
      get => serviceAccountUserName;
      set => serviceAccountUserName = value;
  }

  // Path("initialize")
  [XmlRoot("results")]
  public class InitialSettingsList : BaseApiListBean<InitialSettings> {    public override List<InitialSettings>? GetItems() => items;

    public override void SetItems(List<InitialSettings>? value) => items = value;

  }
}

}