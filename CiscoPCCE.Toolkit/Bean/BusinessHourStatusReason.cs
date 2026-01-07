using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("businesshourstatusreason")
[XmlRoot("businessHourStatusReason")]
public class BusinessHourStatusReason : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? category;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private int? reasonCode;
  private string? reasonText;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public string? Category
  {
      get => category;
      set => category = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
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

  public int? ReasonCode
  {
      get => reasonCode;
      set => reasonCode = value;
  }

  public string? ReasonText
  {
      get => reasonText;
      set => reasonText = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonList : BaseApiListBean<BusinessHourStatusReason> {    public override List<BusinessHourStatusReason>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReason>? value) => items = value;

  }
}

}