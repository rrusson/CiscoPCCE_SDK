using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("locationproperties")
[XmlRoot("CVP")]
public class CVPLocationProperties : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private LocationProperties locationProperties;
  private string? refURL;

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

  public LocationProperties LocationProperties
  {
      get => locationProperties;
      set => locationProperties = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("locationproperties")
  [XmlRoot("results")]
  public class CVPLocationPropertiesList : BaseApiListBean<CVPLocationProperties> {    public override List<CVPLocationProperties>? GetItems() => items;

    public override void SetItems(List<CVPLocationProperties>? value) => items = value;

  }
}

}