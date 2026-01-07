using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("reference")]
public class MarkDeleteReference : BaseApiBean {
  private bool? deleted;
  private string? name;
  private string? refURL;

  public bool? Deleted
  {
      get => deleted;
      set => deleted = value;
  }


  public void setDeleted(Boolean deleted) {
     this.deleted = deleted;
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


}

}