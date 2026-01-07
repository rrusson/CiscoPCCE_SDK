using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sqluser")
[XmlRoot("sqlUser")]
public class SqlUser : BaseApiBean {
  private string? loginName;
  private string? password;

  public string? LoginName
  {
      get => loginName;
      set => loginName = value;
  }


  public void setLoginName(String loginName) {
     this.loginName = loginName;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }


  // Path("sqluser")
  [XmlRoot("results")]
  public class SqlUserList : BaseApiListBean<SqlUser> {
    [XmlElement("sqlUsers")]
    [XmlElement("sqlUser")]
   
    public override List<SqlUser>? GetItems() => items;

    public override void SetItems(List<SqlUser>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SqlUser>? items)
    {
        this.items = items;
    }
  }
}

}