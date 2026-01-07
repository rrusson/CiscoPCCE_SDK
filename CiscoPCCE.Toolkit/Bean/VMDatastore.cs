using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMDatastore : BaseApiBean {
  private long? maxSizeInGB;
  private long? minSizeInGB;
  private long? sizeInGB;
  private List<VMProfile>? vmsToMatch;

  public long? MaxSizeInGB
  {
      get => maxSizeInGB;
      set => maxSizeInGB = value;
  }


  public void setMaxSizeInGB(long? maxSizeInGB) {
     this.maxSizeInGB = maxSizeInGB;
  }

  public long? MinSizeInGB
  {
      get => minSizeInGB;
      set => minSizeInGB = value;
  }


  public void setMinSizeInGB(long? minSizeInGB) {
     this.minSizeInGB = minSizeInGB;
  }

  public long? SizeInGB
  {
      get => sizeInGB;
      set => sizeInGB = value;
  }


  public void setSizeInGB(long? sizeInGB) {
     this.sizeInGB = sizeInGB;
  }

  [XmlElement("vmsToMatch")]
  [XmlElement("vm")]
  public List<VMProfile>? VmsToMatch
  {
      get => vmsToMatch;
      set => vmsToMatch = value;
  }


  public void setVmsToMatch(List<VMProfile> vmsToMatch) {
     this.vmsToMatch = vmsToMatch;
  }


}

}