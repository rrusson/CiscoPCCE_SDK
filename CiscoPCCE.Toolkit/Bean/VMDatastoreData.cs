using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMDatastoreData : BaseApiBean {
  private string? name;
  private long? sizeInGB;
  private double usagePercentage;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public long? SizeInGB
  {
      get => sizeInGB;
      set => sizeInGB = value;
  }


  public void setSizeInGB(long? sizeInGB) {
     this.sizeInGB = sizeInGB;
  }

  public double UsagePercentage
  {
      get => usagePercentage;
      set => usagePercentage = value;
  }


  public void setUsagePercentage(double usagePercentage) {
     this.usagePercentage = usagePercentage;
  }


}

}