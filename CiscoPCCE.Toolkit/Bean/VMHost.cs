using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("vmHost")]
public class VMHost : BaseApiBean {
              
  public string? Address { get; set; }

  public int? ChangeStamp { get; set; }

  public string? Name { get; set; }

  public string? Password { get; set; }

  public string? RefURL { get; set; }

  public bool? SystemDefault { get; set; }

  public string? UserName { get; set; }

}

}