using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("pqName")]
public class PQName : BaseApiBean {
      
  public string? EnterpriseName { get; set; }

  public int? pqID { get; set; }

  public string? pqURL { get; set; }

}

}