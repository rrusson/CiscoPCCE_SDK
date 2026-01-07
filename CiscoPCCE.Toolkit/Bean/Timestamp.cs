using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Timestamp : BaseApiBean {
  private int date;
  private int hours;
  private int minutes;
  private int month;
  private int nanos;
  private int seconds;
  private long time;
  private int year;

  public int Date
  {
      get => date;
      set => date = value;
  }


  public void setDate(int date) {
     this.date = date;
  }

  public int Hours
  {
      get => hours;
      set => hours = value;
  }


  public void setHours(int hours) {
     this.hours = hours;
  }

  public int Minutes
  {
      get => minutes;
      set => minutes = value;
  }


  public void setMinutes(int minutes) {
     this.minutes = minutes;
  }

  public int Month
  {
      get => month;
      set => month = value;
  }


  public void setMonth(int month) {
     this.month = month;
  }

  public int Nanos
  {
      get => nanos;
      set => nanos = value;
  }


  public void setNanos(int nanos) {
     this.nanos = nanos;
  }

  public int Seconds
  {
      get => seconds;
      set => seconds = value;
  }


  public void setSeconds(int seconds) {
     this.seconds = seconds;
  }

  public long Time
  {
      get => time;
      set => time = value;
  }


  public void setTime(long time) {
     this.time = time;
  }

  public int Year
  {
      get => year;
      set => year = value;
  }


  public void setYear(int year) {
     this.year = year;
  }


}

}