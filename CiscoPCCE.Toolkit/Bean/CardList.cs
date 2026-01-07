using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class CardList : BaseApiBean {
      
  [XmlElement("cards")]
  [XmlElement("card")]
  public List<Card>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}