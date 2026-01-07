using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("awstatus")
[XmlRoot("awStatus")]
public class AwStatus : BaseApiBean {
  private double? lastRetrievalKey;

  [XmlElement("##default")]
  public double? LastRetrievalKey
  {
      get => lastRetrievalKey;
      set => lastRetrievalKey = value;
  }


  public void setLastRetrievalKey(double? lastRetrievalKey) {
     this.lastRetrievalKey = lastRetrievalKey;
  }


  // Path("awstatus")
  [XmlRoot("results")]
  public class AwStatusList : BaseApiListBean<AwStatus> {
    [XmlElement("awStatuss")]
    [XmlElement("awStatus")]
   
    public override List<AwStatus>? GetItems() => items;

    public override void SetItems(List<AwStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AwStatus>? items)
    {
        this.items = items;
    }
  }
}

}