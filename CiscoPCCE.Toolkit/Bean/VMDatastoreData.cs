using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class VMDatastoreData : BaseApiBean {
      
  public string? Name { get; set; }

  public long? SizeInGB { get; set; }

  public double UsagePercentage { get; set; }

}

}