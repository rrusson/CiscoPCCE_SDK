using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class SkillGroupWithPqId : BaseApiBean {
  private int? id;

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }


}

}