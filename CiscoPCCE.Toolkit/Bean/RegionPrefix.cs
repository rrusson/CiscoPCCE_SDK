using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("regionprefix")]
public class RegionPrefix : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private Timestamp dateTimeStamp;
  private bool? daylightSavingEnabled;
  private ReferenceBean department;
  private int? gmt;
  private string? idFromRefUrl;
  private string? refURL;
  private int? regionId;
  private string? regionPrefix;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public Timestamp DateTimeStamp
  {
      get => dateTimeStamp;
      set => dateTimeStamp = value;
  }


  public void setDateTimeStamp(Timestamp dateTimeStamp) {
     this.dateTimeStamp = dateTimeStamp;
  }

  public bool? DaylightSavingEnabled
  {
      get => daylightSavingEnabled;
      set => daylightSavingEnabled = value;
  }


  public void setDaylightSavingEnabled(Boolean daylightSavingEnabled) {
     this.daylightSavingEnabled = daylightSavingEnabled;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public int? Gmt
  {
      get => gmt;
      set => gmt = value;
  }


  public void setGmt(int? gmt) {
     this.gmt = gmt;
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

  public int? RegionId
  {
      get => regionId;
      set => regionId = value;
  }


  public void setRegionId(int? regionId) {
     this.regionId = regionId;
  }

  public string? RegionPrefix
  {
      get => regionPrefix;
      set => regionPrefix = value;
  }


  public void setRegionPrefix(String regionPrefix) {
     this.regionPrefix = regionPrefix;
  }


}

}