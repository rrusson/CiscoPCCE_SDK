using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("department")]
public class ECEDepartment : BaseApiBean {
  private string? description;
  private int? externalId;
  private int? id;
  private string? name;

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public int? ExternalId
  {
      get => externalId;
      set => externalId = value;
  }


  public void setExternalId(int? externalId) {
     this.externalId = externalId;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


}

}