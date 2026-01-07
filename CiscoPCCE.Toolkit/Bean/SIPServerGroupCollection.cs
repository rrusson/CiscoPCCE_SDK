using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("sipServerGroupCollection")]
public class SIPServerGroupCollection : BaseApiBean {
  private List<SIPServerGroupWrapper>? sipServerGroupList;

  public List<SIPServerGroupWrapper>? SipServerGroupList
  {
      get => sipServerGroupList;
      set => sipServerGroupList = value;
  }


  public void setSipServerGroupList(List<SIPServerGroupWrapper> sipServerGroupList) {
     this.sipServerGroupList = sipServerGroupList;
  }


}

}