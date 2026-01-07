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


  public void setDisplayName(String displayName) {
     this.displayName = displayName;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }


  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public string? Role
  {
      get => role;
      set => role = value;
  }


  public void setRole(String role) {
     this.role = role;
  }

  public string? Username
  {
      get => username;
      set => username = value;
  }


  public void setUsername(String username) {
     this.username = username;
  }


  // Path("useridentity")
  [XmlRoot("results")]
  public class UserIdentityList : BaseApiListBean<UserIdentity> {
    [XmlElement("userIdentitys")]
    [XmlElement("userIdentity")]
   
    public override List<UserIdentity>? GetItems() => items;

    public override void SetItems(List<UserIdentity>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<UserIdentity>? items)
    {
        this.items = items;
    }
  }
}

}