using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMLayoutResult : BaseApiBean {
  private string? hardwareLayoutType;
  private List<string?>? hostsWithoutProfiles;
  private string? layoutName;
  private List<string?>? profilesWithoutHosts;
  private List<VMServerData>? results;
  private bool? valid;

  public string? HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }


  public void setHardwareLayoutType(String hardwareLayoutType) {
     this.hardwareLayoutType = hardwareLayoutType;
  }

  public List<string?>? HostsWithoutProfiles
  {
      get => hostsWithoutProfiles;
      set => hostsWithoutProfiles = value;
  }


  public void setHostsWithoutProfiles(List<String> hostsWithoutProfiles) {
     this.hostsWithoutProfiles = hostsWithoutProfiles;
  }

  public string? LayoutName
  {
      get => layoutName;
      set => layoutName = value;
  }


  public void setLayoutName(String layoutName) {
     this.layoutName = layoutName;
  }

  public List<string?>? ProfilesWithoutHosts
  {
      get => profilesWithoutHosts;
      set => profilesWithoutHosts = value;
  }


  public void setProfilesWithoutHosts(List<String> profilesWithoutHosts) {
     this.profilesWithoutHosts = profilesWithoutHosts;
  }

  [XmlElement("vmResults")]
  [XmlElement("vmResult")]
  public List<VMServerData>? Results
  {
      get => results;
      set => results = value;
  }


  public void setResults(List<VMServerData> results) {
     this.results = results;
  }

  public bool? Valid
  {
      get => valid;
      set => valid = value;
  }


  public void setValid(Boolean valid) {
     this.valid = valid;
  }


}

}