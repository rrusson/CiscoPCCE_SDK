using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class OverrideMediaTermination : BaseApiBean {
  private List<NameUriPair>? dialogGroup;

  public List<NameUriPair>? DialogGroup
  {
      get => dialogGroup;
      set => dialogGroup = value;
  }


  public void setDialogGroup(List<NameUriPair> dialogGroup) {
     this.dialogGroup = dialogGroup;
  }


}

}