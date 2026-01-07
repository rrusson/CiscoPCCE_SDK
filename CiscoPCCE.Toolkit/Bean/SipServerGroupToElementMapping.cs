using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("SipServerGroupToElementMapping")]
public class SipServerGroupToElementMapping : BaseApiBean {
  private List<GroupType>? groupTypes;

  public List<GroupType>? GroupTypes
  {
      get => groupTypes;
      set => groupTypes = value;
  }


  public void setGroupTypes(List<GroupType> groupTypes) {
     this.groupTypes = groupTypes;
  }


}

}