using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CallGlobalSetting : BaseApiBean {
              
  public short? AbandonCallWaitTime { get; set; }

  public int? AnsweredShortCallThreshold { get; set; }

  public string? BaseUrl { get; set; }

  public ReferenceBean DefaultBucketInterval { get; set; }

  public ReferenceBean DefaultCallType { get; set; }

  public int? ServiceLevelThreshold { get; set; }

  public short? ServiceLevelType { get; set; }

}

}