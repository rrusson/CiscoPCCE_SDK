using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Timestamp : BaseApiBean {
  private int date;

  public int Date
  {
      get => date;
      set => date = value;
  }

  public int Hours { get; set; }

  public int Minutes { get; set; }

  public int Month { get; set; }

  public int Nanos { get; set; }

  public int Seconds { get; set; }

  public long Time { get; set; }

  public int Year { get; set; }

}

}