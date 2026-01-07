using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("reference")]
public class ReferenceWithId : BaseApiBean {
  private bool? deleted;
  private int? id;
  private string? name;

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


}

}