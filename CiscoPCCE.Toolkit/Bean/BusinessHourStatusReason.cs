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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public string? Category
  {
      get => category;
      set => category = value;
  }


  public void setCategory(String category) {
     this.category = category;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
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

  public int? ReasonCode
  {
      get => reasonCode;
      set => reasonCode = value;
  }


  public void setReasonCode(int? reasonCode) {
     this.reasonCode = reasonCode;
  }

  public string? ReasonText
  {
      get => reasonText;
      set => reasonText = value;
  }


  public void setReasonText(String reasonText) {
     this.reasonText = reasonText;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonList : BaseApiListBean<BusinessHourStatusReason> {
    [XmlElement("businessHourStatusReasons")]
    [XmlElement("businessHourStatusReason")]
   
    public override List<BusinessHourStatusReason>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReason>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHourStatusReason>? items)
    {
        this.items = items;
    }
  }
}

}