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

  [XmlElement("businesstimezone")]
  public string? BusinessTimeZoneName
  {
      get => businessTimeZone;
      set => businessTimeZone = value;
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

  // Path("businesstimezone")
  [XmlRoot("results")]
  public class BusinessTimeZoneList : BaseApiListBean<BusinessTimeZone> {    public override List<BusinessTimeZone>? GetItems() => items;

    public override void SetItems(List<BusinessTimeZone>? value) => items = value;

  }
}

}