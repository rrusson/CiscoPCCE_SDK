using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("businesstimezone")
[XmlRoot("businesstimezone")]
public class BusinessTimeZone : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? businessTimeZone;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  [XmlElement("businesstimezone")]
  public string? BusinessTimeZone
  {
      get => businessTimeZone;
      set => businessTimeZone = value;
  }


  public void setBusinessTimeZone(String businessTimeZone) {
     this.businessTimeZone = businessTimeZone;
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

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
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


  // Path("businesstimezone")
  [XmlRoot("results")]
  public class BusinessTimeZoneList : BaseApiListBean<BusinessTimeZone> {
    [XmlElement("businesstimezones")]
    [XmlElement("businesstimezone")]
   
    public override List<BusinessTimeZone>? GetItems() => items;

    public override void SetItems(List<BusinessTimeZone>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessTimeZone>? items)
    {
        this.items = items;
    }
  }
}

}