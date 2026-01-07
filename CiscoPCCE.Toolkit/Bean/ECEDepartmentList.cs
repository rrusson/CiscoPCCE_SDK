using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("departments")]
public class ECEDepartmentList : BaseApiBean {
  
  public List<ECEDepartment>? Departments { get; set; }

}

}