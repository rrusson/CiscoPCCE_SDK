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

  [XmlElement("buildNumber")]
  public string? BuildNumber
  {
      get => buildNumber;
      set => buildNumber = value;
  }

  [XmlElement("dropNumber")]
  public string? DropNumber
  {
      get => dropNumber;
      set => dropNumber = value;
  }

  [XmlElement("esNumber")]
  public string? EsNumber
  {
      get => esNumber;
      set => esNumber = value;
  }

  [XmlElement("patchVersion")]
  public string? PatchVersion
  {
      get => patchVersion;
      set => patchVersion = value;
  }

  [XmlElement("srNumber")]
  public string? SrNumber
  {
      get => srNumber;
      set => srNumber = value;
  }

  [XmlElement("version")]
  public string? Version
  {
      get => version;
      set => version = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineVersionList : BaseApiListBean<MachineVersion> {    public override List<MachineVersion>? GetItems() => items;

    public override void SetItems(List<MachineVersion>? value) => items = value;

  }
}

}