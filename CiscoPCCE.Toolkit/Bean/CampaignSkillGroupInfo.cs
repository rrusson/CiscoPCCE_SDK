using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CampaignSkillGroupInfo : BaseApiBean {
  private string? abandonedRoutePoint;
  private string? dialedNumber;
  private int? ivrPorts;
  private string? ivrRoutePoint;
  private int? overflowAgents;
  private int? recordsToCache;
  private ReferenceBean skillGroupRef;

  [XmlElement("abandonedRoutePoint")]
  public string? AbandonedRoutePoint
  {
      get => abandonedRoutePoint;
      set => abandonedRoutePoint = value;
  }


  public void setAbandonedRoutePoint(String abandonedRoutePoint) {
     this.abandonedRoutePoint = abandonedRoutePoint;
  }

  [XmlElement("dialedNumber")]
  public string? DialedNumber
  {
      get => dialedNumber;
      set => dialedNumber = value;
  }


  public void setDialedNumber(String dialedNumber) {
     this.dialedNumber = dialedNumber;
  }

  [XmlElement("ivrPorts")]
  public int? IvrPorts
  {
      get => ivrPorts;
      set => ivrPorts = value;
  }


  public void setIvrPorts(int? ivrPorts) {
     this.ivrPorts = ivrPorts;
  }

  [XmlElement("ivrRoutePoint")]
  public string? IvrRoutePoint
  {
      get => ivrRoutePoint;
      set => ivrRoutePoint = value;
  }


  public void setIvrRoutePoint(String ivrRoutePoint) {
     this.ivrRoutePoint = ivrRoutePoint;
  }

  [XmlElement("overflowAgents")]
  public int? OverflowAgents
  {
      get => overflowAgents;
      set => overflowAgents = value;
  }


  public void setOverflowAgents(int? overflowAgents) {
     this.overflowAgents = overflowAgents;
  }

  [XmlElement("recordsToCache")]
  public int? RecordsToCache
  {
      get => recordsToCache;
      set => recordsToCache = value;
  }


  public void setRecordsToCache(int? recordsToCache) {
     this.recordsToCache = recordsToCache;
  }

  [XmlElement("skillGroup")]
  public ReferenceBean SkillGroupRef
  {
      get => skillGroupRef;
      set => skillGroupRef = value;
  }


  public void setSkillGroupRef(ReferenceBean skillGroupRef) {
     this.skillGroupRef = skillGroupRef;
  }


}

}