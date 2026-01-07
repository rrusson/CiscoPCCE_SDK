using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Timeout : BaseApiBean {
  private int? abandon;
  private int? late;
  private int? request;

  public int? Abandon
  {
      get => abandon;
      set => abandon = value;
  }


  public void setAbandon(int? abandon) {
     this.abandon = abandon;
  }

  public int? Late
  {
      get => late;
      set => late = value;
  }


  public void setLate(int? late) {
     this.late = late;
  }

  public int? Request
  {
      get => request;
      set => request = value;
  }


  public void setRequest(int? request) {
     this.request = request;
  }


}

}