using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class FloatOutOfRangeApiErrorDetail : BaseApiBean {
  public float? Max { get; set; }

  public float? Min { get; set; }

}

}