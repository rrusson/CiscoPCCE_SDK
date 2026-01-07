using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class ImportContactList : BaseApiBean {
      
  [XmlElement("importContacts")]
  [XmlElement("importContact")]
  public List<ImportContactBase>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}