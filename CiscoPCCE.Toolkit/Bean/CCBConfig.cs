using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("ccb")
[XmlRoot("CCB")]
public class CCBConfig : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;
  private string? reportingAddress;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? ReportingAddress
  {
      get => reportingAddress;
      set => reportingAddress = value;
  }

  // Path("ccb")
  [XmlRoot("results")]
  public class CCBConfigList : BaseApiListBean<CCBConfig> {    public override List<CCBConfig>? GetItems() => items;

    public override void SetItems(List<CCBConfig>? value) => items = value;

  }
}

}