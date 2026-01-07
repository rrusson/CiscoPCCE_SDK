using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("user")]
public class ECEUser : BaseApiBean {
                
  public ECEDepartment Department { get; set; }

  public int? ExternalId { get; set; }

  public string? FirstName { get; set; }

  public int? Id { get; set; }

  public string? LastName { get; set; }

  public string? LoginId { get; set; }

  public string? Password { get; set; }

  public string? ScreenName { get; set; }

}

}