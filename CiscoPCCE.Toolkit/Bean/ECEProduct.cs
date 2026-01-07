using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("product")]
public class ECEProduct : BaseApiBean {
  private string? build;
  private string? description;
  private string? installedBy;
  private string? integrationInfo;
  private string? name;
  private string? oneOffNumber;
  private string? psCustomizationNumber;
  private string? version;

  public string? Build
  {
      get => build;
      set => build = value;
  }


  public void setBuild(String build) {
     this.build = build;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? InstalledBy
  {
      get => installedBy;
      set => installedBy = value;
  }


  public void setInstalledBy(String installedBy) {
     this.installedBy = installedBy;
  }

  public string? IntegrationInfo
  {
      get => integrationInfo;
      set => integrationInfo = value;
  }


  public void setIntegrationInfo(String integrationInfo) {
     this.integrationInfo = integrationInfo;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? OneOffNumber
  {
      get => oneOffNumber;
      set => oneOffNumber = value;
  }


  public void setOneOffNumber(String oneOffNumber) {
     this.oneOffNumber = oneOffNumber;
  }

  public string? PsCustomizationNumber
  {
      get => psCustomizationNumber;
      set => psCustomizationNumber = value;
  }


  public void setPsCustomizationNumber(String psCustomizationNumber) {
     this.psCustomizationNumber = psCustomizationNumber;
  }

  public string? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(String version) {
     this.version = version;
  }


}

}