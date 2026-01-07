using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("VVB")]
public class VVBServer : BaseApiBean {
  private List<Application>? applications;
  private List<AsrServer>? asrServers;
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private MediaConfig media;
  private string? refURL;
  private SecurityConfig security;
  private List<TtsServer>? ttsServers;

  [XmlElement("applications")]
  [XmlElement("application")]
  public List<Application>? Applications
  {
      get => applications;
      set => applications = value;
  }


  public void setApplications(List<Application> applications) {
     this.applications = applications;
  }

  [XmlElement("asrServers")]
  [XmlElement("asrServer")]
  public List<AsrServer>? AsrServers
  {
      get => asrServers;
      set => asrServers = value;
  }


  public void setAsrServers(List<AsrServer> asrServers) {
     this.asrServers = asrServers;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public MediaConfig Media
  {
      get => media;
      set => media = value;
  }


  public void setMedia(MediaConfig media) {
     this.media = media;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SecurityConfig Security
  {
      get => security;
      set => security = value;
  }


  public void setSecurity(SecurityConfig security) {
     this.security = security;
  }

  [XmlElement("ttsServers")]
  [XmlElement("ttsServer")]
  public List<TtsServer>? TtsServers
  {
      get => ttsServers;
      set => ttsServers = value;
  }


  public void setTtsServers(List<TtsServer> ttsServers) {
     this.ttsServers = ttsServers;
  }


}

}