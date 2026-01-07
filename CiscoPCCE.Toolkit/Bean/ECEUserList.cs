using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("users")]
public class ECEUserList : BaseApiBean {
  private List<ECEUser>? users;

  public List<ECEUser>? Users
  {
      get => users;
      set => users = value;
  }


  public void setUsers(List<ECEUser> users) {
     this.users = users;
  }


}

}