using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("Campaign")]
public class SocialMinerCampaign : BaseApiBean {
  private int? changeStamp;
  private string? description;
  private List<string?>? feeds;
  private string? name;
  private string? refURL;

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

  [XmlElement("feeds")]
  [XmlElement("feed")]
  public List<string?>? Feeds
  {
      get => feeds;
      set => feeds = value;
  }


  public void setFeeds(List<String> feeds) {
     this.feeds = feeds;
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


}

}