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

  public LocationProperties LocationProperties
  {
      get => locationProperties;
      set => locationProperties = value;
  }


  public void setLocationProperties(LocationProperties locationProperties) {
     this.locationProperties = locationProperties;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("locationproperties")
  [XmlRoot("results")]
  public class CVPLocationPropertiesList : BaseApiListBean<CVPLocationProperties> {
    [XmlElement("CVPs")]
    [XmlElement("CVP")]
   
    public override List<CVPLocationProperties>? GetItems() => items;

    public override void SetItems(List<CVPLocationProperties>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CVPLocationProperties>? items)
    {
        this.items = items;
    }
  }
}

}