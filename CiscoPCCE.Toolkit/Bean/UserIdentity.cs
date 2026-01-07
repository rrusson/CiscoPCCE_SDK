using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("useridentity")
[XmlRoot("userIdentity")]
public class UserIdentity : BaseApiBean {
  private string? displayName;
  private string? firstName;
  private string? lastName;
  private string? role;
  private string? username;

  public string? DisplayName
  {
      get => displayName;
      set => displayName = value;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }

  public string? Role
  {
      get => role;
      set => role = value;
  }

  public string? Username
  {
      get => username;
      set => username = value;
  }

  // Path("useridentity")
  [XmlRoot("results")]
  public class UserIdentityList : BaseApiListBean<UserIdentity> {    public override List<UserIdentity>? GetItems() => items;

    public override void SetItems(List<UserIdentity>? value) => items = value;

  }
}

}