using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class CloudConnectMgmtConfigWrapper : BaseApiBean {
  private CloudConnectMgmtConfig cloudConnectMgmtConfig;

  public CloudConnectMgmtConfig CloudConnectMgmtConfig
  {
      get => cloudConnectMgmtConfig;
      set => cloudConnectMgmtConfig = value;
  }


  public void setCloudConnectMgmtConfig(CloudConnectMgmtConfig cloudConnectMgmtConfig) {
     this.cloudConnectMgmtConfig = cloudConnectMgmtConfig;
  }


}

}