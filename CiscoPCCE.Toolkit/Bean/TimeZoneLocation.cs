using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("timezone")
[XmlRoot("timezone")]
public class TimeZoneLocation : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? displayName;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public string? DisplayName
  {
      get => displayName;
      set => displayName = value;
  }


  public void setDisplayName(String displayName) {
     this.displayName = displayName;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneLocationList : BaseApiListBean<TimeZoneLocation> {
    [XmlElement("timezones")]
    [XmlElement("timezone")]
   
    public override List<TimeZoneLocation>? GetItems() => items;

    public override void SetItems(List<TimeZoneLocation>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TimeZoneLocation>? items)
    {
        this.items = items;
    }
  }
}

}