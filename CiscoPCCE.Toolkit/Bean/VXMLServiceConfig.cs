using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vxml")]
public class VXMLServiceConfig : BaseApiBean {
  private bool? enableAppDetailsReporting;
  private bool? enableReporting;
  private string? exclusiveFilters;
  private string? inclusiveFilters;

  public bool? EnableAppDetailsReporting
  {
      get => enableAppDetailsReporting;
      set => enableAppDetailsReporting = value;
  }


  public void setEnableAppDetailsReporting(Boolean enableAppDetailsReporting) {
     this.enableAppDetailsReporting = enableAppDetailsReporting;
  }

  public bool? EnableReporting
  {
      get => enableReporting;
      set => enableReporting = value;
  }


  public void setEnableReporting(Boolean enableReporting) {
     this.enableReporting = enableReporting;
  }

  public string? ExclusiveFilters
  {
      get => exclusiveFilters;
      set => exclusiveFilters = value;
  }


  public void setExclusiveFilters(String exclusiveFilters) {
     this.exclusiveFilters = exclusiveFilters;
  }

  public string? InclusiveFilters
  {
      get => inclusiveFilters;
      set => inclusiveFilters = value;
  }


  public void setInclusiveFilters(String inclusiveFilters) {
     this.inclusiveFilters = inclusiveFilters;
  }


}

}