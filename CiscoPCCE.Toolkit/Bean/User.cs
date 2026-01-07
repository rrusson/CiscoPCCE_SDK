using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class User : BaseApiBean {
  private string? id;
  private string? permission;

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
     this.id = id;
  }

  public string? Permission
  {
      get => permission;
      set => permission = value;
  }


  public void setPermission(String permission) {
     this.permission = permission;
  }


}

}