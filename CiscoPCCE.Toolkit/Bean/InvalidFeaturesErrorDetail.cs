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


  public void setInvalidFeatures(List<Feature> invalidFeatures) {
     this.invalidFeatures = invalidFeatures;
  }


  // Path("role")
  [XmlRoot("results")]
  public class InvalidFeaturesErrorDetailList : BaseApiListBean<InvalidFeaturesErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<InvalidFeaturesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidFeaturesErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InvalidFeaturesErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}