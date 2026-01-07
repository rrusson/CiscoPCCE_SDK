using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("departments")]
public class ECEDepartmentList : BaseApiBean {
  private List<ECEDepartment>? departments;

  public List<ECEDepartment>? Departments
  {
      get => departments;
      set => departments = value;
  }


  public void setDepartments(List<ECEDepartment> departments) {
     this.departments = departments;
  }


}

}