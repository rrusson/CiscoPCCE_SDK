using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("card")]
public class Card : BaseApiBean {
                        
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? Color { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Header { get; set; }

  public string? Icon { get; set; }

  public string? IdFromRefUrl { get; set; }

  public List<Menu>? Menus { get; set; }

  public string? RefURL { get; set; }

  public bool? SystemDefined { get; set; }

  public string? UniqueId { get; set; }

}

}