using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class ChangeSet : BaseApiBean {
  private List<BaseDbRestBean>? beans;

  public List<BaseDbRestBean>? Beans
  {
      get => beans;
      set => beans = value;
  }


  public void setBeans(List<BaseDbRestBean> beans) {
     this.beans = beans;
  }


}

}