using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ChangeSetElement : BaseApiBean {
  private BaseDbRestBean beans;

  public BaseDbRestBean Beans
  {
      get => beans;
      set => beans = value;
  }


  public void setBeans(BaseDbRestBean beans) {
     this.beans = beans;
  }


}

}