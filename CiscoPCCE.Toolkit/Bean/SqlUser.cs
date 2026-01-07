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

  public string? Password
  {
      get => password;
      set => password = value;
  }

  // Path("sqluser")
  [XmlRoot("results")]
  public class SqlUserList : BaseApiListBean<SqlUser> {    public override List<SqlUser>? GetItems() => items;

    public override void SetItems(List<SqlUser>? value) => items = value;

  }
}

}