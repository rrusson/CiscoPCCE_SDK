using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class VruPG : BaseApiBean {
  private bool? configured;
  private string? cvp1Address;
  private string? cvp1Password;
  private string? cvp1Username;
  private string? cvp2Address;
  private string? cvp2Password;
  private string? cvp2Username;

  [XmlElement("configured")]
  public bool? Configured
  {
      get => configured;
      set => configured = value;
  }


  public void setConfigured(Boolean configured) {
     this.configured = configured;
  }

  public string? Cvp1Address
  {
      get => cvp1Address;
      set => cvp1Address = value;
  }


  public void setCvp1Address(String cvp1Address) {
     this.cvp1Address = cvp1Address;
  }

  public string? Cvp1Password
  {
      get => cvp1Password;
      set => cvp1Password = value;
  }


  public void setCvp1Password(String cvp1Password) {
     this.cvp1Password = cvp1Password;
  }

  public string? Cvp1Username
  {
      get => cvp1Username;
      set => cvp1Username = value;
  }


  public void setCvp1Username(String cvp1Username) {
     this.cvp1Username = cvp1Username;
  }

  public string? Cvp2Address
  {
      get => cvp2Address;
      set => cvp2Address = value;
  }


  public void setCvp2Address(String cvp2Address) {
     this.cvp2Address = cvp2Address;
  }

  public string? Cvp2Password
  {
      get => cvp2Password;
      set => cvp2Password = value;
  }


  public void setCvp2Password(String cvp2Password) {
     this.cvp2Password = cvp2Password;
  }

  public string? Cvp2Username
  {
      get => cvp2Username;
      set => cvp2Username = value;
  }


  public void setCvp2Username(String cvp2Username) {
     this.cvp2Username = cvp2Username;
  }


}

}