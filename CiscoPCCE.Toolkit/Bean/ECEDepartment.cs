using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("department")]
public class ECEDepartment : BaseApiBean {
        
  public string? Description { get; set; }

  public int? ExternalId { get; set; }

  public int? Id { get; set; }

  public string? Name { get; set; }

}

}