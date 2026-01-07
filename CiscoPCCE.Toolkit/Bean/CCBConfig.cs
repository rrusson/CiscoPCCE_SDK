using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("ccb")
[XmlRoot("CCB")]
public class CCBConfig : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;
  private string? reportingAddress;

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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? ReportingAddress
  {
      get => reportingAddress;
      set => reportingAddress = value;
  }


  public void setReportingAddress(String reportingAddress) {
     this.reportingAddress = reportingAddress;
  }


  // Path("ccb")
  [XmlRoot("results")]
  public class CCBConfigList : BaseApiListBean<CCBConfig> {
    [XmlElement("CCBs")]
    [XmlElement("CCB")]
   
    public override List<CCBConfig>? GetItems() => items;

    public override void SetItems(List<CCBConfig>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CCBConfig>? items)
    {
        this.items = items;
    }
  }
}

}