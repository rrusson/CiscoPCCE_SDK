using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class DuplicateNameApiErrorDetail : BaseApiBean {
  private bool? deleted;
  private string? scope;

  public bool? Deleted
  {
      get => deleted;
      set => deleted = value;
  }


  public void setDeleted(Boolean deleted) {
     this.deleted = deleted;
  }

  public string? Scope
  {
      get => scope;
      set => scope = value;
  }


  public void setScope(String scope) {
     this.scope = scope;
  }


}

}