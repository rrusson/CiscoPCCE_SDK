using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("NotificationRule")]
public class NotificationRule : BaseApiBean {
  private string? campaignUrl;
  private int? changeStamp;
  private string? description;
  private string? name;
  private string? refURL;
  private List<string?>? tags;
  private string? type;

  public string? CampaignUrl
  {
      get => campaignUrl;
      set => campaignUrl = value;
  }


  public void setCampaignUrl(String campaignUrl) {
     this.campaignUrl = campaignUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("tags")]
  [XmlElement("tag")]
  public List<string?>? Tags
  {
      get => tags;
      set => tags = value;
  }


  public void setTags(List<String> tags) {
     this.tags = tags;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }


}

}