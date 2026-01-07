using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("aw")]
public class WebsetupAW : BaseApiBean {
                  
  public string? LoggerSideAPublicAddress { get; set; }

  public string? LoggerSideBPublicAddress { get; set; }

  public string? PreferredSide { get; set; }

  public string? PrimaryAdminAndDataServerName { get; set; }

  public string? RouterSideAPublicAddress { get; set; }

  public string? RouterSideBPublicAddress { get; set; }

  public string? SecondaryAdminAndDataServerName { get; set; }

  public string? ServiceAccountPassword { get; set; }

  public string? ServiceAccountUserName { get; set; }

}

}