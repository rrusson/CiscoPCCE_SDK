using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("CVP")]
public class CVPServer : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private ICMServiceConfig icm;
  private int? id;
  private string? idFromRefUrl;
  private InfrastructureServiceConfig infrastructure;
  private IVRServiceConfig ivr;
  private MediaServerConfig mediaServer;
  private string? refURL;
  private SIPServiceConfig sip;
  private VXMLServiceConfig vxml;

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

  public ICMServiceConfig Icm
  {
      get => icm;
      set => icm = value;
  }


  public void setIcm(ICMServiceConfig icm) {
     this.icm = icm;
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

  public InfrastructureServiceConfig Infrastructure
  {
      get => infrastructure;
      set => infrastructure = value;
  }


  public void setInfrastructure(InfrastructureServiceConfig infrastructure) {
     this.infrastructure = infrastructure;
  }

  public IVRServiceConfig Ivr
  {
      get => ivr;
      set => ivr = value;
  }


  public void setIvr(IVRServiceConfig ivr) {
     this.ivr = ivr;
  }

  public MediaServerConfig MediaServer
  {
      get => mediaServer;
      set => mediaServer = value;
  }


  public void setMediaServer(MediaServerConfig mediaServer) {
     this.mediaServer = mediaServer;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SIPServiceConfig Sip
  {
      get => sip;
      set => sip = value;
  }


  public void setSip(SIPServiceConfig sip) {
     this.sip = sip;
  }

  public VXMLServiceConfig Vxml
  {
      get => vxml;
      set => vxml = value;
  }


  public void setVxml(VXMLServiceConfig vxml) {
     this.vxml = vxml;
  }


}

}