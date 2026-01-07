using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Feature : BaseApiBean {
  private string? featureName;
  private bool? systemDefined;

  public string? FeatureName
  {
      get => featureName;
      set => featureName = value;
  }


  public void setFeatureName(String featureName) {
     this.featureName = featureName;
  }

  public bool? SystemDefined
  {
      get => systemDefined;
      set => systemDefined = value;
  }


  public void setSystemDefined(bool? systemDefined) {
     this.systemDefined = systemDefined;
  }


}

}