using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class Collection : BaseApiBean {
  private List<CollectionValue>? collectionValues;
  private string? description;
  private string? groupPermission;
  private string? id;
  private string? name;
  private string? origin;
  private string? type;
  private int? version;

  public List<CollectionValue>? CollectionValues
  {
      get => collectionValues;
      set => collectionValues = value;
  }


  public void setCollectionValues(List<CollectionValue> collectionValues) {
     this.collectionValues = collectionValues;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? GroupPermission
  {
      get => groupPermission;
      set => groupPermission = value;
  }


  public void setGroupPermission(String groupPermission) {
     this.groupPermission = groupPermission;
  }

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
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

  public string? Origin
  {
      get => origin;
      set => origin = value;
  }


  public void setOrigin(String origin) {
     this.origin = origin;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }

  public int? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(int? version) {
     this.version = version;
  }


}

}