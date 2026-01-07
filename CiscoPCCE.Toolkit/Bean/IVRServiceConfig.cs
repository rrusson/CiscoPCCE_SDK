using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ivr")]
public class IVRServiceConfig : BaseApiBean {
  private int? callTimeout;
  private bool? useBackupMediaServers;
  private bool? useMediaServerHostNames;
  private bool? useSecurityForMediaFetches;

  public int? CallTimeout
  {
      get => callTimeout;
      set => callTimeout = value;
  }


  public void setCallTimeout(int? callTimeout) {
     this.callTimeout = callTimeout;
  }

  public bool? UseBackupMediaServers
  {
      get => useBackupMediaServers;
      set => useBackupMediaServers = value;
  }


  public void setUseBackupMediaServers(Boolean useBackupMediaServers) {
     this.useBackupMediaServers = useBackupMediaServers;
  }

  public bool? UseMediaServerHostNames
  {
      get => useMediaServerHostNames;
      set => useMediaServerHostNames = value;
  }


  public void setUseMediaServerHostNames(Boolean useMediaServerHostNames) {
     this.useMediaServerHostNames = useMediaServerHostNames;
  }

  public bool? UseSecurityForMediaFetches
  {
      get => useSecurityForMediaFetches;
      set => useSecurityForMediaFetches = value;
  }


  public void setUseSecurityForMediaFetches(Boolean useSecurityForMediaFetches) {
     this.useSecurityForMediaFetches = useSecurityForMediaFetches;
  }


}

}