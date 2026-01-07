using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("versionInfo")]
public class MachineVersion : BaseApiBean {
  private DateTime? buildDate;
  private string? buildNumber;
  private string? dropNumber;
  private string? esNumber;
  private string? patchVersion;
  private string? srNumber;
  private string? version;

  [XmlElement("buildDate")]
  public DateTime? BuildDate
  {
      get => buildDate;
      set => buildDate = value;
  }


  public void setBuildDate(Date buildDate) {
     this.buildDate = buildDate;
  }

  [XmlElement("buildNumber")]
  public string? BuildNumber
  {
      get => buildNumber;
      set => buildNumber = value;
  }


  public void setBuildNumber(String buildNumber) {
     this.buildNumber = buildNumber;
  }

  [XmlElement("dropNumber")]
  public string? DropNumber
  {
      get => dropNumber;
      set => dropNumber = value;
  }


  public void setDropNumber(String dropNumber) {
     this.dropNumber = dropNumber;
  }

  [XmlElement("esNumber")]
  public string? EsNumber
  {
      get => esNumber;
      set => esNumber = value;
  }


  public void setEsNumber(String esNumber) {
     this.esNumber = esNumber;
  }

  [XmlElement("patchVersion")]
  public string? PatchVersion
  {
      get => patchVersion;
      set => patchVersion = value;
  }


  public void setPatchVersion(String patchVersion) {
     this.patchVersion = patchVersion;
  }

  [XmlElement("srNumber")]
  public string? SrNumber
  {
      get => srNumber;
      set => srNumber = value;
  }


  public void setSrNumber(String srNumber) {
     this.srNumber = srNumber;
  }

  [XmlElement("version")]
  public string? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(String version) {
     this.version = version;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineVersionList : BaseApiListBean<MachineVersion> {
    [XmlElement("versionInfos")]
    [XmlElement("versionInfo")]
   
    public override List<MachineVersion>? GetItems() => items;

    public override void SetItems(List<MachineVersion>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MachineVersion>? items)
    {
        this.items = items;
    }
  }
}

}