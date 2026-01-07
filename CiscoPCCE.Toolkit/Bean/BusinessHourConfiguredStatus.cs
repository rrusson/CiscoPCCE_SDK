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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(int? status) {
     this.status = status;
  }

  public ReferenceBean StatusReason
  {
      get => statusReason;
      set => statusReason = value;
  }


  public void setStatusReason(ReferenceBean statusReason) {
     this.statusReason = statusReason;
  }


  // Path("businesshour")
  [XmlRoot("results")]
  public class BusinessHourConfiguredStatusList : BaseApiListBean<BusinessHourConfiguredStatus> {
    [XmlElement("configuredStatuss")]
    [XmlElement("configuredStatus")]
   
    public override List<BusinessHourConfiguredStatus>? GetItems() => items;

    public override void SetItems(List<BusinessHourConfiguredStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHourConfiguredStatus>? items)
    {
        this.items = items;
    }
  }
}

}