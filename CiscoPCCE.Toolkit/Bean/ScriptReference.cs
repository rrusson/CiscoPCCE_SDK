using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("reference")]
public class ScriptReference : BaseApiBean {
  private bool? deleted;
  private int? id;
  private string? name;
  private List<int?>? versions;

  public bool? Deleted
  {
      get => deleted;
      set => deleted = value;
  }


  public void setDeleted(Boolean deleted) {
     this.deleted = deleted;
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

  [XmlElement("##default")]
  public List<int?>? Versions
  {
      get => versions;
      set => versions = value;
  }


  public void setVersions(List<int?> versions) {
     this.versions = versions;
  }


}

}