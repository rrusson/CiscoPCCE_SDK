using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class Permissions : BaseApiBean {
  private string? id;
  private List<User>? userList;

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
     this.id = id;
  }

  public List<User>? UserList
  {
      get => userList;
      set => userList = value;
  }


  public void setUserList(List<User> userList) {
     this.userList = userList;
  }


}

}