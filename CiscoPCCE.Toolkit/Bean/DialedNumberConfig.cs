using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("dialedNumberConfig")]
public class DialedNumberConfig : BaseApiBean {
  private string? dialedNumber;
  private string? postCallSurveyNumber;
  private string? ringtone;

  public string? DialedNumber
  {
      get => dialedNumber;
      set => dialedNumber = value;
  }


  public void setDialedNumber(String dialedNumber) {
     this.dialedNumber = dialedNumber;
  }

  public string? PostCallSurveyNumber
  {
      get => postCallSurveyNumber;
      set => postCallSurveyNumber = value;
  }


  public void setPostCallSurveyNumber(String postCallSurveyNumber) {
     this.postCallSurveyNumber = postCallSurveyNumber;
  }

  public string? Ringtone
  {
      get => ringtone;
      set => ringtone = value;
  }


  public void setRingtone(String ringtone) {
     this.ringtone = ringtone;
  }


}

}