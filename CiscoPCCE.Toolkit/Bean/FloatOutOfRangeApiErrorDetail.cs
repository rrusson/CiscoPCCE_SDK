using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class FloatOutOfRangeApiErrorDetail : BaseApiBean {
  private float? max;
  private float? min;

  public float? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(float? max) {
     this.max = max;
  }

  public float? Min
  {
      get => min;
      set => min = value;
  }


  public void setMin(float? min) {
     this.min = min;
  }


}

}