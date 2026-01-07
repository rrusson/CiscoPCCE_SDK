using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("role")
[XmlRoot("errorDetail")]
public class InvalidFeaturesErrorDetail : BaseApiBean {
  private List<Feature>? invalidFeatures;

  [XmlElement("invalidFeatures")]
  [XmlElement("invalidFeature")]
  public List<Feature>? InvalidFeatures
  {
      get => invalidFeatures;
      set => invalidFeatures = value;
  }

  // Path("role")
  [XmlRoot("results")]
  public class InvalidFeaturesErrorDetailList : BaseApiListBean<InvalidFeaturesErrorDetail> {    public override List<InvalidFeaturesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidFeaturesErrorDetail>? value) => items = value;

  }
}

}