using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("businesshour")
[XmlRoot("configuredStatus")]
public class BusinessHourConfiguredStatus : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private string? refURL;
  private int? status;
  private ReferenceBean statusReason;

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

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
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

  public int? Status
  {
      get => status;
      set => status = value;
  }

  public ReferenceBean StatusReason
  {
      get => statusReason;
      set => statusReason = value;
  }

  // Path("businesshour")
  [XmlRoot("results")]
  public class BusinessHourConfiguredStatusList : BaseApiListBean<BusinessHourConfiguredStatus> {    public override List<BusinessHourConfiguredStatus>? GetItems() => items;

    public override void SetItems(List<BusinessHourConfiguredStatus>? value) => items = value;

  }
}

}