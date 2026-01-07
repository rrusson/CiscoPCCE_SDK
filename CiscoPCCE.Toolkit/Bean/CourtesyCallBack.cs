using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("courtesyCallBack")]
public class CourtesyCallBack : BaseApiBean {
  private string? allowUnmatchedDialedNumbers;
  private List<string?>? allowedDialedNumbers;
  private List<string?>? deniedDialedNumbers;
  private string? maximumCallBacksPerAni;
  private string? reportingAddress;

  public string? AllowUnmatchedDialedNumbers
  {
      get => allowUnmatchedDialedNumbers;
      set => allowUnmatchedDialedNumbers = value;
  }


  public void setAllowUnmatchedDialedNumbers(String allowUnmatchedDialedNumbers) {
     this.allowUnmatchedDialedNumbers = allowUnmatchedDialedNumbers;
  }

  public List<string?>? AllowedDialedNumbers
  {
      get => allowedDialedNumbers;
      set => allowedDialedNumbers = value;
  }


  public void setAllowedDialedNumbers(List<String> allowedDialedNumbers) {
     this.allowedDialedNumbers = allowedDialedNumbers;
  }

  public List<string?>? DeniedDialedNumbers
  {
      get => deniedDialedNumbers;
      set => deniedDialedNumbers = value;
  }


  public void setDeniedDialedNumbers(List<String> deniedDialedNumbers) {
     this.deniedDialedNumbers = deniedDialedNumbers;
  }

  public string? MaximumCallBacksPerAni
  {
      get => maximumCallBacksPerAni;
      set => maximumCallBacksPerAni = value;
  }


  public void setMaximumCallBacksPerAni(String maximumCallBacksPerAni) {
     this.maximumCallBacksPerAni = maximumCallBacksPerAni;
  }

  public string? ReportingAddress
  {
      get => reportingAddress;
      set => reportingAddress = value;
  }


  public void setReportingAddress(String reportingAddress) {
     this.reportingAddress = reportingAddress;
  }


}

}