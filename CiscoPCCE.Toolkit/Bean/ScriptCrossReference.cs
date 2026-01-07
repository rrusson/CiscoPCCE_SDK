using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ScriptCrossReference : BaseApiBean {
  private int? foreignKey;
  private int? targetType;

  public int? ForeignKey
  {
      get => foreignKey;
      set => foreignKey = value;
  }


  public void setForeignKey(int? foreignKey) {
     this.foreignKey = foreignKey;
  }

  public int? TargetType
  {
      get => targetType;
      set => targetType = value;
  }


  public void setTargetType(int? targetType) {
     this.targetType = targetType;
  }


}

}